using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    class UserMessage  : Message
  
    {
       
        public string UserComments { get; set; }
        public override void send()
        {
            string fullbody = string.Format(" {0}\n{1}", body,   UserComments);
            messageway.sendmessage(subject, fullbody);
         
        }
    }
        
    
}
