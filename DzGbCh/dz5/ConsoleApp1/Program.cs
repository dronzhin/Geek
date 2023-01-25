using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public virtual void Drive()
        {
            Console.WriteLine("Я машина, я еду");
        }
    }
    class SportCar : Car
    {
        public void Drive()
        {
            Console.WriteLine("Я еду очень быстро");
        }
    }
    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Drive(new Car());
            person.Drive(new SportCar());
            Console.ReadKey();
        }
    }
}
