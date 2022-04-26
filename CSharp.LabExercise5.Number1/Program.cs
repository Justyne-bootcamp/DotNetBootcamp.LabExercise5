using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.LabExercise5.Exercise1;

namespace CSharp.LabExercise5
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] personList = new Person[3];
            int counter = 0;
            do
            {
                Console.Write("Please Enter Person Name: ");
                string name = Console.ReadLine();
                personList[counter] = new Person() { Name = name };
                counter++;
            } while (counter < 3);

            foreach (Person person in personList)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
