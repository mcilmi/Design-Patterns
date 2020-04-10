using System;

namespace FacadePattern {
   public class Program {
       public static void Main(string[] args) {
            var notificationService = new NotificationService();
            notificationService.Send("Waa laguu xiisay nooh :)", "xaaskaId");
            notificationService.Send("Waryaa Hooyo wac, wey kuu bahantahaye!", "axmedPhoneId");
        }
    }
}
