using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise5.Exercise1
{
    class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return "My Name is " + this.Name;
        }
    }
}
