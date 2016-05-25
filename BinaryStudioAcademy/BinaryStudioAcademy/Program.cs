using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryStudioAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            People peoples = new People();

            peoples.AddPeople(new People("Roma", 26));
            peoples.AddPeople(new People("Marta", 24));

            Console.WriteLine(string.Join("\n", peoples.GetPeoples()));
            Console.ReadLine();
        }
    }

    class People
    {
        private readonly List<People> listOfPeoples = new List<People>();
        public string Name { get; set; }
        public int Age { get; set; }

        public People() { }

        public People(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public List<People> GetPeoples()
        {
            return listOfPeoples;
        }

        public void AddPeople(People people)
        {
            listOfPeoples.Add(people);
        }

        public int CountPeople()
        {
            return listOfPeoples.Count;
        }

        public override string ToString()
        {
            return "Name: " + Name + "   Age: " + Age;
        }
    }
}
