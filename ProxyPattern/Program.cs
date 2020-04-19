using System;

namespace ProxyPattern {
    public class Program {
        public static void Main(string[] args) {
            var library = new Library();
            string[] fileNames = {"Clean Architecture", "Algorithms to Live by"};

            // Pre-load the names of the files
            foreach (var fileName in fileNames) {
                library.Add(new LoggingEbookProxy(fileName));
            }
            // Display all ebooks in collection
            library.OpenEbook("Clean architecture");
            library.OpenEbook("Algorithms to Live by");
        }
    }
}
