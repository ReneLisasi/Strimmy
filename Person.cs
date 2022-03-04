using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geditor
{
    class Person
    {
        //properties
        public String Name { get; set; }

        //constructors
        public Person()
        {
            Name = "";
        }

        //constructor that takes argument
        public Person(String name)
        {
            Name = name;
        }
        public string ToStringg()
        {
            return $"{Name}";
        }
        public string getName() { return Name; }
        public void setName(String name) { Name = name; }
    }
}
