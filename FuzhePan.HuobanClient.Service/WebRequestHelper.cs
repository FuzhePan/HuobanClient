using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FuzhePan.HuobanClient.Service
{
    public enum HttpMethod
    {
        Post = 0,
        Get = 1
    }
    public class WebRequestHelper
    {
        private static CookieContainer cc = new CookieContainer();

        /// <summary>
        /// 发送数据
        /// </summary>
        private string Send(HttpMethod httpMethod, string url, string formData)
        {
            HttpWebRequest requ = WebRequest.Create(url) as HttpWebRequest;
            if (httpMethod == HttpMethod.Get)
            {
                requ.Method = "get";
            }
            else
            {
                requ.ContentType = "application/x-www-form-urlencoded";
                requ.Method = "post";
            }
            
            requ.CookieContainer = cc;

            //设置post的数据
            if(httpMethod == HttpMethod.Post && !String.IsNullOrEmpty(formData))
            {
                using (Stream stream = requ.GetRequestStream())
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(formData);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }

            HttpWebResponse res = requ.GetResponse() as HttpWebResponse;
            string result = "";
            using (Stream stream = res.GetResponseStream())
            {
                StreamReader s = new StreamReader(stream);
                result = s.ReadToEnd();
            }
            res.Close();

            return result;
        }

        public string Get(string url)
        {
            return Send(HttpMethod.Get, url,null);
        }

        public string Post(string url, string formData)
        {
            return Send(HttpMethod.Post, url, formData);
        }
    }
}
