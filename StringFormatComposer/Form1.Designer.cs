namespace StringFormatComposer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFormatString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbDatatype = new System.Windows.Forms.ComboBox();
            this.PnlSamples = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAlignLeft = new System.Windows.Forms.Button();
            this.BtnAlignRight = new System.Windows.Forms.Button();
            this.PnlFormatStrings = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.CbValueCultureInfo = new StringFormatComposer.CultureInfoPicker();
            this.CbResultCultureInfo = new StringFormatComposer.CultureInfoPicker();
            this.LnkMsdn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Format String:";
            // 
            // TxtFormatString
            // 
            this.TxtFormatString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFormatString.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFormatString.Location = new System.Drawing.Point(91, 33);
            this.TxtFormatString.Name = "TxtFormatString";
            this.TxtFormatString.Size = new System.Drawing.Size(399, 20);
            this.TxtFormatString.TabIndex = 1;
            this.TxtFormatString.Text = "{0}";
            this.TxtFormatString.TextChanged += new System.EventHandler(this.TxtFormatString_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wert:";
            // 
            // TxtValue
            // 
            this.TxtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtValue.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValue.Location = new System.Drawing.Point(91, 59);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(399, 20);
            this.TxtValue.TabIndex = 3;
            this.TxtValue.TextChanged += new System.EventHandler(this.TxtValue_TextChanged);
            // 
            // TxtResult
            // 
            this.TxtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResult.Location = new System.Drawing.Point(91, 86);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.Size = new System.Drawing.Size(399, 20);
            this.TxtResult.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ergebnis:";
            // 
            // CbDatatype
            // 
            this.CbDatatype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDatatype.FormattingEnabled = true;
            this.CbDatatype.Location = new System.Drawing.Point(91, 6);
            this.CbDatatype.Name = "CbDatatype";
            this.CbDatatype.Size = new System.Drawing.Size(121, 21);
            this.CbDatatype.TabIndex = 6;
            this.CbDatatype.SelectedIndexChanged += new System.EventHandler(this.CbDatatype_SelectedIndexChanged);
            // 
            // PnlSamples
            // 
            this.PnlSamples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlSamples.AutoScroll = true;
            this.PnlSamples.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlSamples.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PnlSamples.ColumnCount = 1;
            this.PnlSamples.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlSamples.Location = new System.Drawing.Point(321, 145);
            this.PnlSamples.Name = "PnlSamples";
            this.PnlSamples.RowCount = 1;
            this.PnlSamples.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlSamples.Size = new System.Drawing.Size(296, 357);
            this.PnlSamples.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sample Values:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Datatype:";
            // 
            // BtnAlignLeft
            // 
            this.BtnAlignLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAlignLeft.Location = new System.Drawing.Point(497, 31);
            this.BtnAlignLeft.Name = "BtnAlignLeft";
            this.BtnAlignLeft.Size = new System.Drawing.Size(55, 23);
            this.BtnAlignLeft.TabIndex = 14;
            this.BtnAlignLeft.Text = "<-";
            this.BtnAlignLeft.UseVisualStyleBackColor = true;
            this.BtnAlignLeft.Click += new System.EventHandler(this.BtnAlignLeft_Click);
            // 
            // BtnAlignRight
            // 
            this.BtnAlignRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAlignRight.Location = new System.Drawing.Point(563, 31);
            this.BtnAlignRight.Name = "BtnAlignRight";
            this.BtnAlignRight.Size = new System.Drawing.Size(55, 23);
            this.BtnAlignRight.TabIndex = 15;
            this.BtnAlignRight.Text = "->";
            this.BtnAlignRight.UseVisualStyleBackColor = true;
            this.BtnAlignRight.Click += new System.EventHandler(this.BtnAlignRight_Click);
            // 
            // PnlFormatStrings
            // 
            this.PnlFormatStrings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlFormatStrings.AutoScroll = true;
            this.PnlFormatStrings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlFormatStrings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PnlFormatStrings.ColumnCount = 1;
            this.PnlFormatStrings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlFormatStrings.Location = new System.Drawing.Point(16, 145);
            this.PnlFormatStrings.Name = "PnlFormatStrings";
            this.PnlFormatStrings.RowCount = 1;
            this.PnlFormatStrings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlFormatStrings.Size = new System.Drawing.Size(299, 357);
            this.PnlFormatStrings.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Format Strings:";
            // 
            // CbValueCultureInfo
            // 
            this.CbValueCultureInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbValueCultureInfo.Location = new System.Drawing.Point(497, 58);
            this.CbValueCultureInfo.Name = "CbValueCultureInfo";
            this.CbValueCultureInfo.SelectedCultureInfo = new System.Globalization.CultureInfo("de-DE");
            this.CbValueCultureInfo.Size = new System.Drawing.Size(121, 21);
            this.CbValueCultureInfo.TabIndex = 13;
            this.CbValueCultureInfo.SelectedIndexChanged += new System.EventHandler(this.CbValueCultureInfo_SelectedIndexChanged);
            // 
            // CbResultCultureInfo
            // 
            this.CbResultCultureInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbResultCultureInfo.Location = new System.Drawing.Point(497, 86);
            this.CbResultCultureInfo.Name = "CbResultCultureInfo";
            this.CbResultCultureInfo.SelectedCultureInfo = new System.Globalization.CultureInfo("de-DE");
            this.CbResultCultureInfo.Size = new System.Drawing.Size(121, 21);
            this.CbResultCultureInfo.TabIndex = 12;
            this.CbResultCultureInfo.SelectedIndexChanged += new System.EventHandler(this.CbResultCultureInfo_SelectedIndexChanged);
            // 
            // LnkMsdn
            // 
            this.LnkMsdn.AutoSize = true;
            this.LnkMsdn.Location = new System.Drawing.Point(218, 9);
            this.LnkMsdn.Name = "LnkMsdn";
            this.LnkMsdn.Size = new System.Drawing.Size(62, 13);
            this.LnkMsdn.TabIndex = 18;
            this.LnkMsdn.TabStop = true;
            this.LnkMsdn.Text = "Link MSDN";
            this.LnkMsdn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkMsdn_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 514);
            this.Controls.Add(this.LnkMsdn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PnlFormatStrings);
            this.Controls.Add(this.BtnAlignRight);
            this.Controls.Add(this.BtnAlignLeft);
            this.Controls.Add(this.CbValueCultureInfo);
            this.Controls.Add(this.CbResultCultureInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PnlSamples);
            this.Controls.Add(this.CbDatatype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFormatString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFormatString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbDatatype;
        private System.Windows.Forms.TableLayoutPanel PnlSamples;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CultureInfoPicker CbResultCultureInfo;
        private CultureInfoPicker CbValueCultureInfo;
        private System.Windows.Forms.Button BtnAlignLeft;
        private System.Windows.Forms.Button BtnAlignRight;
        private System.Windows.Forms.TableLayoutPanel PnlFormatStrings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel LnkMsdn;
    }
}

