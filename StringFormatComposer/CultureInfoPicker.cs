using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace StringFormatComposer
{
    public partial class CultureInfoPicker : UserControl
    {
        public CultureInfoPicker()
        {
            InitializeComponent();
            InitializeCultures();
        }

        public CultureInfo SelectedCultureInfo
        {
            get { return (CultureInfo)CbCultureInfo.SelectedItem; }
            set { CbCultureInfo.SelectedItem = value; }
        }

        private void InitializeCultures()
        {
            var cultures = new List<CultureInfo>
                               {
                                   CultureInfo.CurrentCulture,
                                   CultureInfo.CurrentUICulture,
                                   CultureInfo.InvariantCulture
                               };
            cultures.AddRange(CultureInfo.GetCultures(CultureTypes.AllCultures).OrderBy(p => p.Name).ToArray());

            CbCultureInfo.Items.AddRange(cultures.ToArray());
            CbCultureInfo.SelectedIndex = 0;
        }

        public event EventHandler SelectedIndexChanged
        {
            remove { CbCultureInfo.SelectedIndexChanged -= value; }
            add { CbCultureInfo.SelectedIndexChanged += value; }
        }
    }
}
