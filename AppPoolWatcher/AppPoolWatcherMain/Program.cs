using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPoolWatcher.Notification;
using AppPoolWatcher.Operation;

namespace AppPoolWatcherMain
{
    class Program
    {
        static void Main(string[] args)
        {

            // Depends on Condition, we can Perform the different Actions for sending Email, SMS, and Writing Log File

            string actionRequired = ""; // Assign Value to string according to Requirement.

            Watcher watcher = null;
            switch (actionRequired)
            {
                case "LogFile":
                        WriteLogFile writeLog = new WriteLogFile();
                        watcher = new Watcher(writeLog);
                        watcher.Notify("Write in log File");
                    break;
                case "SendEmail":
                        SendEmail email = new SendEmail();
                        watcher = new Watcher(email);
                        watcher.Notify("Send Email");
                    break;
                case "SendSms":
                        SendSMS sms = new SendSMS();
                        watcher = new Watcher(sms);
                        watcher.Notify("Send SMS");
                    break;
                default:
                        Console.WriteLine("No Watcher Selected");
                    break;
            }

            Console.ReadKey();
        }
    }
}
