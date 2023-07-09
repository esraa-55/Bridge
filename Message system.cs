using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bridge;

namespace bridge
{
     public abstract class Message
    {
        public MessageWay messageway { get; set; }
        public string subject{ get; set; }
        public string body { get; set; }
        public abstract void send();



    }
}
