using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern {
    public class DbContext {
        private readonly Dictionary<int, IProduct> _updatedProducts = new Dictionary<int, IProduct>();

        public IProduct GetProduct(int id) {
            // Generate SQL statement to get the product
            Console.WriteLine($"SELECT * FROM products WHERE product_id={id}");

            var hasProduct = _updatedProducts.TryGetValue(id, out var result);
            if (hasProduct) return result;
            // Read product from DB
            var product = new ProductProxy(id,this);
            _updatedProducts.Add(id,product);
            
            return product;
        }

        public void SaveChanges() {
            // Generate SQL update statement
            foreach (var updatedProduct in this._updatedProducts.Values) {
                Console.WriteLine($"UPDATE products SET name={updatedProduct.GetName()} WHERE product_id={updatedProduct.GetId()}");
            }
            this._updatedProducts.Clear();
        }

        public void MarkAsChanged(IProduct product) { this._updatedProducts[product.GetId()] = product; }
    }
}
