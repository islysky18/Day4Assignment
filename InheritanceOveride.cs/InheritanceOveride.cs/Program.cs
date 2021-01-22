using System;

namespace InheritanceOveride.cs
{

    public abstract class CityBaseClass {
        public virtual void constructCityBase() {
            Console.WriteLine("Constructing the CityBase.");
        }
        
    }

    public class CityDerivedClass : CityBaseClass {

        public override void constructCityBase()
        {
            Console.WriteLine("Constructing the Derived City.");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            CityBaseClass newCity = new CityDerivedClass();
            newCity.constructCityBase();
        }
    }
}
