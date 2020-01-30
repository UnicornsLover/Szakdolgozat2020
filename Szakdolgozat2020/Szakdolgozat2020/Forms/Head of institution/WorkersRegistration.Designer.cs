namespace Szakdolgozat2020.Forms.Head_of_institution
{
    partial class WorkersRegistration
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
            this.metroLabelUserId = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxJobType = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxUserId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelJobtType = new MetroFramework.Controls.MetroLabel();
            this.metroLabelBDate = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxYear = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDay = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxMonth = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonAddWorker = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroTextBoxBPlace = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelBPlace = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelUserId
            // 
            this.metroLabelUserId.AutoSize = true;
            this.metroLabelUserId.Location = new System.Drawing.Point(29, 117);
            this.metroLabelUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelUserId.Name = "metroLabelUserId";
            this.metroLabelUserId.Size = new System.Drawing.Size(137, 20);
            this.metroLabelUserId.TabIndex = 0;
            this.metroLabelUserId.Text = "Dolgozó azonosítója:";
            // 
            // metroComboBoxJobType
            // 
            this.metroComboBoxJobType.FormattingEnabled = true;
            this.metroComboBoxJobType.ItemHeight = 24;
            this.metroComboBoxJobType.Items.AddRange(new object[] {
            "Intézményvezető",
            "Intézmény ügyintéző",
            "Pszichológus",
            "Nevelő",
            "Szülő",
            "Rendszergazda"});
            this.metroComboBoxJobType.Location = new System.Drawing.Point(232, 164);
            this.metroComboBoxJobType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroComboBoxJobType.Name = "metroComboBoxJobType";
            this.metroComboBoxJobType.Size = new System.Drawing.Size(267, 30);
            this.metroComboBoxJobType.TabIndex = 1;
            this.metroComboBoxJobType.UseSelectable = true;
            // 
            // metroTextBoxUserId
            // 
            // 
            // 
            // 
            this.metroTextBoxUserId.CustomButton.Image = null;
            this.metroTextBoxUserId.CustomButton.Location = new System.Drawing.Point(323, 2);
            this.metroTextBoxUserId.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBoxUserId.CustomButton.Name = "";
            this.metroTextBoxUserId.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.metroTextBoxUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUserId.CustomButton.TabIndex = 1;
            this.metroTextBoxUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUserId.CustomButton.UseSelectable = true;
            this.metroTextBoxUserId.CustomButton.Visible = false;
            this.metroTextBoxUserId.Lines = new string[0];
            this.metroTextBoxUserId.Location = new System.Drawing.Point(232, 117);
            this.metroTextBoxUserId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBoxUserId.MaxLength = 32767;
            this.metroTextBoxUserId.Name = "metroTextBoxUserId";
            this.metroTextBoxUserId.PasswordChar = '\0';
            this.metroTextBoxUserId.ReadOnly = true;
            this.metroTextBoxUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUserId.SelectedText = "";
            this.metroTextBoxUserId.SelectionLength = 0;
            this.metroTextBoxUserId.SelectionStart = 0;
            this.metroTextBoxUserId.ShortcutsEnabled = true;
            this.metroTextBoxUserId.Size = new System.Drawing.Size(268, 28);
            this.metroTextBoxUserId.TabIndex = 2;
            this.metroTextBoxUserId.UseSelectable = true;
            this.metroTextBoxUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelJobtType
            // 
            this.metroLabelJobtType.AutoSize = true;
            this.metroLabelJobtType.Location = new System.Drawing.Point(29, 176);
            this.metroLabelJobtType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelJobtType.Name = "metroLabelJobtType";
            this.metroLabelJobtType.Size = new System.Drawing.Size(130, 20);
            this.metroLabelJobtType.TabIndex = 3;
            this.metroLabelJobtType.Text = "Betöltött munkakör:";
            // 
            // metroLabelBDate
            // 
            this.metroLabelBDate.AutoSize = true;
            this.metroLabelBDate.Location = new System.Drawing.Point(29, 230);
            this.metroLabelBDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelBDate.Name = "metroLabelBDate";
            this.metroLabelBDate.Size = new System.Drawing.Size(89, 20);
            this.metroLabelBDate.TabIndex = 4;
            this.metroLabelBDate.Text = "Születési idő:";
            // 
            // metroTextBoxYear
            // 
            // 
            // 
            // 
            this.metroTextBoxYear.CustomButton.Image = null;
            this.metroTextBoxYear.CustomButton.Location = new System.Drawing.Point(65, 2);
            this.metroTextBoxYear.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBoxYear.CustomButton.Name = "";
            this.metroTextBoxYear.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.metroTextBoxYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxYear.CustomButton.TabIndex = 1;
            this.metroTextBoxYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxYear.CustomButton.UseSelectable = true;
            this.metroTextBoxYear.CustomButton.Visible = false;
            this.metroTextBoxYear.Lines = new string[0];
            this.metroTextBoxYear.Location = new System.Drawing.Point(232, 225);
            this.metroTextBoxYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBoxYear.MaxLength = 32767;
            this.metroTextBoxYear.Name = "metroTextBoxYear";
            this.metroTextBoxYear.PasswordChar = '\0';
            this.metroTextBoxYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxYear.SelectedText = "";
            this.metroTextBoxYear.SelectionLength = 0;
            this.metroTextBoxYear.SelectionStart = 0;
            this.metroTextBoxYear.ShortcutsEnabled = true;
            this.metroTextBoxYear.Size = new System.Drawing.Size(75, 28);
            this.metroTextBoxYear.TabIndex = 5;
            this.metroTextBoxYear.UseSelectable = true;
            this.metroTextBoxYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxDay
            // 
            // 
            // 
            // 
            this.metroTextBoxDay.CustomButton.Image = null;
            this.metroTextBoxDay.CustomButton.Location = new System.Drawing.Point(65, 2);
            this.metroTextBoxDay.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBoxDay.CustomButton.Name = "";
            this.metroTextBoxDay.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.metroTextBoxDay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDay.CustomButton.TabIndex = 1;
            this.metroTextBoxDay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDay.CustomButton.UseSelectable = true;
            this.metroTextBoxDay.CustomButton.Visible = false;
            this.metroTextBoxDay.Lines = new string[0];
            this.metroTextBoxDay.Location = new System.Drawing.Point(425, 225);
            this.metroTextBoxDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBoxDay.MaxLength = 32767;
            this.metroTextBoxDay.Name = "metroTextBoxDay";
            this.metroTextBoxDay.PasswordChar = '\0';
            this.metroTextBoxDay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDay.SelectedText = "";
            this.metroTextBoxDay.SelectionLength = 0;
            this.metroTextBoxDay.SelectionStart = 0;
            this.metroTextBoxDay.ShortcutsEnabled = true;
            this.metroTextBoxDay.Size = new System.Drawing.Size(75, 28);
            this.metroTextBoxDay.TabIndex = 6;
            this.metroTextBoxDay.UseSelectable = true;
            this.metroTextBoxDay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxDay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxMonth
            // 
            // 
            // 
            // 
            this.metroTextBoxMonth.CustomButton.Image = null;
            this.metroTextBoxMonth.CustomButton.Location = new System.Drawing.Point(65, 2);
            this.metroTextBoxMonth.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBoxMonth.CustomButton.Name = "";
            this.metroTextBoxMonth.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.metroTextBoxMonth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMonth.CustomButton.TabIndex = 1;
            this.metroTextBoxMonth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMonth.CustomButton.UseSelectable = true;
            this.metroTextBoxMonth.CustomButton.Visible = false;
            this.metroTextBoxMonth.Lines = new string[0];
            this.metroTextBoxMonth.Location = new System.Drawing.Point(329, 225);
            this.metroTextBoxMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBoxMonth.MaxLength = 32767;
            this.metroTextBoxMonth.Name = "metroTextBoxMonth";
            this.metroTextBoxMonth.PasswordChar = '\0';
            this.metroTextBoxMonth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMonth.SelectedText = "";
            this.metroTextBoxMonth.SelectionLength = 0;
            this.metroTextBoxMonth.SelectionStart = 0;
            this.metroTextBoxMonth.ShortcutsEnabled = true;
            this.metroTextBoxMonth.Size = new System.Drawing.Size(75, 28);
            this.metroTextBoxMonth.TabIndex = 7;
            this.metroTextBoxMonth.UseSelectable = true;
            this.metroTextBoxMonth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMonth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 338);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 20);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Lakcím:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Általános Iskola",
            "Gimnázium",
            "Főiskola",
            "Egyetem",
            "Doktori (phD)"});
            this.metroComboBox1.Location = new System.Drawing.Point(233, 325);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(267, 30);
            this.metroComboBox1.TabIndex = 13;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroButtonAddWorker
            // 
            this.metroButtonAddWorker.Location = new System.Drawing.Point(167, 471);
            this.metroButtonAddWorker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButtonAddWorker.Name = "metroButtonAddWorker";
            this.metroButtonAddWorker.Size = new System.Drawing.Size(208, 28);
            this.metroButtonAddWorker.TabIndex = 14;
            this.metroButtonAddWorker.Text = "Dolgozó felvétele";
            this.metroButtonAddWorker.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(560, 117);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(456, 294);
            this.metroGrid1.TabIndex = 15;
            // 
            // metroTextBoxBPlace
            // 
            // 
            // 
            // 
            this.metroTextBoxBPlace.CustomButton.Image = null;
            this.metroTextBoxBPlace.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.metroTextBoxBPlace.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxBPlace.CustomButton.Name = "";
            this.metroTextBoxBPlace.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxBPlace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxBPlace.CustomButton.TabIndex = 1;
            this.metroTextBoxBPlace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxBPlace.CustomButton.UseSelectable = true;
            this.metroTextBoxBPlace.CustomButton.Visible = false;
            this.metroTextBoxBPlace.Lines = new string[0];
            this.metroTextBoxBPlace.Location = new System.Drawing.Point(232, 276);
            this.metroTextBoxBPlace.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxBPlace.MaxLength = 32767;
            this.metroTextBoxBPlace.Name = "metroTextBoxBPlace";
            this.metroTextBoxBPlace.PasswordChar = '\0';
            this.metroTextBoxBPlace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBPlace.SelectedText = "";
            this.metroTextBoxBPlace.SelectionLength = 0;
            this.metroTextBoxBPlace.SelectionStart = 0;
            this.metroTextBoxBPlace.ShortcutsEnabled = true;
            this.metroTextBoxBPlace.Size = new System.Drawing.Size(268, 28);
            this.metroTextBoxBPlace.TabIndex = 9;
            this.metroTextBoxBPlace.UseSelectable = true;
            this.metroTextBoxBPlace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxBPlace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelBPlace
            // 
            this.metroLabelBPlace.AutoSize = true;
            this.metroLabelBPlace.Location = new System.Drawing.Point(29, 281);
            this.metroLabelBPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelBPlace.Name = "metroLabelBPlace";
            this.metroLabelBPlace.Size = new System.Drawing.Size(96, 20);
            this.metroLabelBPlace.TabIndex = 8;
            this.metroLabelBPlace.Text = "Születési hely:";
            // 
            // WorkersRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 549);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroButtonAddWorker);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxBPlace);
            this.Controls.Add(this.metroLabelBPlace);
            this.Controls.Add(this.metroTextBoxMonth);
            this.Controls.Add(this.metroTextBoxDay);
            this.Controls.Add(this.metroTextBoxYear);
            this.Controls.Add(this.metroLabelBDate);
            this.Controls.Add(this.metroLabelJobtType);
            this.Controls.Add(this.metroTextBoxUserId);
            this.Controls.Add(this.metroComboBoxJobType);
            this.Controls.Add(this.metroLabelUserId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WorkersRegistration";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Dologozó regisztrálása:";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelUserId;
        private MetroFramework.Controls.MetroComboBox metroComboBoxJobType;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUserId;
        private MetroFramework.Controls.MetroLabel metroLabelJobtType;
        private MetroFramework.Controls.MetroLabel metroLabelBDate;
        private MetroFramework.Controls.MetroTextBox metroTextBoxYear;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDay;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMonth;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton metroButtonAddWorker;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBPlace;
        private MetroFramework.Controls.MetroLabel metroLabelBPlace;
    }
}