using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LaptopShop
{
    class Battery
    {
        private string info;
        private string life;
        public Battery(string info)
        {
            this.Info = info;
        }

        public Battery(string info, string life)
            : this(info)
        {
            this.Life = life;
        }


        public string Info
        {
            get { return this.info; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Battery Name value should not be empty!");
                }
                else
                {
                    this.info = value;
                }
            }
        }

        public string Life
        {
            get
            {
                return this.life;
            }
            set
            {
                if (value=="")
                {
                    throw new ArgumentException("Battery Life value should not be empty!");
                }
                else
                {
                    this.life = value;
                }
            }
        }
        public override string ToString()
        {
            StringBuilder resultStr = new StringBuilder();
            if (this.info != null)
            {
                resultStr.AppendLine("Battery: " + this.info);
            }
            if (this.info != null)
            {
                resultStr.AppendLine("Battery Life: " + this.life);
            }
            return resultStr.ToString();
        }

    }
}
