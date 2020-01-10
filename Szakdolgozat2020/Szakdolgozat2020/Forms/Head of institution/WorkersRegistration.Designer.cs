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
            this.metroLabelUserId = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxJobType = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxUserId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelJobtType = new MetroFramework.Controls.MetroLabel();
            this.metroLabelBDate = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxYear = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDay = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxMonth = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelBPlace = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxBPlace = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelAddress = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonAddWorker = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabelUserId
            // 
            this.metroLabelUserId.AutoSize = true;
            this.metroLabelUserId.Location = new System.Drawing.Point(22, 95);
            this.metroLabelUserId.Name = "metroLabelUserId";
            this.metroLabelUserId.Size = new System.Drawing.Size(132, 19);
            this.metroLabelUserId.TabIndex = 0;
            this.metroLabelUserId.Text = "Dolgozó azonosítója:";
            // 
            // metroComboBoxJobType
            // 
            this.metroComboBoxJobType.FormattingEnabled = true;
            this.metroComboBoxJobType.ItemHeight = 23;
            this.metroComboBoxJobType.Items.AddRange(new object[] {
            "Intézményvezető",
            "Intézmény ügyintéző",
            "Pszichológus",
            "Nevelő",
            "Szülő",
            "Rendszergazda"});
            this.metroComboBoxJobType.Location = new System.Drawing.Point(174, 133);
            this.metroComboBoxJobType.Name = "metroComboBoxJobType";
            this.metroComboBoxJobType.Size = new System.Drawing.Size(201, 29);
            this.metroComboBoxJobType.TabIndex = 1;
            this.metroComboBoxJobType.UseSelectable = true;
            // 
            // metroTextBoxUserId
            // 
            // 
            // 
            // 
            this.metroTextBoxUserId.CustomButton.Image = null;
            this.metroTextBoxUserId.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.metroTextBoxUserId.CustomButton.Name = "";
            this.metroTextBoxUserId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUserId.CustomButton.TabIndex = 1;
            this.metroTextBoxUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUserId.CustomButton.UseSelectable = true;
            this.metroTextBoxUserId.CustomButton.Visible = false;
            this.metroTextBoxUserId.Lines = new string[0];
            this.metroTextBoxUserId.Location = new System.Drawing.Point(174, 95);
            this.metroTextBoxUserId.MaxLength = 32767;
            this.metroTextBoxUserId.Name = "metroTextBoxUserId";
            this.metroTextBoxUserId.PasswordChar = '\0';
            this.metroTextBoxUserId.ReadOnly = true;
            this.metroTextBoxUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUserId.SelectedText = "";
            this.metroTextBoxUserId.SelectionLength = 0;
            this.metroTextBoxUserId.SelectionStart = 0;
            this.metroTextBoxUserId.ShortcutsEnabled = true;
            this.metroTextBoxUserId.Size = new System.Drawing.Size(201, 23);
            this.metroTextBoxUserId.TabIndex = 2;
            this.metroTextBoxUserId.UseSelectable = true;
            this.metroTextBoxUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelJobtType
            // 
            this.metroLabelJobtType.AutoSize = true;
            this.metroLabelJobtType.Location = new System.Drawing.Point(22, 143);
            this.metroLabelJobtType.Name = "metroLabelJobtType";
            this.metroLabelJobtType.Size = new System.Drawing.Size(125, 19);
            this.metroLabelJobtType.TabIndex = 3;
            this.metroLabelJobtType.Text = "Betöltött munkakör:";
            // 
            // metroLabelBDate
            // 
            this.metroLabelBDate.AutoSize = true;
            this.metroLabelBDate.Location = new System.Drawing.Point(22, 187);
            this.metroLabelBDate.Name = "metroLabelBDate";
            this.metroLabelBDate.Size = new System.Drawing.Size(84, 19);
            this.metroLabelBDate.TabIndex = 4;
            this.metroLabelBDate.Text = "Születési idő:";
            // 
            // metroTextBoxYear
            // 
            // 
            // 
            // 
            this.metroTextBoxYear.CustomButton.Image = null;
            this.metroTextBoxYear.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.metroTextBoxYear.CustomButton.Name = "";
            this.metroTextBoxYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxYear.CustomButton.TabIndex = 1;
            this.metroTextBoxYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxYear.CustomButton.UseSelectable = true;
            this.metroTextBoxYear.CustomButton.Visible = false;
            this.metroTextBoxYear.Lines = new string[0];
            this.metroTextBoxYear.Location = new System.Drawing.Point(174, 183);
            this.metroTextBoxYear.MaxLength = 32767;
            this.metroTextBoxYear.Name = "metroTextBoxYear";
            this.metroTextBoxYear.PasswordChar = '\0';
            this.metroTextBoxYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxYear.SelectedText = "";
            this.metroTextBoxYear.SelectionLength = 0;
            this.metroTextBoxYear.SelectionStart = 0;
            this.metroTextBoxYear.ShortcutsEnabled = true;
            this.metroTextBoxYear.Size = new System.Drawing.Size(56, 23);
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
            this.metroTextBoxDay.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.metroTextBoxDay.CustomButton.Name = "";
            this.metroTextBoxDay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxDay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDay.CustomButton.TabIndex = 1;
            this.metroTextBoxDay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDay.CustomButton.UseSelectable = true;
            this.metroTextBoxDay.CustomButton.Visible = false;
            this.metroTextBoxDay.Lines = new string[0];
            this.metroTextBoxDay.Location = new System.Drawing.Point(319, 183);
            this.metroTextBoxDay.MaxLength = 32767;
            this.metroTextBoxDay.Name = "metroTextBoxDay";
            this.metroTextBoxDay.PasswordChar = '\0';
            this.metroTextBoxDay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDay.SelectedText = "";
            this.metroTextBoxDay.SelectionLength = 0;
            this.metroTextBoxDay.SelectionStart = 0;
            this.metroTextBoxDay.ShortcutsEnabled = true;
            this.metroTextBoxDay.Size = new System.Drawing.Size(56, 23);
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
            this.metroTextBoxMonth.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.metroTextBoxMonth.CustomButton.Name = "";
            this.metroTextBoxMonth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxMonth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMonth.CustomButton.TabIndex = 1;
            this.metroTextBoxMonth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMonth.CustomButton.UseSelectable = true;
            this.metroTextBoxMonth.CustomButton.Visible = false;
            this.metroTextBoxMonth.Lines = new string[0];
            this.metroTextBoxMonth.Location = new System.Drawing.Point(247, 183);
            this.metroTextBoxMonth.MaxLength = 32767;
            this.metroTextBoxMonth.Name = "metroTextBoxMonth";
            this.metroTextBoxMonth.PasswordChar = '\0';
            this.metroTextBoxMonth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMonth.SelectedText = "";
            this.metroTextBoxMonth.SelectionLength = 0;
            this.metroTextBoxMonth.SelectionStart = 0;
            this.metroTextBoxMonth.ShortcutsEnabled = true;
            this.metroTextBoxMonth.Size = new System.Drawing.Size(56, 23);
            this.metroTextBoxMonth.TabIndex = 7;
            this.metroTextBoxMonth.UseSelectable = true;
            this.metroTextBoxMonth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMonth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelBPlace
            // 
            this.metroLabelBPlace.AutoSize = true;
            this.metroLabelBPlace.Location = new System.Drawing.Point(22, 228);
            this.metroLabelBPlace.Name = "metroLabelBPlace";
            this.metroLabelBPlace.Size = new System.Drawing.Size(88, 19);
            this.metroLabelBPlace.TabIndex = 8;
            this.metroLabelBPlace.Text = "Születési hely:";
            // 
            // metroTextBoxBPlace
            // 
            // 
            // 
            // 
            this.metroTextBoxBPlace.CustomButton.Image = null;
            this.metroTextBoxBPlace.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.metroTextBoxBPlace.CustomButton.Name = "";
            this.metroTextBoxBPlace.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxBPlace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxBPlace.CustomButton.TabIndex = 1;
            this.metroTextBoxBPlace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxBPlace.CustomButton.UseSelectable = true;
            this.metroTextBoxBPlace.CustomButton.Visible = false;
            this.metroTextBoxBPlace.Lines = new string[0];
            this.metroTextBoxBPlace.Location = new System.Drawing.Point(174, 224);
            this.metroTextBoxBPlace.MaxLength = 32767;
            this.metroTextBoxBPlace.Name = "metroTextBoxBPlace";
            this.metroTextBoxBPlace.PasswordChar = '\0';
            this.metroTextBoxBPlace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBPlace.SelectedText = "";
            this.metroTextBoxBPlace.SelectionLength = 0;
            this.metroTextBoxBPlace.SelectionStart = 0;
            this.metroTextBoxBPlace.ShortcutsEnabled = true;
            this.metroTextBoxBPlace.Size = new System.Drawing.Size(201, 23);
            this.metroTextBoxBPlace.TabIndex = 9;
            this.metroTextBoxBPlace.UseSelectable = true;
            this.metroTextBoxBPlace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxBPlace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelAddress
            // 
            this.metroLabelAddress.AutoSize = true;
            this.metroLabelAddress.Location = new System.Drawing.Point(22, 268);
            this.metroLabelAddress.Name = "metroLabelAddress";
            this.metroLabelAddress.Size = new System.Drawing.Size(52, 19);
            this.metroLabelAddress.TabIndex = 10;
            this.metroLabelAddress.Text = "Lakcím:";
            // 
            // metroTextBoxAddress
            // 
            // 
            // 
            // 
            this.metroTextBoxAddress.CustomButton.Image = null;
            this.metroTextBoxAddress.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.metroTextBoxAddress.CustomButton.Name = "";
            this.metroTextBoxAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAddress.CustomButton.TabIndex = 1;
            this.metroTextBoxAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAddress.CustomButton.UseSelectable = true;
            this.metroTextBoxAddress.CustomButton.Visible = false;
            this.metroTextBoxAddress.Lines = new string[0];
            this.metroTextBoxAddress.Location = new System.Drawing.Point(174, 264);
            this.metroTextBoxAddress.MaxLength = 32767;
            this.metroTextBoxAddress.Name = "metroTextBoxAddress";
            this.metroTextBoxAddress.PasswordChar = '\0';
            this.metroTextBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAddress.SelectedText = "";
            this.metroTextBoxAddress.SelectionLength = 0;
            this.metroTextBoxAddress.SelectionStart = 0;
            this.metroTextBoxAddress.ShortcutsEnabled = true;
            this.metroTextBoxAddress.Size = new System.Drawing.Size(201, 23);
            this.metroTextBoxAddress.TabIndex = 11;
            this.metroTextBoxAddress.UseSelectable = true;
            this.metroTextBoxAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 315);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Lakcím:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Általános Iskola",
            "Gimnázium",
            "Főiskola",
            "Egyetem",
            "Doktori (phD)"});
            this.metroComboBox1.Location = new System.Drawing.Point(174, 305);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(201, 29);
            this.metroComboBox1.TabIndex = 13;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroButtonAddWorker
            // 
            this.metroButtonAddWorker.Location = new System.Drawing.Point(125, 383);
            this.metroButtonAddWorker.Name = "metroButtonAddWorker";
            this.metroButtonAddWorker.Size = new System.Drawing.Size(156, 23);
            this.metroButtonAddWorker.TabIndex = 14;
            this.metroButtonAddWorker.Text = "Dolgozó felvétele";
            this.metroButtonAddWorker.UseSelectable = true;
            // 
            // WorkersRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 446);
            this.Controls.Add(this.metroButtonAddWorker);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxAddress);
            this.Controls.Add(this.metroLabelAddress);
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
            this.Name = "WorkersRegistration";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Dologozó regisztrálása:";
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
        private MetroFramework.Controls.MetroLabel metroLabelBPlace;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBPlace;
        private MetroFramework.Controls.MetroLabel metroLabelAddress;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAddress;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton metroButtonAddWorker;
    }
}