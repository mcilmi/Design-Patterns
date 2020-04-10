using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
    public class Compress : IStream  {
        private IStream stream;
        public Compress(IStream stream) {
            this.stream = stream;
        }

        public void Write(String data) {
            var compressedData = CompressData(data);
            Console.WriteLine("Data compressed!");
            stream.Write(compressedData);
        }

        private String CompressData(String data) {
            return data.Substring(0, 5); // Return only the first 5 bytes
        }
    }
}
