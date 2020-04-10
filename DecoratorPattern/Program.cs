using System;

namespace DecoratorPattern {
    class Program {
        static void Main(string[] args) {
            storeCreditCard(new Compress(new Encrypt((new CloudStream()))));
        }

        public static void storeCreditCard(IStream stream) {
            stream.Write("Maxamed Cilmi");
        }
    }
}
