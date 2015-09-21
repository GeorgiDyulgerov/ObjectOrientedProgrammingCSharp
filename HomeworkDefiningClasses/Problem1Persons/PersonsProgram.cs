using System;
using Problem1Persons;

class PersonsProgram
{
    static void Main()
    {
        Person georgi=new Person("Georgi",18,"Go6@gmail.com");
        Person ivan=new Person("Ivan",23);
        Console.WriteLine(georgi);
        Console.WriteLine(ivan);
    }
}
