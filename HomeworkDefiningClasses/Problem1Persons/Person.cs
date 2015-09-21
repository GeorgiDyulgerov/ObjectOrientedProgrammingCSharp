using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name,int age):this(name,age,null)
        { }
       
            
        

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be empty!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value<1||value>100)
                {
                    throw new ArgumentOutOfRangeException("Age must be in range[1...100]!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value==""||(value!=null&&!value.Contains('@')))
                {
                    throw new ArgumentException("Email should contain '@'!");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public override string ToString()
        {
            string inf=("Name: "+Name+"\nAge: "+Age);
            if (!string.IsNullOrEmpty(Email))
            {
                inf += ("\nEmail: " + Email);
            }
            return inf;
        }
    }
}