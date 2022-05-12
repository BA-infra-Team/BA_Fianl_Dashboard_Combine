using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Dashboard
{
    public static class DataProvider
    {
        public static IEnumerable<double> Values
        {
            get
            {
                var r = new Random();

                for (var i = 0; i < 30; i++)
                {
                    yield return r.NextDouble() * 100;
                }
            }
        }
    }
}
