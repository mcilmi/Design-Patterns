using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern {
    public class LoggingEbookProxy : IEbook {
        private readonly string _fileName;
        private IEbook _ebook;
        public LoggingEbookProxy(string fileName) { _fileName = fileName; }
        public void Show() {
            if (this._ebook == null) {
                this._ebook = new Ebook(this._fileName);
            }

            Console.WriteLine("Performing logging...");
            this._ebook.Show();
        }

        public string GetFileName() { return this._fileName; }
    }
}
