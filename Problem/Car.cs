using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public class Car
    {
        private string name;

        public Car(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
    }
}
