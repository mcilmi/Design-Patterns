using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
    public class CloudStream : IStream {

        public void Write(String data) {
            Console.Write("Storing \"" + data + "\" to Cloud service...");
        }
    }
}
