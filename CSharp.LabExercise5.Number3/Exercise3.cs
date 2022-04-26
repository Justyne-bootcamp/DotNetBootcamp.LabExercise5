using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise5.Number3
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "My name is " + this.Name;
        }
    }
    class Student: Person
    {
        public Student(string name): base(name){}

        public void Study()
        {
            Console.WriteLine("{0} is studying", base.Name);
        }
    }
    class Teacher: Person
    {
        public Teacher(string name): base(name){}

        public void Explain()
        {
            Console.WriteLine("{0} is Explaining", base.Name);
        }
    }
    class Exercise3
    {
        static void FillArray(Person[] personList)
        {
            int counter = 0;

            do
            {
                Console.Write("Please Enter Person Name: ");
                string name = Console.ReadLine();

                if (counter < 2)
                {
                    personList[counter] = new Student(name);
                }
                else
                {
                    personList[counter] = new Teacher(name);

                }
                counter++;
            } while (counter < 3);
        }
        static void RenderArrayContent(Person[] personList)
        {
            for (int i = 0; i < 3; i++)
            {
                if (personList[i].GetType().Equals(typeof(Student)))
                {
                    ((Student)personList[i]).Study();
                }
                else
                {
                    ((Teacher)personList[i]).Explain();
                }
            }
        }
        static void Main(string[] args)
        {
            Person[] personList = new Person[3];

            FillArray(personList);
            RenderArrayContent(personList);
        }
    }
}
