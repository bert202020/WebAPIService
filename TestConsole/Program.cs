using System;
using SILogic.DataController;
using SILogic.Model;
using SILogic.Tests;

namespace TestConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            var j = TestData.JsonData();

            Console.WriteLine(j);

            var list = TestData.Make(j);

            var res = Calculator.Calculate(list);

            Console.WriteLine(res);
        }


        private static double Calc()
        {
            var data = TestData.Data();
            var res = Calculator.Calculate(data);

            return res;
        }

    }
}
