using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern {
    public interface INotificationService
    {
        void Send(string message, string target);
    }
}
