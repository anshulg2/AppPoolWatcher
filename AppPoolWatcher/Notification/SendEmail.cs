using System;
using System.Collections.Generic;
using System.Text;

namespace AppPoolWatcher.Notification
{
    public class SendEmail: INotificationAction
    {
        public void ActOnNotification(string Message)
        {
            //we can write code here to Send Message in Email
            Console.WriteLine("Sending Email: " + Message);
        }
    }
}
