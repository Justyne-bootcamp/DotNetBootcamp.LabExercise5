using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise5
{
    class Person
    {
        public int Age { get; set; }

        public virtual void Greet()
        {
            Console.WriteLine("Hello, I'm a Person");
        }

        public void SetAge(int age)
        {
            this.Age = age;
        }
    }
    class Student: Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public override void Greet()
        {
            Console.WriteLine("Hello, I'm a Student");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", Age);
        }
    }
    class Professor: Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
        public override void Greet()
        {
            Console.WriteLine("Hello, I'm a Professor");
        }
    }
    public class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(18);
            student.Greet();
            student.ShowAge();

            Professor professor = new Professor();
            professor.SetAge(50);
            professor.Greet();
            professor.Explain();

        }
    }
}
