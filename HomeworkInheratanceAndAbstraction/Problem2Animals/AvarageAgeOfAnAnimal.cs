using System;
using System.Linq;
using Problem2Animals.Animals;

namespace Problem2Animals
{
    class AvarageAgeOfAnAnimal
    {
        static void Main()
        {
            Frog kerm=new Frog("Kerm",4,"male");
            kerm.ProduceSound();
            Tomcat tommy=new Tomcat("Tommy",8,"");
            tommy.ProduceSound();
            Animal[] animals=new Animal[]{new Dog("SnoopDog",5,"male"),new Kitten("Mia",2,""),new Tomcat("Tom",5,""),new Frog("Kermit",12,"male"),new Dog("Max",1,"male"),    };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
            //AvarageAgeOfAll\\
            double avarageOfAll= animals.Average(animal => animal.Age);
            Console.WriteLine("Avarage: {0}",avarageOfAll);
            //AvarageOfDog\\
            double avarageOfDog = animals.OfType<Dog>().Average(dog => dog.Age);
            Console.WriteLine("Avarage Dog:{0}",avarageOfDog);
            //AvarageOfCat\\
            double avarageOfCat = animals.OfType<Cat>().Average(cat => cat.Age);
            Console.WriteLine("Avarage Cat:{0}",avarageOfCat);
        }
    }
}
