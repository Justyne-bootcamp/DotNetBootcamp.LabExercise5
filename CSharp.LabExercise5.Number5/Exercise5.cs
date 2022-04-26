using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise5.Number5
{
    class Exercise5
    {
        abstract class Animal
        {
            public string Name { get; set; }

            public void SetName(string name)
            {
                Name = name;
            }
            public string GetName()
            {
                return Name;
            }
            public abstract void Eat();
        }
        class Dog: Animal
        {
            public override void Eat()
            {
                Console.WriteLine("{0} is Eating", base.GetName());
            }
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.SetName("mochi");
            dog.Eat();
        }
    }
}
