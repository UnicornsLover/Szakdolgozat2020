﻿namespace Szakdolgozat2020.Forms.Administrator
{
    partial class ParentsReg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelUser = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLogPermission = new MetroFramework.Controls.MetroLabel();
            this.metroLabelIDCard = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPass = new MetroFramework.Controls.MetroLabel();
            this.metroLabelBDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabelSex = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxUser = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxIdCard = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTimeBDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabelID = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxID = new MetroFramework.Controls.MetroTextBox();
            this.metroGridParents = new MetroFramework.Controls.MetroGrid();
            this.metroButtonSearch = new MetroFramework.Controls.MetroButton();
            this.metroButtonClearCells = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonModify = new MetroFramework.Controls.MetroButton();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroComboBoxLoginPermission = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxSex = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelPdb = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridParents)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.Location = new System.Drawing.Point(52, 144);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(46, 20);
            this.metroLabelName.TabIndex = 0;
            this.metroLabelName.Text = "Neve:";
            // 
            // metroLabelUser
            // 
            this.metroLabelUser.AutoSize = true;
            this.metroLabelUser.Location = new System.Drawing.Point(1043, 94);
            this.metroLabelUser.Name = "metroLabelUser";
            this.metroLabelUser.Size = new System.Drawing.Size(107, 20);
            this.metroLabelUser.TabIndex = 1;
            this.metroLabelUser.Text = "Felhasználónév:";
            // 
            // metroLabelLogPermission
            // 
            this.metroLabelLogPermission.AutoSize = true;
            this.metroLabelLogPermission.Location = new System.Drawing.Point(485, 194);
            this.metroLabelLogPermission.Name = "metroLabelLogPermission";
            this.metroLabelLogPermission.Size = new System.Drawing.Size(70, 20);
            this.metroLabelLogPermission.TabIndex = 2;
            this.metroLabelLogPermission.Text = "Engedély:";
            // 
            // metroLabelIDCard
            // 
            this.metroLabelIDCard.AutoSize = true;
            this.metroLabelIDCard.Location = new System.Drawing.Point(485, 144);
            this.metroLabelIDCard.Name = "metroLabelIDCard";
            this.metroLabelIDCard.Size = new System.Drawing.Size(165, 20);
            this.metroLabelIDCard.TabIndex = 3;
            this.metroLabelIDCard.Text = "Személyigazolvány szám:";
            // 
            // metroLabelPass
            // 
            this.metroLabelPass.AutoSize = true;
            this.metroLabelPass.Location = new System.Drawing.Point(1043, 144);
            this.metroLabelPass.Name = "metroLabelPass";
            this.metroLabelPass.Size = new System.Drawing.Size(49, 20);
            this.metroLabelPass.TabIndex = 4;
            this.metroLabelPass.Text = "Jelszó:";
            // 
            // metroLabelBDate
            // 
            this.metroLabelBDate.AutoSize = true;
            this.metroLabelBDate.Location = new System.Drawing.Point(485, 94);
            this.metroLabelBDate.Name = "metroLabelBDate";
            this.metroLabelBDate.Size = new System.Drawing.Size(89, 20);
            this.metroLabelBDate.TabIndex = 6;
            this.metroLabelBDate.Text = "Születési idő:";
            // 
            // metroLabelSex
            // 
            this.metroLabelSex.AutoSize = true;
            this.metroLabelSex.Location = new System.Drawing.Point(47, 194);
            this.metroLabelSex.Name = "metroLabelSex";
            this.metroLabelSex.Size = new System.Drawing.Size(51, 20);
            this.metroLabelSex.TabIndex = 7;
            this.metroLabelSex.Text = "Neme:";
            // 
            // metroTextBoxName
            // 
            // 
            // 
            // 
            this.metroTextBoxName.CustomButton.Image = null;
            this.metroTextBoxName.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxName.CustomButton.Name = "";
            this.metroTextBoxName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxName.CustomButton.TabIndex = 1;
            this.metroTextBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxName.CustomButton.UseSelectable = true;
            this.metroTextBoxName.CustomButton.Visible = false;
            this.metroTextBoxName.Lines = new string[0];
            this.metroTextBoxName.Location = new System.Drawing.Point(169, 136);
            this.metroTextBoxName.MaxLength = 32767;
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.PasswordChar = '\0';
            this.metroTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxName.SelectedText = "";
            this.metroTextBoxName.SelectionLength = 0;
            this.metroTextBoxName.SelectionStart = 0;
            this.metroTextBoxName.ShortcutsEnabled = true;
            this.metroTextBoxName.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxName.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxName.TabIndex = 8;
            this.metroTextBoxName.UseSelectable = true;
            this.metroTextBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(1195, 136);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '\0';
            this.metroTextBoxPassword.ReadOnly = true;
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxPassword.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxPassword.TabIndex = 9;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxUser
            // 
            // 
            // 
            // 
            this.metroTextBoxUser.CustomButton.Image = null;
            this.metroTextBoxUser.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxUser.CustomButton.Name = "";
            this.metroTextBoxUser.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUser.CustomButton.TabIndex = 1;
            this.metroTextBoxUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUser.CustomButton.UseSelectable = true;
            this.metroTextBoxUser.CustomButton.Visible = false;
            this.metroTextBoxUser.Lines = new string[0];
            this.metroTextBoxUser.Location = new System.Drawing.Point(1195, 86);
            this.metroTextBoxUser.MaxLength = 32767;
            this.metroTextBoxUser.Name = "metroTextBoxUser";
            this.metroTextBoxUser.PasswordChar = '\0';
            this.metroTextBoxUser.ReadOnly = true;
            this.metroTextBoxUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUser.SelectedText = "";
            this.metroTextBoxUser.SelectionLength = 0;
            this.metroTextBoxUser.SelectionStart = 0;
            this.metroTextBoxUser.ShortcutsEnabled = true;
            this.metroTextBoxUser.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxUser.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxUser.TabIndex = 10;
            this.metroTextBoxUser.UseSelectable = true;
            this.metroTextBoxUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxIdCard
            // 
            // 
            // 
            // 
            this.metroTextBoxIdCard.CustomButton.Image = null;
            this.metroTextBoxIdCard.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxIdCard.CustomButton.Name = "";
            this.metroTextBoxIdCard.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxIdCard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxIdCard.CustomButton.TabIndex = 1;
            this.metroTextBoxIdCard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxIdCard.CustomButton.UseSelectable = true;
            this.metroTextBoxIdCard.CustomButton.Visible = false;
            this.metroTextBoxIdCard.Lines = new string[0];
            this.metroTextBoxIdCard.Location = new System.Drawing.Point(688, 136);
            this.metroTextBoxIdCard.MaxLength = 32767;
            this.metroTextBoxIdCard.Name = "metroTextBoxIdCard";
            this.metroTextBoxIdCard.PasswordChar = '\0';
            this.metroTextBoxIdCard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxIdCard.SelectedText = "";
            this.metroTextBoxIdCard.SelectionLength = 0;
            this.metroTextBoxIdCard.SelectionStart = 0;
            this.metroTextBoxIdCard.ShortcutsEnabled = true;
            this.metroTextBoxIdCard.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxIdCard.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxIdCard.TabIndex = 12;
            this.metroTextBoxIdCard.UseSelectable = true;
            this.metroTextBoxIdCard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxIdCard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTimeBDate
            // 
            this.metroDateTimeBDate.CustomFormat = "yyyy-MM-dd";
            this.metroDateTimeBDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTimeBDate.Location = new System.Drawing.Point(688, 86);
            this.metroDateTimeBDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTimeBDate.Name = "metroDateTimeBDate";
            this.metroDateTimeBDate.Size = new System.Drawing.Size(269, 30);
            this.metroDateTimeBDate.Style = MetroFramework.MetroColorStyle.Green;
            this.metroDateTimeBDate.TabIndex = 15;
            // 
            // metroLabelID
            // 
            this.metroLabelID.AutoSize = true;
            this.metroLabelID.Location = new System.Drawing.Point(52, 96);
            this.metroLabelID.Name = "metroLabelID";
            this.metroLabelID.Size = new System.Drawing.Size(73, 20);
            this.metroLabelID.TabIndex = 16;
            this.metroLabelID.Text = "Azonosító:";
            // 
            // metroTextBoxID
            // 
            // 
            // 
            // 
            this.metroTextBoxID.CustomButton.Image = null;
            this.metroTextBoxID.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxID.CustomButton.Name = "";
            this.metroTextBoxID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxID.CustomButton.TabIndex = 1;
            this.metroTextBoxID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxID.CustomButton.UseSelectable = true;
            this.metroTextBoxID.CustomButton.Visible = false;
            this.metroTextBoxID.Lines = new string[0];
            this.metroTextBoxID.Location = new System.Drawing.Point(169, 86);
            this.metroTextBoxID.MaxLength = 32767;
            this.metroTextBoxID.Name = "metroTextBoxID";
            this.metroTextBoxID.PasswordChar = '\0';
            this.metroTextBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxID.SelectedText = "";
            this.metroTextBoxID.SelectionLength = 0;
            this.metroTextBoxID.SelectionStart = 0;
            this.metroTextBoxID.ShortcutsEnabled = true;
            this.metroTextBoxID.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxID.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxID.TabIndex = 17;
            this.metroTextBoxID.UseSelectable = true;
            this.metroTextBoxID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGridParents
            // 
            this.metroGridParents.AllowUserToResizeRows = false;
            this.metroGridParents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridParents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridParents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridParents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridParents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGridParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridParents.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGridParents.EnableHeadersVisualStyles = false;
            this.metroGridParents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridParents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridParents.Location = new System.Drawing.Point(52, 287);
            this.metroGridParents.Name = "metroGridParents";
            this.metroGridParents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridParents.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGridParents.RowHeadersWidth = 51;
            this.metroGridParents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridParents.RowTemplate.Height = 24;
            this.metroGridParents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridParents.Size = new System.Drawing.Size(1412, 354);
            this.metroGridParents.TabIndex = 18;
            this.metroGridParents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridParents_CellClick);
            // 
            // metroButtonSearch
            // 
            this.metroButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonSearch.Location = new System.Drawing.Point(1003, 207);
            this.metroButtonSearch.Name = "metroButtonSearch";
            this.metroButtonSearch.Size = new System.Drawing.Size(208, 28);
            this.metroButtonSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonSearch.TabIndex = 27;
            this.metroButtonSearch.Text = "Keresés";
            this.metroButtonSearch.UseCustomBackColor = true;
            this.metroButtonSearch.UseCustomForeColor = true;
            this.metroButtonSearch.UseSelectable = true;
            this.metroButtonSearch.Click += new System.EventHandler(this.metroButtonSearch_Click);
            // 
            // metroButtonClearCells
            // 
            this.metroButtonClearCells.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonClearCells.Location = new System.Drawing.Point(1256, 207);
            this.metroButtonClearCells.Name = "metroButtonClearCells";
            this.metroButtonClearCells.Size = new System.Drawing.Size(208, 28);
            this.metroButtonClearCells.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonClearCells.TabIndex = 28;
            this.metroButtonClearCells.Text = "Cella ürítés";
            this.metroButtonClearCells.UseCustomBackColor = true;
            this.metroButtonClearCells.UseCustomForeColor = true;
            this.metroButtonClearCells.UseSelectable = true;
            this.metroButtonClearCells.Click += new System.EventHandler(this.metroButtonClearCells_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonDelete.Location = new System.Drawing.Point(561, 672);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(208, 28);
            this.metroButtonDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonDelete.TabIndex = 29;
            this.metroButtonDelete.Text = "Törlés";
            this.metroButtonDelete.UseCustomBackColor = true;
            this.metroButtonDelete.UseCustomForeColor = true;
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroButtonModify
            // 
            this.metroButtonModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonModify.Location = new System.Drawing.Point(300, 672);
            this.metroButtonModify.Name = "metroButtonModify";
            this.metroButtonModify.Size = new System.Drawing.Size(208, 28);
            this.metroButtonModify.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonModify.TabIndex = 30;
            this.metroButtonModify.Text = "Módosítás";
            this.metroButtonModify.UseCustomBackColor = true;
            this.metroButtonModify.UseCustomForeColor = true;
            this.metroButtonModify.UseSelectable = true;
            this.metroButtonModify.Click += new System.EventHandler(this.metroButtonModify_Click);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonAdd.Location = new System.Drawing.Point(37, 672);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(208, 28);
            this.metroButtonAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonAdd.TabIndex = 31;
            this.metroButtonAdd.Text = "Felvétel";
            this.metroButtonAdd.UseCustomBackColor = true;
            this.metroButtonAdd.UseCustomForeColor = true;
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroComboBoxLoginPermission
            // 
            this.metroComboBoxLoginPermission.FormattingEnabled = true;
            this.metroComboBoxLoginPermission.ItemHeight = 24;
            this.metroComboBoxLoginPermission.Location = new System.Drawing.Point(688, 188);
            this.metroComboBoxLoginPermission.Name = "metroComboBoxLoginPermission";
            this.metroComboBoxLoginPermission.Size = new System.Drawing.Size(269, 30);
            this.metroComboBoxLoginPermission.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBoxLoginPermission.TabIndex = 32;
            this.metroComboBoxLoginPermission.UseSelectable = true;
            // 
            // metroComboBoxSex
            // 
            this.metroComboBoxSex.FormattingEnabled = true;
            this.metroComboBoxSex.ItemHeight = 24;
            this.metroComboBoxSex.Location = new System.Drawing.Point(169, 184);
            this.metroComboBoxSex.Name = "metroComboBoxSex";
            this.metroComboBoxSex.Size = new System.Drawing.Size(269, 30);
            this.metroComboBoxSex.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBoxSex.TabIndex = 33;
            this.metroComboBoxSex.UseSelectable = true;
            // 
            // metroLabelPdb
            // 
            this.metroLabelPdb.AutoSize = true;
            this.metroLabelPdb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroLabelPdb.Location = new System.Drawing.Point(942, 680);
            this.metroLabelPdb.Name = "metroLabelPdb";
            this.metroLabelPdb.Size = new System.Drawing.Size(0, 0);
            this.metroLabelPdb.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelPdb.TabIndex = 34;
            this.metroLabelPdb.UseCustomForeColor = true;
            // 
            // ParentsReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 742);
            this.Controls.Add(this.metroLabelPdb);
            this.Controls.Add(this.metroComboBoxSex);
            this.Controls.Add(this.metroComboBoxLoginPermission);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroButtonModify);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonClearCells);
            this.Controls.Add(this.metroButtonSearch);
            this.Controls.Add(this.metroGridParents);
            this.Controls.Add(this.metroTextBoxID);
            this.Controls.Add(this.metroLabelID);
            this.Controls.Add(this.metroDateTimeBDate);
            this.Controls.Add(this.metroTextBoxIdCard);
            this.Controls.Add(this.metroTextBoxUser);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroTextBoxName);
            this.Controls.Add(this.metroLabelSex);
            this.Controls.Add(this.metroLabelBDate);
            this.Controls.Add(this.metroLabelPass);
            this.Controls.Add(this.metroLabelIDCard);
            this.Controls.Add(this.metroLabelLogPermission);
            this.Controls.Add(this.metroLabelUser);
            this.Controls.Add(this.metroLabelName);
            this.Name = "ParentsReg";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Szülő regisztráció:";
            this.Load += new System.EventHandler(this.ParentsReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridParents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroLabel metroLabelUser;
        private MetroFramework.Controls.MetroLabel metroLabelLogPermission;
        private MetroFramework.Controls.MetroLabel metroLabelIDCard;
        private MetroFramework.Controls.MetroLabel metroLabelPass;
        private MetroFramework.Controls.MetroLabel metroLabelBDate;
        private MetroFramework.Controls.MetroLabel metroLabelSex;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUser;
        private MetroFramework.Controls.MetroTextBox metroTextBoxIdCard;
        private MetroFramework.Controls.MetroDateTime metroDateTimeBDate;
        private MetroFramework.Controls.MetroLabel metroLabelID;
        private MetroFramework.Controls.MetroTextBox metroTextBoxID;
        private MetroFramework.Controls.MetroGrid metroGridParents;
        private MetroFramework.Controls.MetroButton metroButtonSearch;
        private MetroFramework.Controls.MetroButton metroButtonClearCells;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroButton metroButtonModify;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroComboBox metroComboBoxLoginPermission;
        private MetroFramework.Controls.MetroComboBox metroComboBoxSex;
        private MetroFramework.Controls.MetroLabel metroLabelPdb;
    }
}