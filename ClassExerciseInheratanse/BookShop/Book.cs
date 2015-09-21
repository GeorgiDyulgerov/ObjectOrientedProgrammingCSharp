using System;
using System.Text;
using System.Threading;

namespace BookShop
{
   public class Book
    {
        private string title;
       private string author;
       private double price;

        public Book(string title,string author,double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

       public string Title
       {
           get { return this.title; }
           set
           {
               if (value == null||value==" ")
               {
                   throw new Exception("Title shoud not be empty!");
               }
               title = value;
           }
       }

       public string Author
       {
           get { return this.author; }
           set
           {
               if (value == null || value == " ")
               {
                   throw new Exception("Author shoud not be empty!");
               }
               author = value;
           }
           
       }

       public virtual double Price
       {
           get { return this.price; }
          protected set
           {
               if (value<0)
               {
                   throw new Exception("Price shoud be positive number!");

               }
               price = value;
           }

       }

       public override string ToString()
       {
           StringBuilder output=new StringBuilder();
           output.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);
           output.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);
           output.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);
           output.AppendFormat("-Price: {0:####.00}", this.Price);
           return output.ToString();

       }
    }
}
