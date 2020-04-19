using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern {
    public class ProductProxy : IProduct {
        private readonly int _id;
        private string _name;
        private IProduct _product;
        private readonly DbContext _dbContext;

        public ProductProxy(int id, DbContext dbContext) {
            _id = id;
            _dbContext = dbContext;
        }

        public int GetId() {
            if (this._product != null) return this._product.GetId();
            this._product = new Product(this._id);
            return this._product.GetId();
        }

        public string GetName() { return this._name; }

        public void SetName(string name) {
            this._name = name;
            if (this._product == null) return;

            this._product.SetName(name);
            this._dbContext.MarkAsChanged(this._product);
        }
    }
}
