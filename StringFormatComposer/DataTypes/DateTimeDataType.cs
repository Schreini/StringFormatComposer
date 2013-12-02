using System;
using System.Collections.Generic;
using System.Globalization;

namespace StringFormatComposer.DataTypes
{
    public class DateTimeDataType : IDataType
    {
        public IDictionary<string, string> FormatStrings
        {
            get
            {
                return new Dictionary<string, string>()
                           {
                               {"ShortTimePattern", "t"},
                               {"ShortDatePattern", "d"},
                               {"LongTimePattern", "T"},
                               {"LongDatePattern", "D"},
                               {"(combination of D and t)", "f"},
                               {"FullDateTimePattern", "F"},
                               {"(combination of d and t)", "g"},
                               {"(combination of d and T)", "G"},
                               {"MonthDayPattern", "m"},
                               {"YearMonthPattern", "y"},
                               {"RFC1123Pattern", "r"},
                               {"SortableDateTimePattern", "s"},
                               {"UniversalSortableDateTimePattern", "u"},
                               {"Roundtrip", "o"}
                           };
            }
        }

        public bool TryParse(string s, CultureInfo cultureInfo, out object result)
        {
            DateTime dateTime;
            var b = DateTime.TryParse(s, cultureInfo, DateTimeStyles.None, out dateTime);
            result = dateTime;
            return b;
        }

        public IDictionary<string, Func<CultureInfo, string>> SampleValues
        {
            get
            {
                return new Dictionary<string, Func<CultureInfo, string>>
                           {
                               {"Now", ci => DateTime.Now.ToString(ci)},
                               {"Today", ci => DateTime.Today.ToString(ci)},
                               {"First Day", ci => new DateTime(1, 1, 1, 1, 1, 1, 1).ToString(ci)},
                               {"Last Day", ci => new DateTime(9999, 12, 31, 23, 59, 59, 999).ToString(ci)},
                               {"MinValue", ci => DateTime.MinValue.ToString(ci)},
                               {"MaxValue", ci => DateTime.MaxValue.ToString(ci)}
                           };
            }
        }

        public override string ToString()
        {
            return "DateTime";
        }
    }
}