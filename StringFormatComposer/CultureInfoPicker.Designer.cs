﻿namespace StringFormatComposer
{
    partial class CultureInfoPicker
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbCultureInfo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CbCultureInfo
            // 
            this.CbCultureInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbCultureInfo.FormattingEnabled = true;
            this.CbCultureInfo.Location = new System.Drawing.Point(0, 0);
            this.CbCultureInfo.Name = "CbCultureInfo";
            this.CbCultureInfo.Size = new System.Drawing.Size(121, 21);
            this.CbCultureInfo.TabIndex = 0;
            // 
            // CultureInfoPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbCultureInfo);
            this.Name = "CultureInfoPicker";
            this.Size = new System.Drawing.Size(121, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbCultureInfo;
    }
}
