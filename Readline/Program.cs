using System;

namespace Readline
{
    public class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public double Weight { get; private set; }
        public double Height { get; private set; }

        public Person(string name, string surname, int age, double weight, double height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }
        public override string ToString() 
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {Age}, Weight: {Weight}, Height: {Height}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = (Console.ReadLine());

            Console.WriteLine("Enter surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height:");
            double height = Convert.ToDouble(Console.ReadLine());

            Person person = new Person(name, surname, age, weight, height);

            Console.WriteLine(person.ToString());
        }
    }
}
