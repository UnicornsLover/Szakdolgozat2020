namespace Szakdolgozat2020.Forms.Nevelo
{
    partial class ChildrenReg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildrenReg));
            this.metroLabelID = new MetroFramework.Controls.MetroLabel();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelIdCard = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTaj = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelBirthday = new MetroFramework.Controls.MetroLabel();
            this.metroLabelComming = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLocation = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxID = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxBPlace = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTaj = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxIdCard = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxLocation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelSex = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxSex = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTimeBDate = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTimeComing = new MetroFramework.Controls.MetroDateTime();
            this.metroGridChildren = new MetroFramework.Controls.MetroGrid();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonModify = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroLabelDb = new MetroFramework.Controls.MetroLabel();
            this.metroButtonClearCells = new MetroFramework.Controls.MetroButton();
            this.metroButtonSearch = new MetroFramework.Controls.MetroButton();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSex = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIdCard = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTaj = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBPlace = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderComing = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLocation = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderComing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelID
            // 
            this.metroLabelID.AutoSize = true;
            this.metroLabelID.Location = new System.Drawing.Point(47, 99);
            this.metroLabelID.Name = "metroLabelID";
            this.metroLabelID.Size = new System.Drawing.Size(73, 20);
            this.metroLabelID.TabIndex = 0;
            this.metroLabelID.Text = "Azonosító:";
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.Location = new System.Drawing.Point(47, 207);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(46, 20);
            this.metroLabelName.TabIndex = 1;
            this.metroLabelName.Text = "Neve:";
            // 
            // metroLabelIdCard
            // 
            this.metroLabelIdCard.AutoSize = true;
            this.metroLabelIdCard.Location = new System.Drawing.Point(466, 107);
            this.metroLabelIdCard.Name = "metroLabelIdCard";
            this.metroLabelIdCard.Size = new System.Drawing.Size(165, 20);
            this.metroLabelIdCard.TabIndex = 2;
            this.metroLabelIdCard.Text = "Szeméyligazolvány szám:";
            // 
            // metroLabelTaj
            // 
            this.metroLabelTaj.AutoSize = true;
            this.metroLabelTaj.Location = new System.Drawing.Point(466, 154);
            this.metroLabelTaj.Name = "metroLabelTaj";
            this.metroLabelTaj.Size = new System.Drawing.Size(106, 20);
            this.metroLabelTaj.TabIndex = 3;
            this.metroLabelTaj.Text = "Taj kártya szám:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1001, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Születési hely:";
            // 
            // metroLabelBirthday
            // 
            this.metroLabelBirthday.AutoSize = true;
            this.metroLabelBirthday.Location = new System.Drawing.Point(466, 207);
            this.metroLabelBirthday.Name = "metroLabelBirthday";
            this.metroLabelBirthday.Size = new System.Drawing.Size(89, 20);
            this.metroLabelBirthday.TabIndex = 5;
            this.metroLabelBirthday.Text = "Születési idő:";
            // 
            // metroLabelComming
            // 
            this.metroLabelComming.AutoSize = true;
            this.metroLabelComming.Location = new System.Drawing.Point(1001, 154);
            this.metroLabelComming.Name = "metroLabelComming";
            this.metroLabelComming.Size = new System.Drawing.Size(122, 20);
            this.metroLabelComming.TabIndex = 6;
            this.metroLabelComming.Text = "Belépés időpontja:";
            // 
            // metroLabelLocation
            // 
            this.metroLabelLocation.AutoSize = true;
            this.metroLabelLocation.Location = new System.Drawing.Point(1001, 207);
            this.metroLabelLocation.Name = "metroLabelLocation";
            this.metroLabelLocation.Size = new System.Drawing.Size(221, 20);
            this.metroLabelLocation.TabIndex = 7;
            this.metroLabelLocation.Text = "Intézmény helye, ahol tartózkodik:";
            // 
            // metroTextBoxID
            // 
            this.metroTextBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
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
            this.metroTextBoxID.ForeColor = System.Drawing.Color.White;
            this.metroTextBoxID.Lines = new string[0];
            this.metroTextBoxID.Location = new System.Drawing.Point(151, 99);
            this.metroTextBoxID.MaxLength = 32767;
            this.metroTextBoxID.Name = "metroTextBoxID";
            this.metroTextBoxID.PasswordChar = '\0';
            this.metroTextBoxID.ReadOnly = true;
            this.metroTextBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxID.SelectedText = "";
            this.metroTextBoxID.SelectionLength = 0;
            this.metroTextBoxID.SelectionStart = 0;
            this.metroTextBoxID.ShortcutsEnabled = true;
            this.metroTextBoxID.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxID.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxID.TabIndex = 8;
            this.metroTextBoxID.UseCustomBackColor = true;
            this.metroTextBoxID.UseCustomForeColor = true;
            this.metroTextBoxID.UseSelectable = true;
            this.metroTextBoxID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxBPlace
            // 
            // 
            // 
            // 
            this.metroTextBoxBPlace.CustomButton.Image = null;
            this.metroTextBoxBPlace.CustomButton.Location = new System.Drawing.Point(276, 2);
            this.metroTextBoxBPlace.CustomButton.Name = "";
            this.metroTextBoxBPlace.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxBPlace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxBPlace.CustomButton.TabIndex = 1;
            this.metroTextBoxBPlace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxBPlace.CustomButton.UseSelectable = true;
            this.metroTextBoxBPlace.CustomButton.Visible = false;
            this.metroTextBoxBPlace.Lines = new string[0];
            this.metroTextBoxBPlace.Location = new System.Drawing.Point(1196, 99);
            this.metroTextBoxBPlace.MaxLength = 32767;
            this.metroTextBoxBPlace.Name = "metroTextBoxBPlace";
            this.metroTextBoxBPlace.PasswordChar = '\0';
            this.metroTextBoxBPlace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBPlace.SelectedText = "";
            this.metroTextBoxBPlace.SelectionLength = 0;
            this.metroTextBoxBPlace.SelectionStart = 0;
            this.metroTextBoxBPlace.ShortcutsEnabled = true;
            this.metroTextBoxBPlace.Size = new System.Drawing.Size(302, 28);
            this.metroTextBoxBPlace.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxBPlace.TabIndex = 10;
            this.metroTextBoxBPlace.UseSelectable = true;
            this.metroTextBoxBPlace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxBPlace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxTaj
            // 
            // 
            // 
            // 
            this.metroTextBoxTaj.CustomButton.Image = null;
            this.metroTextBoxTaj.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxTaj.CustomButton.Name = "";
            this.metroTextBoxTaj.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxTaj.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTaj.CustomButton.TabIndex = 1;
            this.metroTextBoxTaj.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTaj.CustomButton.UseSelectable = true;
            this.metroTextBoxTaj.CustomButton.Visible = false;
            this.metroTextBoxTaj.Lines = new string[0];
            this.metroTextBoxTaj.Location = new System.Drawing.Point(692, 146);
            this.metroTextBoxTaj.MaxLength = 32767;
            this.metroTextBoxTaj.Name = "metroTextBoxTaj";
            this.metroTextBoxTaj.PasswordChar = '\0';
            this.metroTextBoxTaj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTaj.SelectedText = "";
            this.metroTextBoxTaj.SelectionLength = 0;
            this.metroTextBoxTaj.SelectionStart = 0;
            this.metroTextBoxTaj.ShortcutsEnabled = true;
            this.metroTextBoxTaj.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxTaj.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxTaj.TabIndex = 12;
            this.metroTextBoxTaj.UseSelectable = true;
            this.metroTextBoxTaj.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTaj.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroTextBoxIdCard.Location = new System.Drawing.Point(692, 99);
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
            this.metroTextBoxIdCard.TabIndex = 13;
            this.metroTextBoxIdCard.UseSelectable = true;
            this.metroTextBoxIdCard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxIdCard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroTextBoxName.Location = new System.Drawing.Point(151, 199);
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
            this.metroTextBoxName.TabIndex = 14;
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
            this.metroTextBoxLocation.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.metroTextBoxLocation.CustomButton.Name = "";
            this.metroTextBoxLocation.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLocation.CustomButton.TabIndex = 1;
            this.metroTextBoxLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLocation.CustomButton.UseSelectable = true;
            this.metroTextBoxLocation.CustomButton.Visible = false;
            this.metroTextBoxLocation.Lines = new string[0];
            this.metroTextBoxLocation.Location = new System.Drawing.Point(1289, 201);
            this.metroTextBoxLocation.MaxLength = 32767;
            this.metroTextBoxLocation.Name = "metroTextBoxLocation";
            this.metroTextBoxLocation.PasswordChar = '\0';
            this.metroTextBoxLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLocation.SelectedText = "";
            this.metroTextBoxLocation.SelectionLength = 0;
            this.metroTextBoxLocation.SelectionStart = 0;
            this.metroTextBoxLocation.ShortcutsEnabled = true;
            this.metroTextBoxLocation.Size = new System.Drawing.Size(209, 28);
            this.metroTextBoxLocation.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxLocation.TabIndex = 15;
            this.metroTextBoxLocation.UseSelectable = true;
            this.metroTextBoxLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelSex
            // 
            this.metroLabelSex.AutoSize = true;
            this.metroLabelSex.Location = new System.Drawing.Point(47, 154);
            this.metroLabelSex.Name = "metroLabelSex";
            this.metroLabelSex.Size = new System.Drawing.Size(51, 20);
            this.metroLabelSex.TabIndex = 16;
            this.metroLabelSex.Text = "Neme:";
            // 
            // metroComboBoxSex
            // 
            this.metroComboBoxSex.FormattingEnabled = true;
            this.metroComboBoxSex.ItemHeight = 24;
            this.metroComboBoxSex.Items.AddRange(new object[] {
            "nő",
            "férfi"});
            this.metroComboBoxSex.Location = new System.Drawing.Point(151, 144);
            this.metroComboBoxSex.Name = "metroComboBoxSex";
            this.metroComboBoxSex.Size = new System.Drawing.Size(269, 30);
            this.metroComboBoxSex.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBoxSex.TabIndex = 17;
            this.metroComboBoxSex.UseSelectable = true;
            // 
            // metroDateTimeBDate
            // 
            this.metroDateTimeBDate.CustomFormat = "yyyy-MM-dd";
            this.metroDateTimeBDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTimeBDate.Location = new System.Drawing.Point(692, 199);
            this.metroDateTimeBDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTimeBDate.Name = "metroDateTimeBDate";
            this.metroDateTimeBDate.Size = new System.Drawing.Size(269, 30);
            this.metroDateTimeBDate.Style = MetroFramework.MetroColorStyle.Green;
            this.metroDateTimeBDate.TabIndex = 18;
            // 
            // metroDateTimeComing
            // 
            this.metroDateTimeComing.CustomFormat = "yyyy-MM-dd";
            this.metroDateTimeComing.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTimeComing.Location = new System.Drawing.Point(1196, 144);
            this.metroDateTimeComing.MinimumSize = new System.Drawing.Size(4, 30);
            this.metroDateTimeComing.Name = "metroDateTimeComing";
            this.metroDateTimeComing.Size = new System.Drawing.Size(302, 30);
            this.metroDateTimeComing.Style = MetroFramework.MetroColorStyle.Green;
            this.metroDateTimeComing.TabIndex = 19;
            // 
            // metroGridChildren
            // 
            this.metroGridChildren.AllowUserToResizeRows = false;
            this.metroGridChildren.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridChildren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridChildren.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridChildren.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridChildren.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridChildren.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridChildren.EnableHeadersVisualStyles = false;
            this.metroGridChildren.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridChildren.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridChildren.Location = new System.Drawing.Point(37, 302);
            this.metroGridChildren.Name = "metroGridChildren";
            this.metroGridChildren.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridChildren.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridChildren.RowHeadersWidth = 51;
            this.metroGridChildren.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridChildren.RowTemplate.Height = 24;
            this.metroGridChildren.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridChildren.Size = new System.Drawing.Size(1461, 318);
            this.metroGridChildren.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGridChildren.TabIndex = 20;
            this.metroGridChildren.SelectionChanged += new System.EventHandler(this.metroGridChildren_SelectionChanged);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonAdd.Location = new System.Drawing.Point(37, 672);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(208, 28);
            this.metroButtonAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonAdd.TabIndex = 21;
            this.metroButtonAdd.Text = "Felvétel";
            this.metroButtonAdd.UseCustomBackColor = true;
            this.metroButtonAdd.UseCustomForeColor = true;
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroButtonModify
            // 
            this.metroButtonModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonModify.Location = new System.Drawing.Point(305, 672);
            this.metroButtonModify.Name = "metroButtonModify";
            this.metroButtonModify.Size = new System.Drawing.Size(208, 28);
            this.metroButtonModify.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonModify.TabIndex = 22;
            this.metroButtonModify.Text = "Módosítás";
            this.metroButtonModify.UseCustomBackColor = true;
            this.metroButtonModify.UseCustomForeColor = true;
            this.metroButtonModify.UseSelectable = true;
            this.metroButtonModify.Click += new System.EventHandler(this.metroButtonModify_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonDelete.Location = new System.Drawing.Point(573, 672);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(208, 28);
            this.metroButtonDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonDelete.TabIndex = 23;
            this.metroButtonDelete.Text = "Törlés";
            this.metroButtonDelete.UseCustomBackColor = true;
            this.metroButtonDelete.UseCustomForeColor = true;
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroLabelDb
            // 
            this.metroLabelDb.AutoSize = true;
            this.metroLabelDb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroLabelDb.Location = new System.Drawing.Point(957, 680);
            this.metroLabelDb.Name = "metroLabelDb";
            this.metroLabelDb.Size = new System.Drawing.Size(0, 0);
            this.metroLabelDb.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelDb.TabIndex = 24;
            this.metroLabelDb.UseCustomBackColor = true;
            this.metroLabelDb.UseCustomForeColor = true;
            // 
            // metroButtonClearCells
            // 
            this.metroButtonClearCells.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonClearCells.Location = new System.Drawing.Point(1290, 252);
            this.metroButtonClearCells.Name = "metroButtonClearCells";
            this.metroButtonClearCells.Size = new System.Drawing.Size(208, 28);
            this.metroButtonClearCells.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonClearCells.TabIndex = 25;
            this.metroButtonClearCells.Text = "Cella üritése";
            this.metroButtonClearCells.UseCustomBackColor = true;
            this.metroButtonClearCells.UseCustomForeColor = true;
            this.metroButtonClearCells.UseSelectable = true;
            this.metroButtonClearCells.Click += new System.EventHandler(this.metroButtonClearCells_Click);
            // 
            // metroButtonSearch
            // 
            this.metroButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonSearch.Location = new System.Drawing.Point(1014, 252);
            this.metroButtonSearch.Name = "metroButtonSearch";
            this.metroButtonSearch.Size = new System.Drawing.Size(208, 28);
            this.metroButtonSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonSearch.TabIndex = 26;
            this.metroButtonSearch.Text = "Keresés";
            this.metroButtonSearch.UseCustomBackColor = true;
            this.metroButtonSearch.UseCustomForeColor = true;
            this.metroButtonSearch.UseSelectable = true;
            this.metroButtonSearch.Click += new System.EventHandler(this.metroButtonSearch_Click);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            this.errorProviderName.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderName.Icon")));
            // 
            // errorProviderSex
            // 
            this.errorProviderSex.ContainerControl = this;
            this.errorProviderSex.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderSex.Icon")));
            // 
            // errorProviderIdCard
            // 
            this.errorProviderIdCard.ContainerControl = this;
            this.errorProviderIdCard.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderIdCard.Icon")));
            // 
            // errorProviderTaj
            // 
            this.errorProviderTaj.ContainerControl = this;
            this.errorProviderTaj.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderTaj.Icon")));
            // 
            // errorProviderBdate
            // 
            this.errorProviderBdate.ContainerControl = this;
            this.errorProviderBdate.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderBdate.Icon")));
            // 
            // errorProviderBPlace
            // 
            this.errorProviderBPlace.ContainerControl = this;
            this.errorProviderBPlace.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderBPlace.Icon")));
            // 
            // errorProviderComing
            // 
            this.errorProviderComing.ContainerControl = this;
            this.errorProviderComing.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderComing.Icon")));
            // 
            // errorProviderLocation
            // 
            this.errorProviderLocation.ContainerControl = this;
            this.errorProviderLocation.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderLocation.Icon")));
            // 
            // ChildrenReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 716);
            this.Controls.Add(this.metroButtonSearch);
            this.Controls.Add(this.metroButtonClearCells);
            this.Controls.Add(this.metroLabelDb);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonModify);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroGridChildren);
            this.Controls.Add(this.metroDateTimeComing);
            this.Controls.Add(this.metroDateTimeBDate);
            this.Controls.Add(this.metroComboBoxSex);
            this.Controls.Add(this.metroLabelSex);
            this.Controls.Add(this.metroTextBoxLocation);
            this.Controls.Add(this.metroTextBoxName);
            this.Controls.Add(this.metroTextBoxIdCard);
            this.Controls.Add(this.metroTextBoxTaj);
            this.Controls.Add(this.metroTextBoxBPlace);
            this.Controls.Add(this.metroTextBoxID);
            this.Controls.Add(this.metroLabelLocation);
            this.Controls.Add(this.metroLabelComming);
            this.Controls.Add(this.metroLabelBirthday);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelTaj);
            this.Controls.Add(this.metroLabelIdCard);
            this.Controls.Add(this.metroLabelName);
            this.Controls.Add(this.metroLabelID);
            this.Name = "ChildrenReg";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Gyermek regisztráció:";
            this.Load += new System.EventHandler(this.ChildrenReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderComing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelID;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroLabel metroLabelIdCard;
        private MetroFramework.Controls.MetroLabel metroLabelTaj;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelBirthday;
        private MetroFramework.Controls.MetroLabel metroLabelComming;
        private MetroFramework.Controls.MetroLabel metroLabelLocation;
        private MetroFramework.Controls.MetroTextBox metroTextBoxID;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBPlace;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTaj;
        private MetroFramework.Controls.MetroTextBox metroTextBoxIdCard;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLocation;
        private MetroFramework.Controls.MetroLabel metroLabelSex;
        private MetroFramework.Controls.MetroComboBox metroComboBoxSex;
        private MetroFramework.Controls.MetroDateTime metroDateTimeBDate;
        private MetroFramework.Controls.MetroDateTime metroDateTimeComing;
        private MetroFramework.Controls.MetroGrid metroGridChildren;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroButton metroButtonModify;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroLabel metroLabelDb;
        private MetroFramework.Controls.MetroButton metroButtonClearCells;
        private MetroFramework.Controls.MetroButton metroButtonSearch;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderSex;
        private System.Windows.Forms.ErrorProvider errorProviderIdCard;
        private System.Windows.Forms.ErrorProvider errorProviderTaj;
        private System.Windows.Forms.ErrorProvider errorProviderBdate;
        private System.Windows.Forms.ErrorProvider errorProviderBPlace;
        private System.Windows.Forms.ErrorProvider errorProviderComing;
        private System.Windows.Forms.ErrorProvider errorProviderLocation;
    }
}