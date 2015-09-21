namespace Problem2Animals.Animals
{
    class Kitten:Cat
    {
        private const string kittenGender = "female";

        public Kitten(string name, int age, string gender) : base(name, age, kittenGender)
        {
        }
    }
}
