using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern {
    public class Product : IProduct {
        private readonly int _id;
        private string _name;

        public Product(int id) { this._id = id; }

        public int GetId() { return this._id; }
        public string GetName() { return this._name; }

        public void SetName(string name) { this._name = name; }
    }
}
