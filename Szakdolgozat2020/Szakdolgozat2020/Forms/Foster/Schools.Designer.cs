namespace Szakdolgozat2020.Forms.Foster
{
    partial class Schools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroButtonAddSchool = new MetroFramework.Controls.MetroButton();
            this.metroButtonLogOut = new MetroFramework.Controls.MetroButton();
            this.metroGridChildSchool = new MetroFramework.Controls.MetroGrid();
            this.metroComboBoxSchool = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridChildSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonAddSchool
            // 
            this.metroButtonAddSchool.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.metroButtonAddSchool.Location = new System.Drawing.Point(54, 98);
            this.metroButtonAddSchool.Margin = new System.Windows.Forms.Padding(4);
            this.metroButtonAddSchool.Name = "metroButtonAddSchool";
            this.metroButtonAddSchool.Size = new System.Drawing.Size(209, 28);
            this.metroButtonAddSchool.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonAddSchool.TabIndex = 6;
            this.metroButtonAddSchool.Text = "Intézmény hozzáadása ";
            this.metroButtonAddSchool.UseCustomBackColor = true;
            this.metroButtonAddSchool.UseSelectable = true;
            this.metroButtonAddSchool.UseStyleColors = true;
            this.metroButtonAddSchool.Click += new System.EventHandler(this.metroButtonAddSchool_Click);
            // 
            // metroButtonLogOut
            // 
            this.metroButtonLogOut.Location = new System.Drawing.Point(930, 570);
            this.metroButtonLogOut.Name = "metroButtonLogOut";
            this.metroButtonLogOut.Size = new System.Drawing.Size(156, 28);
            this.metroButtonLogOut.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonLogOut.TabIndex = 8;
            this.metroButtonLogOut.Text = "Kijelentkezés";
            this.metroButtonLogOut.UseCustomBackColor = true;
            this.metroButtonLogOut.UseSelectable = true;
            this.metroButtonLogOut.UseStyleColors = true;
            this.metroButtonLogOut.Click += new System.EventHandler(this.metroButtonLogOut_Click);
            // 
            // metroGridChildSchool
            // 
            this.metroGridChildSchool.AllowUserToResizeRows = false;
            this.metroGridChildSchool.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridChildSchool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridChildSchool.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridChildSchool.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridChildSchool.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridChildSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridChildSchool.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridChildSchool.EnableHeadersVisualStyles = false;
            this.metroGridChildSchool.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridChildSchool.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridChildSchool.Location = new System.Drawing.Point(54, 279);
            this.metroGridChildSchool.Name = "metroGridChildSchool";
            this.metroGridChildSchool.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridChildSchool.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridChildSchool.RowHeadersWidth = 51;
            this.metroGridChildSchool.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridChildSchool.RowTemplate.Height = 24;
            this.metroGridChildSchool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridChildSchool.Size = new System.Drawing.Size(1032, 269);
            this.metroGridChildSchool.TabIndex = 9;
            // 
            // metroComboBoxSchool
            // 
            this.metroComboBoxSchool.FormattingEnabled = true;
            this.metroComboBoxSchool.ItemHeight = 24;
            this.metroComboBoxSchool.Location = new System.Drawing.Point(54, 232);
            this.metroComboBoxSchool.Name = "metroComboBoxSchool";
            this.metroComboBoxSchool.Size = new System.Drawing.Size(553, 30);
            this.metroComboBoxSchool.TabIndex = 10;
            this.metroComboBoxSchool.UseSelectable = true;
            this.metroComboBoxSchool.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxSchool_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 176);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 20);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // Schools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 621);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBoxSchool);
            this.Controls.Add(this.metroGridChildSchool);
            this.Controls.Add(this.metroButtonLogOut);
            this.Controls.Add(this.metroButtonAddSchool);
            this.Name = "Schools";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Közoktatás";
            this.Load += new System.EventHandler(this.Schools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridChildSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonAddSchool;
        private MetroFramework.Controls.MetroButton metroButtonLogOut;
        private MetroFramework.Controls.MetroGrid metroGridChildSchool;
        private MetroFramework.Controls.MetroComboBox metroComboBoxSchool;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}