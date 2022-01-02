using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
         public void Run()
         {
            var cat = FactoryFactory.GetFactory("Cat");
            var cat1 = cat.Create("Misse");
            var dog = FactoryFactory.GetFactory("Dog");
            var dog1 = dog.Create("Fido");

            Console.WriteLine(cat1.Name + " " + dog1.Name);
         }
    }
}
