using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Model
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public IList<string> Toppings { get; set; } = new List<string>();

        public virtual void Cut()
        {
            Console.WriteLine("Cutting.................");
        }

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing...............");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Baking..................");
        }

        public virtual void Box()
        {
            Console.WriteLine("Boxing..................");
        }
    }
}
