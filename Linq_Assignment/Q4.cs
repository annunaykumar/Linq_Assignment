using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    internal class Q4
    {
        public DateTime ReportDate { get; private set; }

        public static void M()
        {
            List<Q4> env = new List<Q4>();
            Q4 e = new Q4 { ReportDate = DateTime.Now };
            env.Add(e);
            e = new Q4 { ReportDate = DateTime.Now.AddDays(5) };
            env.Add(e);
            e = new Q4 { ReportDate = new DateTime(2011, 3, 3) };
            env.Add(e);
            e = new Q4 { ReportDate = DateTime.Now };
            env.Add(e);

            foreach (Q4 r in env)
            {
                Console.WriteLine(r.ReportDate.ToString("yyyy-MMM-dd"));
            }

            
            var ud = env.Select(d => new
            {
                d.ReportDate.Year,
                d.ReportDate.Month,
                d.ReportDate.Date,
                FormattedDate = d.ReportDate.ToString("yyyy-MMM-dd")
            })
     .Distinct()
     .OrderByDescending(d => d.Year)
     .ThenByDescending(d => d.Month)
     .ThenByDescending(d => d.Date)
     .Select(d => d.FormattedDate);

            Console.WriteLine("After distinct");

            foreach (var r in ud)
            {
                Console.WriteLine(r);
            }

        }
    }
}
