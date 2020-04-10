using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
    public class NotificationServer {
      
        public Connection Connect(string ipAdress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken token, Message message, string target)
        {
            Console.WriteLine($"Sending \"{message.GetContent()}\" to {target} ...");
        }

    }
}
