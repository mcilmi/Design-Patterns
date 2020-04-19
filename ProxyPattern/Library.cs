using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern {
    public class Library {
        private readonly SortedDictionary<string, Ebook> _ebooks = new SortedDictionary<string, Ebook>();
        public void Add(Ebook ebook) {
            var hasEbook = this._ebooks.TryGetValue(ebook.GetFileName().ToLower(), out var result);
            if (hasEbook) return;
            this._ebooks.Add(ebook.GetFileName().ToLower(),ebook);
        }

        public void OpenEbook(string fileName) {
            var hasEbook = this._ebooks.TryGetValue(fileName.ToLower(), out var ebook );
            if (!hasEbook) {
                Console.WriteLine($"Ebook \"{fileName}\" not found!"); 
                return;
            }
            ebook.Show();
        }
    }
}
