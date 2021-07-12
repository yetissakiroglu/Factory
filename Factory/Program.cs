using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            NotifyFactory notifyFactory = new NotifyFactory();

            INotify notify = notifyFactory.CreateNotify("MAIL");

            User user = new User();

            user.UserNumber = 123456;
            user.UserName = "Y Ş";


            notify.SendNotification(user);
            Console.WriteLine("Hello World!");
        }
    }
}
