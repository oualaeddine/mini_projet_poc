using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tester
{
    class Program
    {
        static void Main(string[] args)
        {
            new OuvragesDAL.OuvrageDAO().getAll();
            Console.Read();
        }
    }
}
