﻿namespace Szakdolgozat2020.Forms.Head_of_institution
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
            this.metroComboBoxEjobtype = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxEID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelEJobtype = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEDate = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEBirth = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelELocation = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxELocation = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonAddWorker = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxBPlace = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelBPlace = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEMaidenname = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEname = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxEMaidname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelESex = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxESex = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelEUname = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEPassword = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxEPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroGridEmployes = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEmployes)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelUserId
            // 
            this.metroLabelUserId.AutoSize = true;
            this.metroLabelUserId.Location = new System.Drawing.Point(28, 95);
            this.metroLabelUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelUserId.Name = "metroLabelUserId";
            this.metroLabelUserId.Size = new System.Drawing.Size(137, 20);
            this.metroLabelUserId.TabIndex = 0;
            this.metroLabelUserId.Text = "Dolgozó azonosítója:";
            // 
            // metroComboBoxEjobtype
            // 
            this.metroComboBoxEjobtype.FormattingEnabled = true;
            this.metroComboBoxEjobtype.ItemHeight = 24;
            this.metroComboBoxEjobtype.Items.AddRange(new object[] {
            "Intézményvezető",
            "Intézmény ügyintéző",
            "Pszichológus",
            "Nevelő",
            "Szülő",
            "Rendszergazda"});
            this.metroComboBoxEjobtype.Location = new System.Drawing.Point(733, 224);
            this.metroComboBoxEjobtype.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBoxEjobtype.Name = "metroComboBoxEjobtype";
            this.metroComboBoxEjobtype.Size = new System.Drawing.Size(269, 30);
            this.metroComboBoxEjobtype.TabIndex = 1;
            this.metroComboBoxEjobtype.UseSelectable = true;
            // 
            // metroTextBoxEID
            // 
            // 
            // 
            // 
            this.metroTextBoxEID.CustomButton.Image = null;
            this.metroTextBoxEID.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.metroTextBoxEID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEID.CustomButton.Name = "";
            this.metroTextBoxEID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxEID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEID.CustomButton.TabIndex = 1;
            this.metroTextBoxEID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEID.CustomButton.UseSelectable = true;
            this.metroTextBoxEID.CustomButton.Visible = false;
            this.metroTextBoxEID.Lines = new string[0];
            this.metroTextBoxEID.Location = new System.Drawing.Point(230, 95);
            this.metroTextBoxEID.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEID.MaxLength = 32767;
            this.metroTextBoxEID.Name = "metroTextBoxEID";
            this.metroTextBoxEID.PasswordChar = '\0';
            this.metroTextBoxEID.ReadOnly = true;
            this.metroTextBoxEID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEID.SelectedText = "";
            this.metroTextBoxEID.SelectionLength = 0;
            this.metroTextBoxEID.SelectionStart = 0;
            this.metroTextBoxEID.ShortcutsEnabled = true;
            this.metroTextBoxEID.Size = new System.Drawing.Size(268, 28);
            this.metroTextBoxEID.TabIndex = 2;
            this.metroTextBoxEID.UseSelectable = true;
            this.metroTextBoxEID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelEJobtype
            // 
            this.metroLabelEJobtype.AutoSize = true;
            this.metroLabelEJobtype.Location = new System.Drawing.Point(530, 236);
            this.metroLabelEJobtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEJobtype.Name = "metroLabelEJobtype";
            this.metroLabelEJobtype.Size = new System.Drawing.Size(130, 20);
            this.metroLabelEJobtype.TabIndex = 3;
            this.metroLabelEJobtype.Text = "Betöltött munkakör:";
            // 
            // metroLabelEDate
            // 
            this.metroLabelEDate.AutoSize = true;
            this.metroLabelEDate.Location = new System.Drawing.Point(531, 102);
            this.metroLabelEDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEDate.Name = "metroLabelEDate";
            this.metroLabelEDate.Size = new System.Drawing.Size(89, 20);
            this.metroLabelEDate.TabIndex = 4;
            this.metroLabelEDate.Text = "Születési idő:";
            // 
            // metroTextBoxEBirth
            // 
            // 
            // 
            // 
            this.metroTextBoxEBirth.CustomButton.Image = null;
            this.metroTextBoxEBirth.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxEBirth.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEBirth.CustomButton.Name = "";
            this.metroTextBoxEBirth.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxEBirth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEBirth.CustomButton.TabIndex = 1;
            this.metroTextBoxEBirth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEBirth.CustomButton.UseSelectable = true;
            this.metroTextBoxEBirth.CustomButton.Visible = false;
            this.metroTextBoxEBirth.Lines = new string[0];
            this.metroTextBoxEBirth.Location = new System.Drawing.Point(733, 94);
            this.metroTextBoxEBirth.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEBirth.MaxLength = 32767;
            this.metroTextBoxEBirth.Name = "metroTextBoxEBirth";
            this.metroTextBoxEBirth.PasswordChar = '\0';
            this.metroTextBoxEBirth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEBirth.SelectedText = "";
            this.metroTextBoxEBirth.SelectionLength = 0;
            this.metroTextBoxEBirth.SelectionStart = 0;
            this.metroTextBoxEBirth.ShortcutsEnabled = true;
            this.metroTextBoxEBirth.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxEBirth.TabIndex = 5;
            this.metroTextBoxEBirth.UseSelectable = true;
            this.metroTextBoxEBirth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEBirth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelELocation
            // 
            this.metroLabelELocation.AutoSize = true;
            this.metroLabelELocation.Location = new System.Drawing.Point(532, 197);
            this.metroLabelELocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelELocation.Name = "metroLabelELocation";
            this.metroLabelELocation.Size = new System.Drawing.Size(55, 20);
            this.metroLabelELocation.TabIndex = 12;
            this.metroLabelELocation.Text = "Lakcím:";
            // 
            // metroComboBoxELocation
            // 
            this.metroComboBoxELocation.FormattingEnabled = true;
            this.metroComboBoxELocation.ItemHeight = 24;
            this.metroComboBoxELocation.Items.AddRange(new object[] {
            "Általános Iskola",
            "Gimnázium",
            "Főiskola",
            "Egyetem",
            "Doktori (phD)"});
            this.metroComboBoxELocation.Location = new System.Drawing.Point(733, 184);
            this.metroComboBoxELocation.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBoxELocation.Name = "metroComboBoxELocation";
            this.metroComboBoxELocation.Size = new System.Drawing.Size(269, 30);
            this.metroComboBoxELocation.TabIndex = 13;
            this.metroComboBoxELocation.UseSelectable = true;
            // 
            // metroButtonAddWorker
            // 
            this.metroButtonAddWorker.Location = new System.Drawing.Point(44, 641);
            this.metroButtonAddWorker.Margin = new System.Windows.Forms.Padding(4);
            this.metroButtonAddWorker.Name = "metroButtonAddWorker";
            this.metroButtonAddWorker.Size = new System.Drawing.Size(208, 28);
            this.metroButtonAddWorker.TabIndex = 14;
            this.metroButtonAddWorker.Text = "Dolgozó felvétele";
            this.metroButtonAddWorker.UseSelectable = true;
            // 
            // metroTextBoxBPlace
            // 
            // 
            // 
            // 
            this.metroTextBoxBPlace.CustomButton.Image = null;
            this.metroTextBoxBPlace.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxBPlace.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxBPlace.CustomButton.Name = "";
            this.metroTextBoxBPlace.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxBPlace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxBPlace.CustomButton.TabIndex = 1;
            this.metroTextBoxBPlace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxBPlace.CustomButton.UseSelectable = true;
            this.metroTextBoxBPlace.CustomButton.Visible = false;
            this.metroTextBoxBPlace.Lines = new string[0];
            this.metroTextBoxBPlace.Location = new System.Drawing.Point(733, 141);
            this.metroTextBoxBPlace.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxBPlace.MaxLength = 32767;
            this.metroTextBoxBPlace.Name = "metroTextBoxBPlace";
            this.metroTextBoxBPlace.PasswordChar = '\0';
            this.metroTextBoxBPlace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBPlace.SelectedText = "";
            this.metroTextBoxBPlace.SelectionLength = 0;
            this.metroTextBoxBPlace.SelectionStart = 0;
            this.metroTextBoxBPlace.ShortcutsEnabled = true;
            this.metroTextBoxBPlace.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxBPlace.TabIndex = 9;
            this.metroTextBoxBPlace.UseSelectable = true;
            this.metroTextBoxBPlace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxBPlace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelBPlace
            // 
            this.metroLabelBPlace.AutoSize = true;
            this.metroLabelBPlace.Location = new System.Drawing.Point(531, 146);
            this.metroLabelBPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelBPlace.Name = "metroLabelBPlace";
            this.metroLabelBPlace.Size = new System.Drawing.Size(96, 20);
            this.metroLabelBPlace.TabIndex = 8;
            this.metroLabelBPlace.Text = "Születési hely:";
            // 
            // metroLabelEName
            // 
            this.metroLabelEName.AutoSize = true;
            this.metroLabelEName.Location = new System.Drawing.Point(28, 149);
            this.metroLabelEName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEName.Name = "metroLabelEName";
            this.metroLabelEName.Size = new System.Drawing.Size(99, 20);
            this.metroLabelEName.TabIndex = 16;
            this.metroLabelEName.Text = "Dolgozó neve:";
            // 
            // metroLabelEMaidenname
            // 
            this.metroLabelEMaidenname.AutoSize = true;
            this.metroLabelEMaidenname.Location = new System.Drawing.Point(28, 196);
            this.metroLabelEMaidenname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEMaidenname.Name = "metroLabelEMaidenname";
            this.metroLabelEMaidenname.Size = new System.Drawing.Size(151, 20);
            this.metroLabelEMaidenname.TabIndex = 17;
            this.metroLabelEMaidenname.Text = "Dolgozó lánykori neve:";
            // 
            // metroTextBoxEname
            // 
            // 
            // 
            // 
            this.metroTextBoxEname.CustomButton.Image = null;
            this.metroTextBoxEname.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxEname.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEname.CustomButton.Name = "";
            this.metroTextBoxEname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxEname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEname.CustomButton.TabIndex = 1;
            this.metroTextBoxEname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEname.CustomButton.UseSelectable = true;
            this.metroTextBoxEname.CustomButton.Visible = false;
            this.metroTextBoxEname.Lines = new string[0];
            this.metroTextBoxEname.Location = new System.Drawing.Point(230, 141);
            this.metroTextBoxEname.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEname.MaxLength = 32767;
            this.metroTextBoxEname.Name = "metroTextBoxEname";
            this.metroTextBoxEname.PasswordChar = '\0';
            this.metroTextBoxEname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEname.SelectedText = "";
            this.metroTextBoxEname.SelectionLength = 0;
            this.metroTextBoxEname.SelectionStart = 0;
            this.metroTextBoxEname.ShortcutsEnabled = true;
            this.metroTextBoxEname.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxEname.TabIndex = 18;
            this.metroTextBoxEname.UseSelectable = true;
            this.metroTextBoxEname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxEMaidname
            // 
            // 
            // 
            // 
            this.metroTextBoxEMaidname.CustomButton.Image = null;
            this.metroTextBoxEMaidname.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxEMaidname.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEMaidname.CustomButton.Name = "";
            this.metroTextBoxEMaidname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxEMaidname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEMaidname.CustomButton.TabIndex = 1;
            this.metroTextBoxEMaidname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEMaidname.CustomButton.UseSelectable = true;
            this.metroTextBoxEMaidname.CustomButton.Visible = false;
            this.metroTextBoxEMaidname.Lines = new string[0];
            this.metroTextBoxEMaidname.Location = new System.Drawing.Point(230, 188);
            this.metroTextBoxEMaidname.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEMaidname.MaxLength = 32767;
            this.metroTextBoxEMaidname.Name = "metroTextBoxEMaidname";
            this.metroTextBoxEMaidname.PasswordChar = '\0';
            this.metroTextBoxEMaidname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEMaidname.SelectedText = "";
            this.metroTextBoxEMaidname.SelectionLength = 0;
            this.metroTextBoxEMaidname.SelectionStart = 0;
            this.metroTextBoxEMaidname.ShortcutsEnabled = true;
            this.metroTextBoxEMaidname.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxEMaidname.TabIndex = 19;
            this.metroTextBoxEMaidname.UseSelectable = true;
            this.metroTextBoxEMaidname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEMaidname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelESex
            // 
            this.metroLabelESex.AutoSize = true;
            this.metroLabelESex.Location = new System.Drawing.Point(30, 244);
            this.metroLabelESex.Name = "metroLabelESex";
            this.metroLabelESex.Size = new System.Drawing.Size(104, 20);
            this.metroLabelESex.TabIndex = 20;
            this.metroLabelESex.Text = "Dolgozó neme:";
            // 
            // metroComboBoxESex
            // 
            this.metroComboBoxESex.FormattingEnabled = true;
            this.metroComboBoxESex.ItemHeight = 24;
            this.metroComboBoxESex.Items.AddRange(new object[] {
            "nő",
            "férfi"});
            this.metroComboBoxESex.Location = new System.Drawing.Point(230, 232);
            this.metroComboBoxESex.Name = "metroComboBoxESex";
            this.metroComboBoxESex.Size = new System.Drawing.Size(268, 30);
            this.metroComboBoxESex.TabIndex = 21;
            this.metroComboBoxESex.UseSelectable = true;
            // 
            // metroLabelEUname
            // 
            this.metroLabelEUname.AutoSize = true;
            this.metroLabelEUname.Location = new System.Drawing.Point(1069, 146);
            this.metroLabelEUname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEUname.Name = "metroLabelEUname";
            this.metroLabelEUname.Size = new System.Drawing.Size(110, 20);
            this.metroLabelEUname.TabIndex = 22;
            this.metroLabelEUname.Text = "Felhasználónév::";
            // 
            // metroLabelEPassword
            // 
            this.metroLabelEPassword.AutoSize = true;
            this.metroLabelEPassword.Location = new System.Drawing.Point(1067, 194);
            this.metroLabelEPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEPassword.Name = "metroLabelEPassword";
            this.metroLabelEPassword.Size = new System.Drawing.Size(49, 20);
            this.metroLabelEPassword.TabIndex = 23;
            this.metroLabelEPassword.Text = "Jelszó:";
            // 
            // metroTextBoxEUserName
            // 
            // 
            // 
            // 
            this.metroTextBoxEUserName.CustomButton.Image = null;
            this.metroTextBoxEUserName.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxEUserName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEUserName.CustomButton.Name = "";
            this.metroTextBoxEUserName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxEUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEUserName.CustomButton.TabIndex = 1;
            this.metroTextBoxEUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEUserName.CustomButton.UseSelectable = true;
            this.metroTextBoxEUserName.CustomButton.Visible = false;
            this.metroTextBoxEUserName.Lines = new string[0];
            this.metroTextBoxEUserName.Location = new System.Drawing.Point(1270, 138);
            this.metroTextBoxEUserName.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEUserName.MaxLength = 32767;
            this.metroTextBoxEUserName.Name = "metroTextBoxEUserName";
            this.metroTextBoxEUserName.PasswordChar = '\0';
            this.metroTextBoxEUserName.ReadOnly = true;
            this.metroTextBoxEUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEUserName.SelectedText = "";
            this.metroTextBoxEUserName.SelectionLength = 0;
            this.metroTextBoxEUserName.SelectionStart = 0;
            this.metroTextBoxEUserName.ShortcutsEnabled = true;
            this.metroTextBoxEUserName.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxEUserName.TabIndex = 24;
            this.metroTextBoxEUserName.UseSelectable = true;
            this.metroTextBoxEUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxEPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxEPassword.CustomButton.Image = null;
            this.metroTextBoxEPassword.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxEPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEPassword.CustomButton.Name = "";
            this.metroTextBoxEPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxEPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxEPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxEPassword.CustomButton.Visible = false;
            this.metroTextBoxEPassword.Lines = new string[0];
            this.metroTextBoxEPassword.Location = new System.Drawing.Point(1270, 186);
            this.metroTextBoxEPassword.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEPassword.MaxLength = 32767;
            this.metroTextBoxEPassword.Name = "metroTextBoxEPassword";
            this.metroTextBoxEPassword.PasswordChar = '\0';
            this.metroTextBoxEPassword.ReadOnly = true;
            this.metroTextBoxEPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEPassword.SelectedText = "";
            this.metroTextBoxEPassword.SelectionLength = 0;
            this.metroTextBoxEPassword.SelectionStart = 0;
            this.metroTextBoxEPassword.ShortcutsEnabled = true;
            this.metroTextBoxEPassword.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxEPassword.TabIndex = 25;
            this.metroTextBoxEPassword.UseSelectable = true;
            this.metroTextBoxEPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGridEmployes
            // 
            this.metroGridEmployes.AllowUserToResizeRows = false;
            this.metroGridEmployes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEmployes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridEmployes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridEmployes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEmployes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridEmployes.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridEmployes.EnableHeadersVisualStyles = false;
            this.metroGridEmployes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridEmployes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEmployes.Location = new System.Drawing.Point(29, 321);
            this.metroGridEmployes.Name = "metroGridEmployes";
            this.metroGridEmployes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEmployes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridEmployes.RowHeadersWidth = 51;
            this.metroGridEmployes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridEmployes.RowTemplate.Height = 24;
            this.metroGridEmployes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridEmployes.Size = new System.Drawing.Size(1529, 288);
            this.metroGridEmployes.Style = MetroFramework.MetroColorStyle.Red;
            this.metroGridEmployes.TabIndex = 26;
            this.metroGridEmployes.UseStyleColors = true;
            this.metroGridEmployes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridEmployes_CellClick);
            // 
            // WorkersRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 698);
            this.Controls.Add(this.metroGridEmployes);
            this.Controls.Add(this.metroTextBoxEPassword);
            this.Controls.Add(this.metroTextBoxEUserName);
            this.Controls.Add(this.metroLabelEPassword);
            this.Controls.Add(this.metroLabelEUname);
            this.Controls.Add(this.metroComboBoxESex);
            this.Controls.Add(this.metroLabelESex);
            this.Controls.Add(this.metroTextBoxEMaidname);
            this.Controls.Add(this.metroTextBoxEname);
            this.Controls.Add(this.metroLabelEMaidenname);
            this.Controls.Add(this.metroLabelEName);
            this.Controls.Add(this.metroButtonAddWorker);
            this.Controls.Add(this.metroComboBoxELocation);
            this.Controls.Add(this.metroLabelELocation);
            this.Controls.Add(this.metroTextBoxBPlace);
            this.Controls.Add(this.metroLabelBPlace);
            this.Controls.Add(this.metroTextBoxEBirth);
            this.Controls.Add(this.metroLabelEDate);
            this.Controls.Add(this.metroLabelEJobtype);
            this.Controls.Add(this.metroTextBoxEID);
            this.Controls.Add(this.metroComboBoxEjobtype);
            this.Controls.Add(this.metroLabelUserId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkersRegistration";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Dologozó regisztrálása:";
            this.Load += new System.EventHandler(this.WorkersRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEmployes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelUserId;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEjobtype;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEID;
        private MetroFramework.Controls.MetroLabel metroLabelEJobtype;
        private MetroFramework.Controls.MetroLabel metroLabelEDate;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEBirth;
        private MetroFramework.Controls.MetroLabel metroLabelELocation;
        private MetroFramework.Controls.MetroComboBox metroComboBoxELocation;
        private MetroFramework.Controls.MetroButton metroButtonAddWorker;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBPlace;
        private MetroFramework.Controls.MetroLabel metroLabelBPlace;
        private MetroFramework.Controls.MetroLabel metroLabelEName;
        private MetroFramework.Controls.MetroLabel metroLabelEMaidenname;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEname;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEMaidname;
        private MetroFramework.Controls.MetroLabel metroLabelESex;
        private MetroFramework.Controls.MetroComboBox metroComboBoxESex;
        private MetroFramework.Controls.MetroLabel metroLabelEUname;
        private MetroFramework.Controls.MetroLabel metroLabelEPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEUserName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEPassword;
        private MetroFramework.Controls.MetroGrid metroGridEmployes;
    }
}