using System;

namespace Problem1HumanWorkerStudent
{
    class Student:Human
    {
        private string facilityNumber;
        public Student(string firstName, string lastName,string facilityNumber) : base(firstName, lastName)
        {
            this.FacilityNumber = facilityNumber;
        }

        public string FacilityNumber
        {
            get {return this.FacilityNumber = facilityNumber; }
            set {
                if (value.Length<5||value.Length>10)
                {
                    throw new ArgumentOutOfRangeException("facilityNumber","Facility number must be 5-10 digits\\leters long.");
                }
                facilityNumber = value;
            }
        }

        public override string ToString()
        {
            string result = base.ToString();
            result+=String.Format("    -Facility Number:{2}",this.FirstName,this.LastName,this.FacilityNumber);
            return result;
        }
    }
    }
