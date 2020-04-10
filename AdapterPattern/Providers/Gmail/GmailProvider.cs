using System;
using System.Collections.Generic;
using System.Text;
using AdapterPattern;

namespace AdapterPattern.Providers {
    public class GmailProvider : GmailClient, IEmailProvider {
        public void downloadEmails() {
            base.getEmails();
        }
    }
}
