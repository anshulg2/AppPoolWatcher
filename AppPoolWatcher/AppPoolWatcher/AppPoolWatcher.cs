using System;
using AppPoolWatcher.Notification;

namespace AppPoolWatcher.Operation
{
    public class Watcher
    {
        INotificationAction action = null;

        //Constructor Injection : to call Concrete Class for Email, SMS and Log File.
        public Watcher(INotificationAction concreteAction)
        {
            this.action = concreteAction;
        }
        
        public void Notify(string message)
        {
            action.ActOnNotification(message);
        }
    }
}
