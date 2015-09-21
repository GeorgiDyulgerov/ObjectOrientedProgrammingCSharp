using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Problem1HumanWorkerStudent
{
    class SortProgram
    {
        static void Main()
        {
            //StudentSort\\
            Console.WriteLine("StudentSort\n");
            List<Student> students = new List<Student>();
            students.Add(new Student("Georgi", "Dyulgerov", "46565"));
            students.Add(new Student("Pe6o", "Georgiev", "16556"));
            students.Add(new Student("Mariq", "Dyulgerova", "36455"));
            students.Add(new Student("Petar", "Petrov", "65635"));
            students.Add(new Student("Anatoli", "Nedev", "46565"));
            students.Add(new Student("Iveta", "Nedeva", "16565"));
            students.Add(new Student("Georgi", "Andreev", "46565"));
            students.Add(new Student("Radina", "Asparuhova", "26489"));
            students.Add(new Student("Nikoleta", "Stoeva", "26154"));
            students.Add(new Student("Martin", "Milev", "32548"));
            IEnumerable<Student> studentSorted = students.OrderBy(student => student.FacilityNumber);
            foreach (var student in studentSorted)
            {
                Console.WriteLine(student);
            }

            //WorkerSort\\
            Console.WriteLine("WorkerSort\n");
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Georgi", "Dyulgerov", 1000,4));
            workers.Add(new Worker("Pe6o", "Georgiev", 1698,8));
            workers.Add(new Worker("Mariq", "Dyulgerova", 1002,4));
            workers.Add(new Worker("Petar", "Petrov", 1000,4));
            workers.Add(new Worker("Anatoli", "Nedev", 1953,8));
            workers.Add(new Worker("Iveta", "Nedeva", 1656,8));
            workers.Add(new Worker("Georgi", "Andreev", 1561,8));
            workers.Add(new Worker("Radina", "Asparuhova", 900,4));
            workers.Add(new Worker("Nikoleta", "Stoeva", 2611,8));
            workers.Add(new Worker("Martin", "Milev", 800,4));
            IEnumerable<Worker> workerSorted = workers.OrderBy(worker => worker.MoneyPerHour());
            foreach (var worker in workerSorted)
            {
                Console.WriteLine(worker);
            }
            
            //MergeAllSort\\
            Console.WriteLine("\n \n \n MergeAllSort");
            List<Human> humans= students.Cast<Human>().ToList();
            humans.AddRange(workers.Cast<Human>());
            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
            Console.WriteLine("SortByFirstName");
            IEnumerable<Human> firstNameSort = humans.OrderBy(human => human.FirstName);
            foreach (var human in firstNameSort)
            {
                Console.WriteLine(human);
            }
            IEnumerable<Human> lastNameSort = humans.OrderBy(human => human.LastName);
            foreach (var human in lastNameSort)
            {
                Console.WriteLine(human);
            }

        }
    }
}
