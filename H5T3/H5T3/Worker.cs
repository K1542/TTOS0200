using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5T3
{
    class Worker
    {
        private string name;
        public Worker(string name)
        {
            this.name = name;
        }
        public void PrintData()
        {
            System.Console.Write(name);
        }
    }
}
