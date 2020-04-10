using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
   public class NotificationService : INotificationService {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect(target);
            var authToken = server.Authenticate("0001", "xSDASxgfafs#21");
            server.Send(authToken, new Message(message), target);
        }
    }
}
