using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
   public interface MessageWay
    {
        void sendmessage(string subject, string body);
    }
}
