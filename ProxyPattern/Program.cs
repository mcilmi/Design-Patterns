using System;

namespace ProxyPattern {
    public class Program {
        public static void Main(string[] args) {
            var library = new Library();
            string[] fileNames = {"Clean Architecture", "Algorithms to Live by"};
            foreach (var fileName in fileNames) {
                library.Add(new Ebook(fileName));
            }
            library.OpenEbook("Clean architecture");
            
        }
    }
}
