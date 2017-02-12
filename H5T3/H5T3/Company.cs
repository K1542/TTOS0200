using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5T3
{
    class Company
    {
        private Stack<Worker> workers;

        public Company()
        {
            workers = new Stack<Worker>();
        }
        public void AddEmployee(string name)
        {
            workers.Push(new Worker(name));
        }
        public void FireLast()
        {
            System.Console.Write("Worker '");
            workers.Pop().PrintData();
            System.Console.Write("' kicked out\n");
        }
        public void PrintData()
                {
                    foreach (Worker worker in workers)
                    {
                        System.Console.Write("Worker name ");
                        worker.PrintData();
                        System.Console.Write("\n");
                    }
                }
    }
}
