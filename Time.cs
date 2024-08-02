using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public static class Time
    {
        public static string Format(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm");
        }
    }
}
