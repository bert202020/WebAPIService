using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SILogic.Model
{
    public class BusinessDataConfig
    {
        public static List<Category> Categories()
        {
            var l = new List<Category>();

            l.Add(new Category() { Name = "A", Ratio = 1.25 });
            l.Add(new Category() { Name = "B", Ratio = 1.15 });
            l.Add(new Category() { Name = "C", Ratio = 1 });

            return l;
        }

        public static Dictionary<string, double> Ratios()
        {
            var dic = new Dictionary<string, double>();

            foreach (Category category in Categories())
                dic[category.Name] = category.Ratio;

            return dic;
        }

        public static double GetRatio(string cat)
        {
            var r = Ratios();

            if (r.ContainsKey(cat))
                return r[cat];

            return 1;
        }

    }
}
