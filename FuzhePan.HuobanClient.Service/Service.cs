using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FuzhePan.HuobanClient.Service
{
    public class Service
    {
        public string BaseUrl { get; private set; }
        public string LoginUrl { get; private set; }
        public string ReceiveLetterUrl { get; private set; }
        public string OrganizationDataUrl { get; private set; }
        public string OrganizationMemberDataUrl { get; private set; }

        public string NoticeLink { get; private set; }
        public string MessageLink { get; private set; }
        public string ReminderLink { get; private set; }

        private WebRequestHelper webRequest = new WebRequestHelper();

        public User CurrentUser { get; private set; }
        public Service(string baseUrl)
        {
            this.BaseUrl = baseUrl.TrimEnd(new[] { '/' });
            LoginUrl = String.Format("{0}/{1}", this.BaseUrl, "Account/Login");
            ReceiveLetterUrl = String.Format("{0}/{1}", this.BaseUrl, "Home/_ReceiveLetter");
            OrganizationDataUrl = String.Format("{0}/{1}", this.BaseUrl, "Organization/_Organizations");
            OrganizationMemberDataUrl = String.Format("{0}/{1}", this.BaseUrl, "Colleague");
        }

        private void InitialLink(string userId)
        {
            NoticeLink = String.Format("{0}/Home/NoticeList?onlyUnHandled=True&pageIndex=1&userId={1}", this.BaseUrl, userId);
            MessageLink = String.Format("{0}/Home/SessionList?pageIndex=1&userId={1}", this.BaseUrl, userId);
            ReminderLink = String.Format("{0}/Home/ReminderList?pageIndex=1&userId={1}", this.BaseUrl, userId);
        }

        public string GetUserSpaceLink(string userId)
        {
            return String.Format("{0}/User/{1}",this.BaseUrl,userId);
        }

        public bool Login(string userName, string password)
        {
            var loginHtml = webRequest.Get(LoginUrl);
            string regex = @"<input[^>]+name=""__RequestVerificationToken""[^>]+type=""hidden""[^>]+value=""(.+?)"" />";
            MatchCollection ms = Regex.Matches(loginHtml, regex);
            string token = ms[0].Groups[1].Value;

            var postHtml = webRequest.Post(LoginUrl, String.Format("UserName={0}&Password={1}&__RequestVerificationToken={2}", userName, password, token));
            var result = postHtml.Contains("退出登录");

            if (result)
            {
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(postHtml);

                var userCardNodes = document.DocumentNode.SelectSingleNode("//div[@class='avatar-mini ']");
                var userId = userCardNodes.GetAttributeValue("data-card-id", "").Substring(5);

                var img = userCardNodes.Descendants("img").FirstOrDefault();
                var trueName = img.GetAttributeValue("title", "");

                CurrentUser = new User
                {
                    Id = userId,
                    UserName = userName,
                    TrueName = trueName
                };

                InitialLink(userId);
            }

            return result;
        }

        public UnHandledLetter GetUnhandledLetter()
        {
            var json = webRequest.Get(ReceiveLetterUrl);

            var strs = json.Split(new[] { "{\"noticeCount\":[", "],\"messageCount\":[", "],\"reminderCount\":[", "]" },
               StringSplitOptions.RemoveEmptyEntries);

            return new UnHandledLetter
            {
                NoticeCount = Convert.ToInt32(strs[0]),
                MessageCount = Convert.ToInt32(strs[1]),
                ReminderCount = Convert.ToInt32(strs[2]),
            };
        }

        private List<Organization> organizations = null;
        public List<Organization> GetAllOrganizations()
        {
            if (organizations != null)
            {
                return organizations;
            }

            var orgJson = webRequest.Get(OrganizationDataUrl);
            var orgsWithoutMember = JsonConvert.DeserializeObject<List<Organization>>(orgJson);
            foreach (var org in orgsWithoutMember)
            {
                org.Members = GetUsers(org.id);
            }
            organizations = orgsWithoutMember;
            return organizations;
        }

        public User GetUser(string userId)
        {
            var orgs = GetAllOrganizations();
            foreach (var org in orgs)
            {
                foreach (var u in org.Members)
                {
                    if(u.Id.Trim() == userId.Trim())
                    {
                        return u;
                    }
                }
            }

            return null;
        }

        public List<User> GetUsers(string organizationId)
        {
            var userHtml = webRequest.Get(String.Format("{0}?organizationId={1}", OrganizationMemberDataUrl, organizationId));

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(userHtml);

            var userCardNodes = document.DocumentNode.SelectNodes("//div[@class='user-card']");
            var userList = new List<User>();
            if (userCardNodes == null)
            {
                return userList;
            }

            foreach (var n in userCardNodes)
            {
                var user = new User();
                user.Id = n.GetAttributeValue("id", String.Empty).Substring(5);
                user.TrueName = n.Descendants("h4").ElementAt(0).InnerText.Trim(new[] { '\r', '\n', ' ' });
                user.OrganizationId = organizationId;
                var mediaTextNodes = n.Descendants("p");
                user.Position = mediaTextNodes.ElementAt(1).GetAttributeValue("title", String.Empty);
                user.ExtNumber = mediaTextNodes.ElementAt(2).InnerText;
                user.PhoneNumber = mediaTextNodes.ElementAt(3).InnerText;
                user.Email = mediaTextNodes.ElementAt(4).ChildNodes.Where(cn => cn.Name == "a").FirstOrDefault().InnerText;

                userList.Add(user);
            }

            return userList;
        }
    }
}
