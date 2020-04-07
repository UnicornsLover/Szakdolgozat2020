namespace Szakdolgozat2020.Forms.Foster
{
    partial class AddSchool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSchool));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabelSID = new MetroFramework.Controls.MetroLabel();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLocation = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPhone = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxLocation = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSID = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonCleanCells = new MetroFramework.Controls.MetroButton();
            this.metroButtonSearch = new MetroFramework.Controls.MetroButton();
            this.metroButtonModify = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonAddSchool = new MetroFramework.Controls.MetroButton();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLocation = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroGridSchoolBasic = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridSchoolBasic)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelSID
            // 
            this.metroLabelSID.AutoSize = true;
            this.metroLabelSID.Location = new System.Drawing.Point(49, 97);
            this.metroLabelSID.Name = "metroLabelSID";
            this.metroLabelSID.Size = new System.Drawing.Size(119, 20);
            this.metroLabelSID.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabelSID.TabIndex = 0;
            this.metroLabelSID.Text = "Iskola azonosítója:";
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.Location = new System.Drawing.Point(339, 97);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(46, 20);
            this.metroLabelName.TabIndex = 1;
            this.metroLabelName.Text = "Neve:";
            // 
            // metroLabelLocation
            // 
            this.metroLabelLocation.AutoSize = true;
            this.metroLabelLocation.Location = new System.Drawing.Point(888, 97);
            this.metroLabelLocation.Name = "metroLabelLocation";
            this.metroLabelLocation.Size = new System.Drawing.Size(109, 20);
            this.metroLabelLocation.TabIndex = 2;
            this.metroLabelLocation.Text = "Elhelyezkedése:";
            // 
            // metroLabelPhone
            // 
            this.metroLabelPhone.AutoSize = true;
            this.metroLabelPhone.Location = new System.Drawing.Point(339, 177);
            this.metroLabelPhone.Name = "metroLabelPhone";
            this.metroLabelPhone.Size = new System.Drawing.Size(155, 20);
            this.metroLabelPhone.TabIndex = 3;
            this.metroLabelPhone.Text = "Vezetékes telefonszám:";
            // 
            // metroTextBoxName
            // 
            // 
            // 
            // 
            this.metroTextBoxName.CustomButton.Image = null;
            this.metroTextBoxName.CustomButton.Location = new System.Drawing.Point(481, 2);
            this.metroTextBoxName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxName.CustomButton.Name = "";
            this.metroTextBoxName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxName.CustomButton.TabIndex = 1;
            this.metroTextBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxName.CustomButton.UseSelectable = true;
            this.metroTextBoxName.CustomButton.Visible = false;
            this.metroTextBoxName.Lines = new string[0];
            this.metroTextBoxName.Location = new System.Drawing.Point(339, 132);
            this.metroTextBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxName.MaxLength = 32767;
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.PasswordChar = '\0';
            this.metroTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxName.SelectedText = "";
            this.metroTextBoxName.SelectionLength = 0;
            this.metroTextBoxName.SelectionStart = 0;
            this.metroTextBoxName.ShortcutsEnabled = true;
            this.metroTextBoxName.Size = new System.Drawing.Size(507, 28);
            this.metroTextBoxName.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTextBoxName.TabIndex = 29;
            this.metroTextBoxName.UseSelectable = true;
            this.metroTextBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxLocation
            // 
            // 
            // 
            // 
            this.metroTextBoxLocation.CustomButton.Image = null;
            this.metroTextBoxLocation.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.metroTextBoxLocation.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxLocation.CustomButton.Name = "";
            this.metroTextBoxLocation.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLocation.CustomButton.TabIndex = 1;
            this.metroTextBoxLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLocation.CustomButton.UseSelectable = true;
            this.metroTextBoxLocation.CustomButton.Visible = false;
            this.metroTextBoxLocation.Lines = new string[0];
            this.metroTextBoxLocation.Location = new System.Drawing.Point(888, 132);
            this.metroTextBoxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxLocation.MaxLength = 32767;
            this.metroTextBoxLocation.Name = "metroTextBoxLocation";
            this.metroTextBoxLocation.PasswordChar = '\0';
            this.metroTextBoxLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLocation.SelectedText = "";
            this.metroTextBoxLocation.SelectionLength = 0;
            this.metroTextBoxLocation.SelectionStart = 0;
            this.metroTextBoxLocation.ShortcutsEnabled = true;
            this.metroTextBoxLocation.Size = new System.Drawing.Size(199, 28);
            this.metroTextBoxLocation.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTextBoxLocation.TabIndex = 30;
            this.metroTextBoxLocation.UseSelectable = true;
            this.metroTextBoxLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxPhone
            // 
            // 
            // 
            // 
            this.metroTextBoxPhone.CustomButton.Image = null;
            this.metroTextBoxPhone.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.metroTextBoxPhone.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxPhone.CustomButton.Name = "";
            this.metroTextBoxPhone.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPhone.CustomButton.TabIndex = 1;
            this.metroTextBoxPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPhone.CustomButton.UseSelectable = true;
            this.metroTextBoxPhone.CustomButton.Visible = false;
            this.metroTextBoxPhone.Lines = new string[0];
            this.metroTextBoxPhone.Location = new System.Drawing.Point(339, 213);
            this.metroTextBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxPhone.MaxLength = 32767;
            this.metroTextBoxPhone.Name = "metroTextBoxPhone";
            this.metroTextBoxPhone.PasswordChar = '\0';
            this.metroTextBoxPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPhone.SelectedText = "";
            this.metroTextBoxPhone.SelectionLength = 0;
            this.metroTextBoxPhone.SelectionStart = 0;
            this.metroTextBoxPhone.ShortcutsEnabled = true;
            this.metroTextBoxPhone.Size = new System.Drawing.Size(268, 28);
            this.metroTextBoxPhone.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTextBoxPhone.TabIndex = 31;
            this.metroTextBoxPhone.UseSelectable = true;
            this.metroTextBoxPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxSID
            // 
            this.metroTextBoxSID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            // 
            // 
            // 
            this.metroTextBoxSID.CustomButton.Image = null;
            this.metroTextBoxSID.CustomButton.Location = new System.Drawing.Point(186, 2);
            this.metroTextBoxSID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxSID.CustomButton.Name = "";
            this.metroTextBoxSID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxSID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSID.CustomButton.TabIndex = 1;
            this.metroTextBoxSID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSID.CustomButton.UseSelectable = true;
            this.metroTextBoxSID.CustomButton.Visible = false;
            this.metroTextBoxSID.ForeColor = System.Drawing.Color.White;
            this.metroTextBoxSID.Lines = new string[0];
            this.metroTextBoxSID.Location = new System.Drawing.Point(49, 132);
            this.metroTextBoxSID.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxSID.MaxLength = 32767;
            this.metroTextBoxSID.Name = "metroTextBoxSID";
            this.metroTextBoxSID.PasswordChar = '\0';
            this.metroTextBoxSID.ReadOnly = true;
            this.metroTextBoxSID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSID.SelectedText = "";
            this.metroTextBoxSID.SelectionLength = 0;
            this.metroTextBoxSID.SelectionStart = 0;
            this.metroTextBoxSID.ShortcutsEnabled = true;
            this.metroTextBoxSID.Size = new System.Drawing.Size(212, 28);
            this.metroTextBoxSID.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBoxSID.TabIndex = 32;
            this.metroTextBoxSID.UseCustomBackColor = true;
            this.metroTextBoxSID.UseCustomForeColor = true;
            this.metroTextBoxSID.UseSelectable = true;
            this.metroTextBoxSID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonCleanCells
            // 
            this.metroButtonCleanCells.Location = new System.Drawing.Point(670, 218);
            this.metroButtonCleanCells.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonCleanCells.Name = "metroButtonCleanCells";
            this.metroButtonCleanCells.Size = new System.Drawing.Size(199, 23);
            this.metroButtonCleanCells.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonCleanCells.TabIndex = 35;
            this.metroButtonCleanCells.Text = "Cella ürítés";
            this.metroButtonCleanCells.UseCustomBackColor = true;
            this.metroButtonCleanCells.UseSelectable = true;
            this.metroButtonCleanCells.UseStyleColors = true;
            this.metroButtonCleanCells.Click += new System.EventHandler(this.metroButtonCleanCells_Click);
            // 
            // metroButtonSearch
            // 
            this.metroButtonSearch.Location = new System.Drawing.Point(888, 218);
            this.metroButtonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonSearch.Name = "metroButtonSearch";
            this.metroButtonSearch.Size = new System.Drawing.Size(199, 23);
            this.metroButtonSearch.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonSearch.TabIndex = 34;
            this.metroButtonSearch.Text = "Keresés";
            this.metroButtonSearch.UseCustomBackColor = true;
            this.metroButtonSearch.UseSelectable = true;
            this.metroButtonSearch.UseStyleColors = true;
            this.metroButtonSearch.Click += new System.EventHandler(this.metroButtonSearch_Click);
            // 
            // metroButtonModify
            // 
            this.metroButtonModify.Location = new System.Drawing.Point(561, 581);
            this.metroButtonModify.Margin = new System.Windows.Forms.Padding(4);
            this.metroButtonModify.Name = "metroButtonModify";
            this.metroButtonModify.Size = new System.Drawing.Size(208, 28);
            this.metroButtonModify.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonModify.TabIndex = 38;
            this.metroButtonModify.Text = "Módosítása";
            this.metroButtonModify.UseCustomBackColor = true;
            this.metroButtonModify.UseSelectable = true;
            this.metroButtonModify.UseStyleColors = true;
            this.metroButtonModify.Click += new System.EventHandler(this.metroButtonModify_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(289, 581);
            this.metroButtonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(208, 28);
            this.metroButtonDelete.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonDelete.TabIndex = 37;
            this.metroButtonDelete.Text = "Törlés";
            this.metroButtonDelete.UseCustomBackColor = true;
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.UseStyleColors = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroButtonAddSchool
            // 
            this.metroButtonAddSchool.Location = new System.Drawing.Point(24, 581);
            this.metroButtonAddSchool.Margin = new System.Windows.Forms.Padding(4);
            this.metroButtonAddSchool.Name = "metroButtonAddSchool";
            this.metroButtonAddSchool.Size = new System.Drawing.Size(208, 28);
            this.metroButtonAddSchool.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonAddSchool.TabIndex = 36;
            this.metroButtonAddSchool.Text = "Felvétel";
            this.metroButtonAddSchool.UseCustomBackColor = true;
            this.metroButtonAddSchool.UseSelectable = true;
            this.metroButtonAddSchool.UseStyleColors = true;
            this.metroButtonAddSchool.Click += new System.EventHandler(this.metroButtonAddSchool_Click);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            this.errorProviderName.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderName.Icon")));
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            this.errorProviderPhone.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderPhone.Icon")));
            // 
            // errorProviderLocation
            // 
            this.errorProviderLocation.ContainerControl = this;
            this.errorProviderLocation.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderLocation.Icon")));
            // 
            // metroGridSchoolBasic
            // 
            this.metroGridSchoolBasic.AllowUserToResizeRows = false;
            this.metroGridSchoolBasic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridSchoolBasic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridSchoolBasic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridSchoolBasic.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridSchoolBasic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridSchoolBasic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridSchoolBasic.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridSchoolBasic.EnableHeadersVisualStyles = false;
            this.metroGridSchoolBasic.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridSchoolBasic.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridSchoolBasic.Location = new System.Drawing.Point(23, 284);
            this.metroGridSchoolBasic.Name = "metroGridSchoolBasic";
            this.metroGridSchoolBasic.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridSchoolBasic.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridSchoolBasic.RowHeadersWidth = 51;
            this.metroGridSchoolBasic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridSchoolBasic.RowTemplate.Height = 24;
            this.metroGridSchoolBasic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridSchoolBasic.Size = new System.Drawing.Size(1095, 212);
            this.metroGridSchoolBasic.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGridSchoolBasic.TabIndex = 39;
            this.metroGridSchoolBasic.SelectionChanged += new System.EventHandler(this.metroGridSchoolBasic_SelectionChanged);
            // 
            // AddSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 633);
            this.Controls.Add(this.metroGridSchoolBasic);
            this.Controls.Add(this.metroButtonModify);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonAddSchool);
            this.Controls.Add(this.metroButtonCleanCells);
            this.Controls.Add(this.metroButtonSearch);
            this.Controls.Add(this.metroTextBoxSID);
            this.Controls.Add(this.metroTextBoxPhone);
            this.Controls.Add(this.metroTextBoxLocation);
            this.Controls.Add(this.metroTextBoxName);
            this.Controls.Add(this.metroLabelPhone);
            this.Controls.Add(this.metroLabelLocation);
            this.Controls.Add(this.metroLabelName);
            this.Controls.Add(this.metroLabelSID);
            this.Name = "AddSchool";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Iskolai intézmény hozzáadása";
            this.Load += new System.EventHandler(this.AddSchool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridSchoolBasic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelSID;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroLabel metroLabelLocation;
        private MetroFramework.Controls.MetroLabel metroLabelPhone;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLocation;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPhone;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSID;
        private MetroFramework.Controls.MetroButton metroButtonCleanCells;
        private MetroFramework.Controls.MetroButton metroButtonSearch;
        private MetroFramework.Controls.MetroButton metroButtonModify;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroButton metroButtonAddSchool;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
        private System.Windows.Forms.ErrorProvider errorProviderLocation;
        private MetroFramework.Controls.MetroGrid metroGridSchoolBasic;
    }
}