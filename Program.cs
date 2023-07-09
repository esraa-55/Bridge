using System;

namespace bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            MessageWay email = new EmailSender();
            MessageWay web = new Websender();
            MessageWay sms = new SmsSender();
            Console.WriteLine("Send message From SYSTEM");
            SystemMessage message = new SystemMessage();
            message.subject = "The First Message"; 
            message.body = "  HI, this is The First System message";
            message.messageway = email;
            message.send();
            Console.WriteLine("-------------------------------------------------------------------------");
            message.messageway = sms;
            message.send();
            Console.WriteLine("-------------------------------------------------------------------------");

            message.messageway = web;
            message.send();
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.ReadLine();


            Console.WriteLine("Sender message from user");
            UserMessage usermsg = new UserMessage();
            usermsg.subject = " User Message";
            usermsg.body = "HI,This is the First User message";
            usermsg.UserComments = " Have a Nice Time";

            usermsg.messageway = email;
            usermsg.send();
            Console.WriteLine("-------------------------------------------------------------------------");

            usermsg.messageway = sms;
            usermsg.send();
            Console.WriteLine("-------------------------------------------------------------------------");

            usermsg.messageway = web;
            usermsg.send();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
