namespace Bußgeldrechner.Modules
{
    partial class ModuleChart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ColProbe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColOrt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDriven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewStat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat)).BeginInit();
            this.SuspendLayout();
            // 
            // ColProbe
            // 
            this.ColProbe.HeaderText = "Probezeit";
            this.ColProbe.Name = "ColProbe";
            this.ColProbe.ReadOnly = true;
            this.ColProbe.Width = 57;
            // 
            // ColOrt
            // 
            this.ColOrt.HeaderText = "Innerorts";
            this.ColOrt.Name = "ColOrt";
            this.ColOrt.ReadOnly = true;
            this.ColOrt.Width = 54;
            // 
            // ColAllowed
            // 
            this.ColAllowed.HeaderText = "Erlaubte Geschwindigkeit";
            this.ColAllowed.Name = "ColAllowed";
            this.ColAllowed.ReadOnly = true;
            this.ColAllowed.Width = 152;
            // 
            // ColDriven
            // 
            this.ColDriven.HeaderText = "Gefahrene Geschwindigkeit";
            this.ColDriven.Name = "ColDriven";
            this.ColDriven.ReadOnly = true;
            this.ColDriven.Width = 163;
            // 
            // dataGridViewStat
            // 
            this.dataGridViewStat.AllowUserToAddRows = false;
            this.dataGridViewStat.AllowUserToDeleteRows = false;
            this.dataGridViewStat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewStat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.dataGridViewStat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDriven,
            this.ColAllowed,
            this.ColOrt,
            this.ColProbe});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStat.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewStat.Name = "dataGridViewStat";
            this.dataGridViewStat.ReadOnly = true;
            this.dataGridViewStat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewStat.Size = new System.Drawing.Size(447, 342);
            this.dataGridViewStat.TabIndex = 0;
            // 
            // ModuleChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.dataGridViewStat);
            this.Name = "ModuleChart";
            this.Size = new System.Drawing.Size(1015, 488);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewCheckBoxColumn ColProbe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColOrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDriven;
        private System.Windows.Forms.DataGridView dataGridViewStat;
    }
}
