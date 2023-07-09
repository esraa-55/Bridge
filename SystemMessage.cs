using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bridge
{
    
    class SystemMessage : Message
    {
       

        public override void send()
        {
            messageway.sendmessage(subject, body);

        }
    }
}
