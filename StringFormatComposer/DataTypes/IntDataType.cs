using System;
using System.Collections.Generic;
using System.Globalization;

namespace StringFormatComposer.DataTypes
{
    public class IntDataType : IDataType
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
            int d;
            var b = int.TryParse(s, NumberStyles.Any, cultureInfo, out d);
            result = d;
            return b;
        }

        public IDictionary<string, Func<CultureInfo, string>> SampleValues
        {
            get
            {
                return new Dictionary<string, Func<CultureInfo, string>>
                           {
                               {"0", ci => 0.ToString(ci)},
                               {"1", ci => 1.ToString(ci)},
                               {"1234", ci => 1234.ToString(ci)},
                               {"12345678", ci => 12345678.ToString(ci)},
                               {"MinValue", ci => (int.MinValue).ToString(ci)},
                               {"MaxValue", ci => (int.MaxValue).ToString(ci)}
                           };
            }
        }

        public override string ToString()
        {
            return "Int";
        }
    }
}