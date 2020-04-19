using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern {
    public class EbookProxy : IEbook {
        private readonly string _fileName;
        private IEbook _ebook;
        public EbookProxy(string fileName) { this._fileName = fileName; }

        public void Show() {
            if (this._ebook == null) {
                this._ebook = new Ebook(_fileName);
            }
            this._ebook.Show();
        }

        public string GetFileName() { return this._fileName; }
    }
}
