using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
    public class Encrypt : IStream {
        private IStream stream;
        public Encrypt(IStream stream) {
            this.stream = stream;
        }
        public void Write(String data) {
            var encryptedData = encrypt(data);
            Console.WriteLine("Data encrypted!");
            stream.Write(encryptedData);
        }

        private String encrypt(String data) {
            return "!@#$!/$s€CkmlA";
        }
    }
}
