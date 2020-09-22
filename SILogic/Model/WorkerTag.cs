using Newtonsoft.Json.Linq;
using SILogic.DataController;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SILogic.Model
{
    public class WorkerTag
    {
        //        public string Position { get; set; }

        // 1.	position
        // positon!!!

        public string Position { get; set; }

        public double Salary { get; set; }

        public double Bonus { get; set; }

        public string Category { get; set; }

        public double TimeWorked { get; set; }


        public virtual double Calculate()
        {

            var sum = Bonus;

            var salary = Salary;

            var drv = "driver".Equals(Position);

            var tech = "technician".Equals(Position);

            var cat = drv || tech;

            if (cat)
            {
                var category = Category;

                var ratio = BusinessDataConfig.GetRatio(category);

                salary *= ratio;
            }

            sum += drv ? salary * TimeWorked : salary;

            return sum;
        }


        public static List<WorkerTag> ListFromJson(string data)
        {
            var jt = JsonController.Extract(data);

            return jt.ToObject<List<WorkerTag>>();
        }

        public static WorkerTag FromJson(string data)
        {
            var jt = JsonController.Extract(data);
            return jt.ToObject<WorkerTag>();
        }
    }
}
