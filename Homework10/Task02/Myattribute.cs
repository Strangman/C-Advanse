using System;

namespace Task02
{
    [AttributeUsage(AttributeTargets.Method)]
    class Myattribute:Attribute
    {
        public string Name { get; set;}
        public int number { get; set; }
        public Myattribute(string Name, int number = 1)
        {
            this.Name = Name;
            this.number = number;
        }
    }
}
