using System;
using System.Collections.Generic;
using System.Text;
using AdapterPattern.Providers;

namespace AdapterPattern {
    class Program {
        public static void Main(string[] args) {
            var emailClient = new EmailClient();
            var outlookProvider = new OutlookProvider();
            var gmailProvider = new GmailProvider();
            emailClient.addProvider(outlookProvider);
            emailClient.addProvider(gmailProvider);

            emailClient.downloadEmails();
            
        }
    }
}
