using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using SILogic.Model;
using SILogic.DataController;

namespace SILogic.Tests
{
    public class TestData
    {

        public static string JsonData()
        {
            string s = @"D:\Albert\Projects\WebAPIService\Test.json";

            s = File.ReadAllText(s);

            return s;
        }


        public static List<WorkerTag> Data ()
        {
            var l = new List<WorkerTag>();

            l.Add(new WorkerTag() { Position = "manager", Salary = 150000});
            l.Add(new WorkerTag() { Position = "technician", Salary = 35000, Bonus = 5000, Category = "B" });
            l.Add(new WorkerTag() { Position = "driver", Salary = 250, Bonus = 10000, Category = "A", TimeWorked = 80 });

            return l;
        }


        public static List<WorkerTag> Make(string data)
        {
            //r jt = JsonController.Extract(data);

            var res = WorkerTag.ListFromJson(data);

            return res;
        }

    }
}
