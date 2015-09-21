using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicscard;
        private string hdd;
        private string screen;
        private double price;
        private Battery battery;

        public Laptop(string model, double price)
            
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, string manufacturer,string processor,string ram,
            string graphicscard,string hdd,string screen,string info,string life,double price)
            : this(model, price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.Graphicscard = graphicscard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery=new Battery(info,life);
            this.Price = price;

        }
        

        public Battery Battery { get; set; }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model value should not be empty!");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer value should not be empty!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Processor value should not be empty!");
                }
                else
                {
                    this.processor = value;
                }
            }
        }
        public string RAM
        {
            get { return this.ram; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("RAM value should not be empty!");
                }
                else
                {
                    this.ram = value;
                }
            }
        }
        public string Graphicscard
        {
            get { return this.graphicscard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Graphicscard value should not be empty!");
                }
                else
                {
                    this.graphicscard = value;
                }
            }
        }
        public string HDD
        {
            get { return this.hdd; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("HDD value should not be empty!");
                }
                else
                {
                    this.hdd = value;
                }
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Screen value should not be empty!");
                }
                else
                {
                    this.screen = value;
                }
            }
        }
        public double Price
        {
            get { return this.price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Price value should not be empty!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

            public override string ToString()
    {
        string info = "";
        if (Model != null) 
        { info += "Model: " + Model; }
        if (Manufacturer != null) { info += "\nManufacturer: " + Manufacturer; }
        if (Processor != null) { info += "\nProcessor: " + Processor; }
        if (RAM != null) { info += "\nRAM: " + RAM; }
        if (Graphicscard != null) { info += "\nGraphicsCard: " + Graphicscard; }
        if (HDD != null) { info += "\nHDD: " + HDD; }
        if (Screen != null) { info += "\nScreen: " + Screen; }
       // if (Battery.Info != null){info += (this.Battery.ToString());}
        if (Price != 0) { info += "\nPrice: " + Price + " lv."; }
        return info;
    }

        
    }
}
