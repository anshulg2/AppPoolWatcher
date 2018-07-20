using System;
using System.Collections.Generic;
using System.Text;

namespace AppPoolWatcher.Notification
{
    public class SendSMS: INotificationAction
    {
        public void ActOnNotification(string Message)
        {
            // we can write code to Send Message in SMS
            Console.WriteLine("Sending SMS: " + Message);
        }
    }
}
