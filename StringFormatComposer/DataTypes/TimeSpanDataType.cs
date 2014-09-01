using System;
using System.Collections.Generic;
using System.Globalization;

namespace StringFormatComposer.DataTypes
{
    public class TimeSpanDataType : IDataType
    {
        public IDictionary<string, string> FormatStrings
        {
            get
            {
                return new Dictionary<string, string>()
                           {
                               {"Constant (Invariant) format", "c"},
                               {"General short format", "g"},
                               {"General long format", "G"},
                               {"LongDatePattern", "D"},
                               {"Seconds", "D"},
                           };
            }
        }

        public bool TryParse(string s, CultureInfo cultureInfo, out object result)
        {
            TimeSpan timeSpan;
            var b = TimeSpan.TryParse(s, cultureInfo, out timeSpan);
            result = timeSpan;
            return b;
        }

        public IDictionary<string, Func<CultureInfo, string>> SampleValues
        {
            get
            {
                return new Dictionary<string, Func<CultureInfo, string>>
                           {
                               {"Zero", ci => TimeSpan.Zero.ToString()},
                               {"One Second", ci => new TimeSpan(0,0,1).ToString("",ci)},
                               {"One Minute", ci => new TimeSpan(0,1,0).ToString("",ci)},
                               {"One Hour", ci => new TimeSpan(1, 0, 0).ToString("",ci)},
                               {"One Day", ci => new TimeSpan(1, 0, 0, 0).ToString("",ci)},
                               {"One Year", ci => new TimeSpan(365, 0, 0, 0).ToString("",ci)},
                               {"Two digits", ci => new TimeSpan(87, 65, 43, 21 ).ToString("",ci)},
                               {"MinValue", ci => TimeSpan.MinValue.ToString("",ci)},
                               {"MaxValue", ci => TimeSpan.MaxValue.ToString("",ci)}
                           };
            }
        }

        public override string ToString()
        {
            return "TimeSpan";
        }
    }
}