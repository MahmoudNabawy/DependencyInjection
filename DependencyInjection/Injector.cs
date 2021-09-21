using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Injector
    {
        //singleton to manage dependencies

        private static Injector instance = null;
        private Injector() { }

        public static Injector getInstance()
        {
            if (instance == null)
            {
                instance = new Injector();
            }
            return instance;
        }

        public Car getFiat()
        {
            return new Car("Fiat");
        }

        public Car getLambo()
        {
            return new Car("Lambo");
        }

        public Person getPerson()
        {
            return new Person(getFiat());
        }
    }
}
