using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
   public class GoldenEditionBook : Book
   {
       private double price;
       public GoldenEditionBook(string title, string author,double price)
           :base(title,author,price)
       {
           
       }

       public override double Price
       {
           get { return this.price; }
           protected set
           {
               if (value < 0)
               {
                   throw new Exception("Price shoud be positive number!");

               }
               price = value+(value*30/100);
           }
       }

       //public override string ToString()
       //{
       //    StringBuilder output = new StringBuilder();
       //    output.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);
       //    output.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);
       //    output.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);
       //    output.AppendFormat("-Price: {0:####.00}{1}", this.Price, Environment.NewLine);
       //    return output.ToString();
       //}
    }
}
