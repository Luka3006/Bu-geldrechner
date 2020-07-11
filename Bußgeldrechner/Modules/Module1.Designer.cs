using System.Windows.Forms;

namespace Bußgeldrechner.Modules
{
    partial class Module1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Module1));
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkProbe = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkOrt = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAllowed = new System.Windows.Forms.Panel();
            this.textBoxAllowed = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelDriven = new System.Windows.Forms.Panel();
            this.textBoxDriven = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelAllowed.SuspendLayout();
            this.panelDriven.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonCalc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonCalc.FlatAppearance.BorderSize = 0;
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalc.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalc.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCalc.Location = new System.Drawing.Point(391, 342);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(233, 38);
            this.buttonCalc.TabIndex = 9;
            this.buttonCalc.TabStop = false;
            this.buttonCalc.Text = "Berechnen";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(580, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Probezeit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkProbe
            // 
            this.checkProbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkProbe.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkProbe.Checked = false;
            this.checkProbe.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.checkProbe.ForeColor = System.Drawing.Color.White;
            this.checkProbe.Location = new System.Drawing.Point(560, 291);
            this.checkProbe.Name = "checkProbe";
            this.checkProbe.Size = new System.Drawing.Size(20, 20);
            this.checkProbe.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(342, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Innerorts";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkOrt
            // 
            this.checkOrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkOrt.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkOrt.Checked = false;
            this.checkOrt.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.checkOrt.ForeColor = System.Drawing.Color.White;
            this.checkOrt.Location = new System.Drawing.Point(322, 291);
            this.checkOrt.Name = "checkOrt";
            this.checkOrt.Size = new System.Drawing.Size(20, 20);
            this.checkOrt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(255, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Erlaubte Geschwindigkeit in km/h";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(239, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gefahrene Geschwindigkeit in km/h";
            // 
            // panelAllowed
            // 
            this.panelAllowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelAllowed.Controls.Add(this.textBoxAllowed);
            this.panelAllowed.Location = new System.Drawing.Point(322, 222);
            this.panelAllowed.Name = "panelAllowed";
            this.panelAllowed.Size = new System.Drawing.Size(370, 45);
            this.panelAllowed.TabIndex = 16;
            // 
            // textBoxAllowed
            // 
            this.textBoxAllowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.textBoxAllowed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxAllowed.BackgroundImage")));
            this.textBoxAllowed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxAllowed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAllowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.textBoxAllowed.Icon = ((System.Drawing.Image)(resources.GetObject("textBoxAllowed.Icon")));
            this.textBoxAllowed.Location = new System.Drawing.Point(0, 0);
            this.textBoxAllowed.Name = "textBoxAllowed";
            this.textBoxAllowed.Size = new System.Drawing.Size(370, 45);
            this.textBoxAllowed.TabIndex = 1;
            this.textBoxAllowed.text = "";
            // 
            // panelDriven
            // 
            this.panelDriven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelDriven.Controls.Add(this.textBoxDriven);
            this.panelDriven.Location = new System.Drawing.Point(322, 106);
            this.panelDriven.Name = "panelDriven";
            this.panelDriven.Size = new System.Drawing.Size(370, 45);
            this.panelDriven.TabIndex = 17;
            // 
            // textBoxDriven
            // 
            this.textBoxDriven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.textBoxDriven.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxDriven.BackgroundImage")));
            this.textBoxDriven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxDriven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDriven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.textBoxDriven.Icon = ((System.Drawing.Image)(resources.GetObject("textBoxDriven.Icon")));
            this.textBoxDriven.Location = new System.Drawing.Point(0, 0);
            this.textBoxDriven.Name = "textBoxDriven";
            this.textBoxDriven.Size = new System.Drawing.Size(370, 45);
            this.textBoxDriven.TabIndex = 0;
            this.textBoxDriven.text = "";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.panelDriven;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.panelAllowed;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.buttonCalc;
            // 
            // Module1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panelDriven);
            this.Controls.Add(this.panelAllowed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkProbe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkOrt);
            this.Controls.Add(this.buttonCalc);
            this.Name = "Module1";
            this.Size = new System.Drawing.Size(1015, 488);
            this.Load += new System.EventHandler(this.Module1_Load);
            this.panelAllowed.ResumeLayout(false);
            this.panelDriven.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox checkProbe;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox checkOrt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAllowed;
        private System.Windows.Forms.Panel panelDriven;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuTextbox textBoxAllowed;
        private Bunifu.Framework.UI.BunifuTextbox textBoxDriven;
    }
}
