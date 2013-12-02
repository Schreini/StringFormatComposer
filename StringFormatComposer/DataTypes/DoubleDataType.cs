using System;
using System.Collections.Generic;
using System.Globalization;

namespace StringFormatComposer.DataTypes
{
    public class DoubleDataType : IDataType
    {
        public IDictionary<string, string> FormatStrings
        {
            get
            {
                return new Dictionary<string, string>
                           {
                               {"Currency", "C"},
                               {"Decimal", "D"},
                               {"Exponential", "E"},
                               {"Fixed-point", "F"},
                               {"General", "G"},
                               {"Number", "N"},
                               {"Percent", "P"},
                               {"Round-trip", "R"},
                               {"Hexadecimal", "X"}
                           };
            }
        }

        public bool TryParse(string s, CultureInfo cultureInfo, out object result)
        {
            double d;
            var b = double.TryParse(s, NumberStyles.Any, cultureInfo, out d);
            result = d;
            return b;
        }

        public IDictionary<string, Func<CultureInfo, string>> SampleValues
        {
            get
            {
                return new Dictionary<string, Func<CultureInfo, string>>
                           {
                               {"0", ci => 0d.ToString("R", ci)},
                               {"1", ci => 1d.ToString("R", ci)},
                               {"1234.56", ci => 1234.56d.ToString("R", ci)},
                               {"1234.5678", ci => 1234.5678d.ToString("R", ci)},
                               {"0.12345678", ci => 0.12345678d.ToString("R", ci)},
                               {"0.00000001", ci => 0.00000001d.ToString("R", ci)},
                               {"Sqrt(2)", ci => Math.Sqrt(2).ToString("R", ci)},
                               {"Pi", ci => Math.PI.ToString("R", ci)},
                               {"MinValue", ci => (double.MinValue).ToString("R", ci)},
                               {"MaxValue", ci => (double.MaxValue).ToString("R", ci)}
                           };
            }
        }

        public override string ToString()
        {
            return "Double";
        }
    }
}