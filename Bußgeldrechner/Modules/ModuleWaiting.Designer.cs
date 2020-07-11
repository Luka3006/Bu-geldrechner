namespace Bußgeldrechner.Modules
{
    partial class ModuleWaiting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleWaiting));
            this.circle = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.labelWait = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // circle
            // 
            this.circle.animated = true;
            this.circle.animationIterval = 1;
            this.circle.animationSpeed = 5;
            this.circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle.BackgroundImage")));
            this.circle.Font = new System.Drawing.Font("Yu Gothic UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.circle.LabelVisible = true;
            this.circle.LineProgressThickness = 10;
            this.circle.LineThickness = 7;
            this.circle.Location = new System.Drawing.Point(379, 76);
            this.circle.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circle.MaxValue = 100;
            this.circle.Name = "circle";
            this.circle.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.circle.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.circle.Size = new System.Drawing.Size(258, 258);
            this.circle.TabIndex = 0;
            this.circle.Value = 0;
            // 
            // labelWait
            // 
            this.labelWait.AutoSize = true;
            this.labelWait.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.labelWait.Location = new System.Drawing.Point(314, 357);
            this.labelWait.Name = "labelWait";
            this.labelWait.Size = new System.Drawing.Size(388, 37);
            this.labelWait.TabIndex = 1;
            this.labelWait.Text = "Bußgeld wird berechnet...";
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ModuleWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.labelWait);
            this.Controls.Add(this.circle);
            this.Name = "ModuleWaiting";
            this.Size = new System.Drawing.Size(1015, 488);
            this.Load += new System.EventHandler(this.ModuleWaiting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar circle;
        private System.Windows.Forms.Label labelWait;
        private System.Windows.Forms.Timer timer;
    }
}
