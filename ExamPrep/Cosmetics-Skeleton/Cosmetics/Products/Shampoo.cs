using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;
using Cosmetics.Contracts;

namespace Cosmetics.Products
{
    class Shampoo:Product,IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender,uint milliliters,UsageType usage) 
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters { get; private set; }
        public UsageType Usage { get; private set; }

        public override string Print()
        {
            StringBuilder output=new StringBuilder(base.Print());
            output.AppendLine(String.Format("  * Quantity: {0} ml", this.Milliliters));
            output.Append(String.Format("  * Usage: {0} ", this.Usage));
            return output.ToString();
        }
    }
}
