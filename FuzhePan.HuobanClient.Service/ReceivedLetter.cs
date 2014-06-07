using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzhePan.HuobanClient.Service
{
    public class UnHandledLetter
    {
        public int NoticeCount { get; set; }
        public int MessageCount { get; set; }
        public int ReminderCount { get; set; }
        public List<long> ReminderId { get; set; }
    }
}
