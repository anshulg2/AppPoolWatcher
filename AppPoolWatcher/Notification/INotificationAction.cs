using System;
using System.Collections.Generic;
using System.Text;

namespace AppPoolWatcher.Notification
{
    public interface INotificationAction
    {
        void ActOnNotification(string message);
    }
}
