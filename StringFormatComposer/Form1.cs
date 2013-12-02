using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using StringFormatComposer.DataTypes;

namespace StringFormatComposer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CbDatatype.Items.Add(new DoubleDataType());
            CbDatatype.Items.Add(new DateTimeDataType());
            CbDatatype.Items.Add(new IntDataType());
            CbDatatype.SelectedIndex = 0;
        }

        private void TxtFormatString_TextChanged(object sender, EventArgs e)
        {
            FormatValue();
        }

        private void TxtValue_TextChanged(object sender, EventArgs e)
        {
            FormatValue();
        }

        private void FormatValue()
        {
            var errorColor = Color.FromArgb(255, 255, 199, 206);

            object value;
            var dt = (IDataType)CbDatatype.SelectedItem;
            var b = dt.TryParse(TxtValue.Text, CbValueCultureInfo.SelectedCultureInfo, out value);

            if (!b)
            {
                TxtValue.BackColor = errorColor;
                return;
            }

            try
            {
                TxtResult.Text = string.Format(CbResultCultureInfo.SelectedCultureInfo, TxtFormatString.Text, value);
            }
            catch(FormatException)
            {
                TxtFormatString.BackColor = errorColor;
                return;
            }
            TxtFormatString.BackColor = Color.White;
            TxtValue.BackColor = Color.White;
        }

        private void CbDatatype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StopLayout();
                ShowSampleValues();
                ShowFormatStrings();
                FormatValue();
            }
            finally
            {
                StartLayout();
            }
        }

        private void StartLayout()
        {
            ResumeLayout();
            PnlSamples.ResumeLayout();
            PnlFormatStrings.ResumeLayout();
        }

        private void StopLayout()
        {
            SuspendLayout();
            PnlSamples.SuspendLayout();
            PnlFormatStrings.SuspendLayout();
        }

        private void ShowFormatStrings()
        {
            var dt = (IDataType)CbDatatype.SelectedItem;
            PnlFormatStrings.Controls.Clear();
            foreach (var fstring in dt.FormatStrings)
            {
                var b = new Button();
                var fstring1 = fstring;
                b.Click += (send, ea) =>
                {
                    TxtFormatString.Text = "{0:" + fstring1.Value + "}";
                };
                b.Text = fstring.Key;
                b.Width = 300;
                PnlFormatStrings.Controls.Add(b);
            }
        }

        private void ShowSampleValues()
        {
            var dt = (IDataType) CbDatatype.SelectedItem;
            PnlSamples.Controls.Clear();
            foreach (var sample in dt.SampleValues)
            {
                var b = new Button();
                var sample1 = sample;
                b.Click += (send, ea) =>
                               {
                                   TxtValue.Text = sample1.Value(CbValueCultureInfo.SelectedCultureInfo);
                               };
                b.Text = sample.Key;
                PnlSamples.Controls.Add(b);
            }
        }

        private void CbResultCultureInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatValue();
        }

        private void CbValueCultureInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatValue();
        }

        private void BtnAlignLeft_Click(object sender, EventArgs e)
        {
            ChangeAlignment(-1);
        }

        private void BtnAlignRight_Click(object sender, EventArgs e)
        {
            ChangeAlignment(+1);
        }

        void ChangeAlignment(int value)
        {
            const string pattern = @"^({0)(?<alignment>,-?\d+)?(.*)";
            var r = new Regex(pattern);
            var m = r.Match(TxtFormatString.Text);
            var alignment = m.Groups["alignment"];
            var depth = 0;
            if (alignment.Success)
            {
                depth = int.Parse(alignment.Value.Substring(1, alignment.Value.Length-1));
            }
            depth += value;
            TxtFormatString.Text = r.Replace(TxtFormatString.Text, "${1}" + (depth == 0 ? "" :  ","+depth) + "${2}");
        }

        private void LnkMsdn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://msdn.microsoft.com/en-us/library/az4se3k1.aspx");
        }
    }
}
