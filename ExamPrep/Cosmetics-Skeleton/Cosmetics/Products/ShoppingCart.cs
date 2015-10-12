using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;

namespace Cosmetics.Products
{
    class ShoppingCart:IShoppingCart
    {
        private readonly List<IProduct> productsToBuy; 
        public ShoppingCart()
        {
            this.productsToBuy=new List<IProduct>();
        }
        
        public void AddProduct(IProduct product)
        {
            this.productsToBuy.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.productsToBuy.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.productsToBuy.Contains(product);
        }

        public decimal TotalPrice()
        {
            return this.productsToBuy.Sum(p => p.Price);
        }
    }
}
