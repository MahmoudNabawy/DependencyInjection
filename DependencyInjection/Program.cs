using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //The problem :
            //Here person who create car and any change in car class will affeted in person
            //We can not test person alone 
            Problem.Person personProblem = new Problem.Person();
            Console.WriteLine("The Problem : ");
            personProblem.drive();

            //Solution one :
            //Using car object in constractor of person
            SolutionOne.Car carSolutionOne = new SolutionOne.Car("fait");
            SolutionOne.Person personSolutionOne = new SolutionOne.Person(carSolutionOne);
            Console.WriteLine("The Solution One : ");
            personSolutionOne.drive();

            //Solution two :
            //Using Setter Methods
            SolutionTwo.Car carSolutionTwo = new SolutionTwo.Car("fait");
            SolutionTwo.Person personSolutionTwo = new SolutionTwo.Person();
            personSolutionTwo.setCar(carSolutionTwo);
            Console.WriteLine("The Solution Two : ");
            personSolutionTwo.drive(); 

            // Best Solution Using Dependency Injector
            Injector injector = Injector.getInstance();
            Person person = injector.getPerson();
            Person anotherPerson = injector.getPerson();

            Car fiat = injector.getFiat();
            Car lambo = injector.getLambo();

            Console.WriteLine("The Dependency Injector : ");
            person.drive();
            anotherPerson.drive();

        }
    }
}
