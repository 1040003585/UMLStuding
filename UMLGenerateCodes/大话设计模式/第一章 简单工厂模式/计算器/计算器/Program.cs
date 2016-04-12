using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");

            Operation oper = OperationFactory.createOperation("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            Console.WriteLine( oper.GetResult());
            oper.GetResult();
            Console.Read();
        }
    }
}
