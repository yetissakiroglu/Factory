using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class EMailNotify : INotify
    {
        public void SendNotification(User user)
        {
            // Mail gönderme operasyonu.
            Console.WriteLine(user.UserNumber + "- " + user.UserName);

        }
    }
}
