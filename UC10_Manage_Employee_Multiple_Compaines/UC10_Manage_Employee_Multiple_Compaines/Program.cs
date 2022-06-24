// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMultiple
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            EmployeeWage Company = new EmployeeWage();
            Company.ComputeEmpWage();
        }
    }
}

