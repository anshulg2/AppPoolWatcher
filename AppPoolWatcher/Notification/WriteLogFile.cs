using System;
using System.Collections.Generic;
using System.Text;

namespace AppPoolWatcher.Notification
{
    public class WriteLogFile:INotificationAction
    {
        public void ActOnNotification(string Message)
        {
            //We Can write code here to Write Message in Log File
            Console.WriteLine("Writing Log File: " + Message);
        }
    }
}
