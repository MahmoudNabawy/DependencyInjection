using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public class Person
    {
        private Car car = new Car("Fait");

        public Person()
        {
        }

        public void drive()
        {
            Console.WriteLine("Can Driver This Car : " + car.getName());
        }
    }
}
