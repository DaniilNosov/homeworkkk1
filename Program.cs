using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    public class Factory
    {
        abstract class Car
        {
            public abstract void Info();
        }

        class Audi : Car
        {
            public override void Info()
            {
                Console.WriteLine("Audi");
            }
        }
        class Toyota : Car
        {
            public override void Info()
            {
                Console.WriteLine("Toyota");
            }
        }
        abstract class Engine
        {
            public virtual void GetPower() { }
        }
        class AudiEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Audi Engine power 4.4");
            }
        }
        class ToyotaEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Toyota Engine power 3.2");
            }
        }
        interface CarFact
        {
            Car CreateCar();
            Engine CreateEngine();
        }
        class AudiFactory : CarFact
        {
            Car CarFact.CreateCar()
            {
                return new Audi();
            }
            Engine CarFact.CreateEngine()
            {
                return new AudiEngine();
            }
        }
        class ToyotaFactory : CarFact
        {
            Car CarFact.CreateCar()
            {
                return new Toyota();
            }
            Engine CarFact.CreateEngine()
            {
                return new ToyotaEngine();
            }
        }
        static void Main(string[] args)
        {
            CarFact carfact = new ToyotaFactory();
            Car myCar = carfact.CreateCar();
            myCar.Info();
            Engine myEngine = carfact.CreateEngine();
            myEngine.GetPower();
            carfact = new AudiFactory();
            myCar = carfact.CreateCar();
            myCar.Info();
            myEngine = carfact.CreateEngine();
            myEngine.GetPower();
            myCar = carfact.CreateCar();
            Console.ReadKey();
        }
    }
}