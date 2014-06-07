using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzhePan.HuobanClient.Service
{
    public class Organization
    {
        public bool clickable { get; set; }
        public string iconSkin { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public bool open { get; set; }
        public string pId { get; set; }
        public bool rightClickable { get; set; }
        public string target { get; set; }
        public string url { get; set; }

        public IEnumerable<User> Members { get; set; }
    }
}
