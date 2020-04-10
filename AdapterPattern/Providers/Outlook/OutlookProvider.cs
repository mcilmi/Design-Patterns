using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Providers {
    public class OutlookProvider : IEmailProvider {
        public void downloadEmails() {
            Console.WriteLine("Downloading emails from Outlook...");
        }
    }
}
