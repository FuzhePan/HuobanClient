using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzhePan.HuobanClient.Service
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string TrueName { get; set; }
        public string OrganizationId { get; set; }
        public string Position { get; set; }
        /// <summary>
        /// 分机号码
        /// </summary>
        public string ExtNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
