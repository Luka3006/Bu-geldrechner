namespace Bußgeldrechner.Modules
{
    partial class ModuleSettings
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
            this.labelAutoDel = new System.Windows.Forms.Label();
            this.checkAutoDel = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SuspendLayout();
            // 
            // labelAutoDel
            // 
            this.labelAutoDel.AutoSize = true;
            this.labelAutoDel.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoDel.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAutoDel.Location = new System.Drawing.Point(38, 14);
            this.labelAutoDel.Name = "labelAutoDel";
            this.labelAutoDel.Size = new System.Drawing.Size(594, 29);
            this.labelAutoDel.TabIndex = 13;
            this.labelAutoDel.Text = "Formularinhalte nach Berechnung automatisch löschen";
            // 
            // checkAutoDel
            // 
            this.checkAutoDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.checkAutoDel.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkAutoDel.Checked = true;
            this.checkAutoDel.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.checkAutoDel.ForeColor = System.Drawing.Color.White;
            this.checkAutoDel.Location = new System.Drawing.Point(18, 20);
            this.checkAutoDel.Name = "checkAutoDel";
            this.checkAutoDel.Size = new System.Drawing.Size(20, 20);
            this.checkAutoDel.TabIndex = 12;
            this.checkAutoDel.OnChange += new System.EventHandler(this.checkAutoDel_OnChange);
            // 
            // ModuleSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.labelAutoDel);
            this.Controls.Add(this.checkAutoDel);
            this.Name = "ModuleSettings";
            this.Size = new System.Drawing.Size(1015, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAutoDel;
        private Bunifu.Framework.UI.BunifuCheckbox checkAutoDel;
    }
}
