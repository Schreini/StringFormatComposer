using System;
using System.Collections.Generic;
using System.Globalization;

namespace StringFormatComposer.DataTypes
{
    public interface IDataType
    {
        IDictionary<string, Func<CultureInfo, string>> SampleValues { get; }
        IDictionary<string, string> FormatStrings { get; }
        bool TryParse(string text, CultureInfo cultureInfo, out object value);

    }
}