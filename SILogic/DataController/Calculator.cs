using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using SILogic.Model;

namespace SILogic.DataController
{
    public class Calculator
    {
        public static double Calculate(List<WorkerTag> data)
        {
            var sum = 0.0;

            foreach (var w in data)
                sum += w.Calculate();

            return sum;
        }

    }
}
