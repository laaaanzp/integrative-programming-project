using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsCollab.Globals
{
    public static class FuncTools
    {
        public static double CalculateBMI(int weightKg, double heightFt)
        {
            double heightAsMeters = heightFt / (double)3.281m;
            double bmi = weightKg / (heightAsMeters * heightAsMeters);

            return bmi;
        }

        public static string ToTitleCase(string s)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            return textInfo.ToTitleCase(s);
        }
    }
}
