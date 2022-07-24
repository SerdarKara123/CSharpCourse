using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Managers(),
                new Worker(),
                new Robot()
        };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Managers()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }
            Console.ReadLine();
    }
}

interface IWorker
{
    void Work();

}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}

class Managers : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine("Managers Eating");
    }

    public void GetSalary()
    {
            Console.WriteLine("Managers GetSalary");
    }

    public void Work()
    {
            Console.WriteLine("Managers Working");
    }
}

class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
            Console.WriteLine("Worker Eating");
    }

    public void GetSalary()
    {
            Console.WriteLine("Worker GetSalary");
    }

    public void Work()
    {
            Console.WriteLine("Worker Working");
    }
}

class Robot : IWorker
{
    public void Work()
    {
            Console.WriteLine("Robot Working");
    }
}
}



// burada yapılan işlemler interfacelerin doğru yapılandırılmasıdır.
// bir class birden fazla interface i iplemente edebilir.