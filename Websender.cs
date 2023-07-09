using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
     public class Websender:MessageWay
    {
        public void sendmessage(string subject,string body)
        {
            Console.WriteLine("Webservice\n{0}\n{1}\n" , subject , body);
              
        }


    }
}
