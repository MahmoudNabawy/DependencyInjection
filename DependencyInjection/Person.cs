using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Person : IPerson
    {
        private Car car;

        public Person(Car car)
        {
            this.car = car;
        }

        public void drive()
        {
            Console.WriteLine("Can Driver This Car : " + car.getName());
        }

    }
}
