using System;
using System.Runtime.InteropServices;

namespace Problem2Animals
{
    abstract class Animal:ISoundProducible
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Gender
        {
            get {return this.Gender = gender; }
            set
            {
                //if (value != "male" || value != "female")
                //{
                //    try
                //    {
                //        throw new Exception();
                //    }
                //    catch (Exception)
                //    {

                //        Console.WriteLine("Gender should be male or female.");
                //    }
                    
                //}
                gender = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Type: {3}    Name:{0}  Age:{1}    Gender:{2}",this.Name,this.Age,this.Gender,this.GetType());
        }

        public abstract void ProduceSound();
    }
}
