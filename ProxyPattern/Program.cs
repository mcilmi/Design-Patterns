using System;

namespace ProxyPattern {
    public class Program {
        public static void Main(string[] args) {
           var dbContext = new DbContext();
           int[] ids = {1,2,3};
           string[] names = {"Cambe","Moos", "Timir"};

           foreach (var idx in ids) {
               var product = dbContext.GetProduct(idx);
               product.SetName(names[idx-1]);
               dbContext.SaveChanges();
           }

           

        }
    }
}
