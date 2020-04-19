using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern {
    public class Ebook : IEbook {
        private readonly string _fileName;

        public Ebook(string fileName) {
            _fileName = fileName;
            this.Load();
        }
        private void Load() { Console.WriteLine($"Loading the ebook: \"{_fileName}\"...");}

        public void Show() {
            Console.WriteLine($"Showing the ebook: \"{_fileName}\"");
        }
        public string GetFileName() { return this._fileName; }
    }
}
