using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_14Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DateTime parsed;
            if (DateTime.TryParseExact("20110119", "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsed))
            {
                Console.WriteLine((parsed.ToString("yyyy-MM-dd")));
            }
            Console.ReadLine();*/

            string sDate = "20100504";
            DateTime NewDate = DateTime.ParseExact(sDate, "yyyyMMdd", null, System.Globalization.DateTimeStyles.AllowWhiteSpaces);
            Console.WriteLine(NewDate.ToString("yyyy-MM-dd"));
            Console.ReadLine();
        }
    }
}
