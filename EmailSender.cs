using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public class EmailSender : MessageWay
    {
        public void sendmessage(string subject, string body)
        {
            Console.WriteLine("Email Sender\n{0}\n{1}\n" , subject , body);

        }


    }
}
