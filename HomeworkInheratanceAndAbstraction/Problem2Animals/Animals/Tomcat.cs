namespace Problem2Animals.Animals
{
    class Tomcat:Cat
    {
        private const string tomGender = "male";

        public Tomcat(string name, int age, string gender) : base(name, age, tomGender)
        {
        }
    }
}
