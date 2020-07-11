namespace Bußgeldrechner
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelMenuChart = new System.Windows.Forms.Panel();
            this.pictureBoxChart = new System.Windows.Forms.PictureBox();
            this.panelMenuInfo = new System.Windows.Forms.Panel();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.panelMenuSettings = new System.Windows.Forms.Panel();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.panelMenuCalc = new System.Windows.Forms.Panel();
            this.pictureBoxCalc = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNav = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelInfo = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.buttonSrc = new System.Windows.Forms.Button();
            this.panelSide.SuspendLayout();
            this.panelMenuChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).BeginInit();
            this.panelMenuInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.panelMenuSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.panelMenuCalc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelSide.Controls.Add(this.panelMenuChart);
            this.panelSide.Controls.Add(this.panelMenuInfo);
            this.panelSide.Controls.Add(this.panelMenuSettings);
            this.panelSide.Controls.Add(this.panelMenuCalc);
            this.panelSide.Controls.Add(this.pictureBox1);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(163, 605);
            this.panelSide.TabIndex = 0;
            // 
            // panelMenuChart
            // 
            this.panelMenuChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelMenuChart.Controls.Add(this.pictureBoxChart);
            this.panelMenuChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuChart.Location = new System.Drawing.Point(0, 316);
            this.panelMenuChart.Name = "panelMenuChart";
            this.panelMenuChart.Size = new System.Drawing.Size(163, 68);
            this.panelMenuChart.TabIndex = 4;
            // 
            // pictureBoxChart
            // 
            this.pictureBoxChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxChart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChart.Image")));
            this.pictureBoxChart.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxChart.Name = "pictureBoxChart";
            this.pictureBoxChart.Size = new System.Drawing.Size(163, 68);
            this.pictureBoxChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChart.TabIndex = 2;
            this.pictureBoxChart.TabStop = false;
            this.pictureBoxChart.Click += new System.EventHandler(this.pictureBoxChart_Click);
            this.pictureBoxChart.MouseEnter += new System.EventHandler(this.pictureBoxChart_MouseEnter);
            this.pictureBoxChart.MouseLeave += new System.EventHandler(this.pictureBoxChart_MouseLeave);
            // 
            // panelMenuInfo
            // 
            this.panelMenuInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelMenuInfo.Controls.Add(this.pictureBoxInfo);
            this.panelMenuInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuInfo.Location = new System.Drawing.Point(0, 248);
            this.panelMenuInfo.Name = "panelMenuInfo";
            this.panelMenuInfo.Size = new System.Drawing.Size(163, 68);
            this.panelMenuInfo.TabIndex = 3;
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInfo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo.Image")));
            this.pictureBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(163, 68);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfo.TabIndex = 1;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.pictureBoxInfo_Click);
            this.pictureBoxInfo.MouseEnter += new System.EventHandler(this.pictureBoxInfo_MouseEnter);
            this.pictureBoxInfo.MouseLeave += new System.EventHandler(this.pictureBoxInfo_MouseLeave);
            // 
            // panelMenuSettings
            // 
            this.panelMenuSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelMenuSettings.Controls.Add(this.pictureBoxSettings);
            this.panelMenuSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenuSettings.Location = new System.Drawing.Point(0, 537);
            this.panelMenuSettings.Name = "panelMenuSettings";
            this.panelMenuSettings.Size = new System.Drawing.Size(163, 68);
            this.panelMenuSettings.TabIndex = 2;
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSettings.Image")));
            this.pictureBoxSettings.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(163, 68);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSettings.TabIndex = 1;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            this.pictureBoxSettings.MouseEnter += new System.EventHandler(this.pictureBoxSettings_MouseEnter);
            this.pictureBoxSettings.MouseLeave += new System.EventHandler(this.pictureBoxSettings_MouseLeave);
            // 
            // panelMenuCalc
            // 
            this.panelMenuCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelMenuCalc.Controls.Add(this.pictureBoxCalc);
            this.panelMenuCalc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuCalc.Location = new System.Drawing.Point(0, 180);
            this.panelMenuCalc.Name = "panelMenuCalc";
            this.panelMenuCalc.Size = new System.Drawing.Size(163, 68);
            this.panelMenuCalc.TabIndex = 1;
            // 
            // pictureBoxCalc
            // 
            this.pictureBoxCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCalc.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCalc.Image")));
            this.pictureBoxCalc.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCalc.Name = "pictureBoxCalc";
            this.pictureBoxCalc.Size = new System.Drawing.Size(163, 68);
            this.pictureBoxCalc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCalc.TabIndex = 0;
            this.pictureBoxCalc.TabStop = false;
            this.pictureBoxCalc.Click += new System.EventHandler(this.pictureBoxCalc_Click);
            this.pictureBoxCalc.MouseEnter += new System.EventHandler(this.pictureBoxCalc_MouseEnter);
            this.pictureBoxCalc.MouseLeave += new System.EventHandler(this.pictureBoxCalc_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 180);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.panelNav.Controls.Add(this.buttonSrc);
            this.panelNav.Controls.Add(this.labelTitle);
            this.panelNav.Controls.Add(this.btnMinimize);
            this.panelNav.Controls.Add(this.btnClose);
            this.panelNav.Controls.Add(this.bunifuSeparator1);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(163, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1031, 78);
            this.panelNav.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(6, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(285, 44);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Bußgeldrechner";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(923, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 35);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(974, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(6, 43);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1013, 35);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelNav;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelInfo
            // 
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(163, 78);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1031, 527);
            this.panelInfo.TabIndex = 2;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.labelTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.bunifuSeparator1;
            this.bunifuDragControl3.Vertical = true;
            // 
            // buttonSrc
            // 
            this.buttonSrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonSrc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSrc.FlatAppearance.BorderSize = 0;
            this.buttonSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSrc.Font = new System.Drawing.Font("Montserrat Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSrc.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSrc.Location = new System.Drawing.Point(703, 12);
            this.buttonSrc.Name = "buttonSrc";
            this.buttonSrc.Size = new System.Drawing.Size(214, 35);
            this.buttonSrc.TabIndex = 10;
            this.buttonSrc.TabStop = false;
            this.buttonSrc.Text = "Source Code";
            this.buttonSrc.UseVisualStyleBackColor = false;
            this.buttonSrc.Click += new System.EventHandler(this.buttonSrc_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1194, 605);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Bußgeldrechner";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelSide.ResumeLayout(false);
            this.panelMenuChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).EndInit();
            this.panelMenuInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.panelMenuSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.panelMenuCalc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelInfo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Panel panelMenuCalc;
        private System.Windows.Forms.PictureBox pictureBoxCalc;
        private System.Windows.Forms.Panel panelMenuSettings;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.Panel panelMenuInfo;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.Panel panelMenuChart;
        private System.Windows.Forms.PictureBox pictureBoxChart;
        private System.Windows.Forms.Button buttonSrc;
    }
}

