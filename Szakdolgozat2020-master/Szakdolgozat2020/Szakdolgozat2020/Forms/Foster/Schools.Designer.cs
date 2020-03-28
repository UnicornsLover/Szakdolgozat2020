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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroButtonAddSchool = new MetroFramework.Controls.MetroButton();
            this.metroButtonLogOut = new MetroFramework.Controls.MetroButton();
            this.metroGridChildSchool = new MetroFramework.Controls.MetroGrid();
            this.metroComboBoxSchool = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelInt = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLoggedName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelWelcome = new MetroFramework.Controls.MetroLabel();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeBegin = new MetroFramework.Controls.MetroDateTime();
            this.metroLabelBegin = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFinish = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxType = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelType = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxHeadTeacher = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelHTeacher = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxChildren = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxIdS = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeFinish = new MetroFramework.Controls.MetroDateTime();
            this.metroButtonClearCells = new MetroFramework.Controls.MetroButton();
            this.metroButtonSearch = new MetroFramework.Controls.MetroButton();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonModify = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.errorProviderBeginn = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFinish = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderHTeacher = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSchool = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderChildren = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridChildSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBeginn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChildren)).BeginInit();
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
            this.metroButtonLogOut.Location = new System.Drawing.Point(1086, 636);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridChildSchool.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridChildSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridChildSchool.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridChildSchool.EnableHeadersVisualStyles = false;
            this.metroGridChildSchool.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridChildSchool.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridChildSchool.Location = new System.Drawing.Point(80, 318);
            this.metroGridChildSchool.Name = "metroGridChildSchool";
            this.metroGridChildSchool.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridChildSchool.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridChildSchool.RowHeadersWidth = 51;
            this.metroGridChildSchool.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridChildSchool.RowTemplate.Height = 24;
            this.metroGridChildSchool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridChildSchool.Size = new System.Drawing.Size(1143, 269);
            this.metroGridChildSchool.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGridChildSchool.TabIndex = 9;
            this.metroGridChildSchool.SelectionChanged += new System.EventHandler(this.metroGridChildSchool_SelectionChanged);
            // 
            // metroComboBoxSchool
            // 
            this.metroComboBoxSchool.FormattingEnabled = true;
            this.metroComboBoxSchool.ItemHeight = 24;
            this.metroComboBoxSchool.Items.AddRange(new object[] {
            ""});
            this.metroComboBoxSchool.Location = new System.Drawing.Point(54, 168);
            this.metroComboBoxSchool.Name = "metroComboBoxSchool";
            this.metroComboBoxSchool.Size = new System.Drawing.Size(547, 30);
            this.metroComboBoxSchool.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBoxSchool.TabIndex = 10;
            this.metroComboBoxSchool.UseSelectable = true;
            // 
            // metroLabelInt
            // 
            this.metroLabelInt.AutoSize = true;
            this.metroLabelInt.Location = new System.Drawing.Point(54, 139);
            this.metroLabelInt.Name = "metroLabelInt";
            this.metroLabelInt.Size = new System.Drawing.Size(92, 20);
            this.metroLabelInt.TabIndex = 11;
            this.metroLabelInt.Text = "Intézmények:";
            // 
            // metroLabelLoggedName
            // 
            this.metroLabelLoggedName.AutoSize = true;
            this.metroLabelLoggedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(226)))), ((int)(((byte)(7)))));
            this.metroLabelLoggedName.Location = new System.Drawing.Point(925, 27);
            this.metroLabelLoggedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelLoggedName.Name = "metroLabelLoggedName";
            this.metroLabelLoggedName.Size = new System.Drawing.Size(0, 0);
            this.metroLabelLoggedName.TabIndex = 13;
            this.metroLabelLoggedName.UseCustomForeColor = true;
            // 
            // metroLabelWelcome
            // 
            this.metroLabelWelcome.AutoSize = true;
            this.metroLabelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabelWelcome.Location = new System.Drawing.Point(717, 27);
            this.metroLabelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelWelcome.Name = "metroLabelWelcome";
            this.metroLabelWelcome.Size = new System.Drawing.Size(172, 20);
            this.metroLabelWelcome.TabIndex = 12;
            this.metroLabelWelcome.Text = "Üdvözölek a rendszerben:";
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.Location = new System.Drawing.Point(168, 217);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(104, 20);
            this.metroLabelName.TabIndex = 15;
            this.metroLabelName.Text = "Gyermek neve:";
            // 
            // metroDateTimeBegin
            // 
            this.metroDateTimeBegin.CustomFormat = "yyyy-MM-dd";
            this.metroDateTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTimeBegin.Location = new System.Drawing.Point(648, 168);
            this.metroDateTimeBegin.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTimeBegin.Name = "metroDateTimeBegin";
            this.metroDateTimeBegin.Size = new System.Drawing.Size(179, 30);
            this.metroDateTimeBegin.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroDateTimeBegin.TabIndex = 16;
            // 
            // metroLabelBegin
            // 
            this.metroLabelBegin.AutoSize = true;
            this.metroLabelBegin.Location = new System.Drawing.Point(648, 125);
            this.metroLabelBegin.Name = "metroLabelBegin";
            this.metroLabelBegin.Size = new System.Drawing.Size(107, 20);
            this.metroLabelBegin.TabIndex = 18;
            this.metroLabelBegin.Text = "Kezdés dátuma:";
            // 
            // metroLabelFinish
            // 
            this.metroLabelFinish.AutoSize = true;
            this.metroLabelFinish.Location = new System.Drawing.Point(874, 125);
            this.metroLabelFinish.Name = "metroLabelFinish";
            this.metroLabelFinish.Size = new System.Drawing.Size(124, 20);
            this.metroLabelFinish.TabIndex = 19;
            this.metroLabelFinish.Text = "Várható befejezés:";
            // 
            // metroTextBoxType
            // 
            // 
            // 
            // 
            this.metroTextBoxType.CustomButton.Image = null;
            this.metroTextBoxType.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxType.CustomButton.Name = "";
            this.metroTextBoxType.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxType.CustomButton.TabIndex = 1;
            this.metroTextBoxType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxType.CustomButton.UseSelectable = true;
            this.metroTextBoxType.CustomButton.Visible = false;
            this.metroTextBoxType.Lines = new string[0];
            this.metroTextBoxType.Location = new System.Drawing.Point(486, 250);
            this.metroTextBoxType.MaxLength = 32767;
            this.metroTextBoxType.Name = "metroTextBoxType";
            this.metroTextBoxType.PasswordChar = '\0';
            this.metroTextBoxType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxType.SelectedText = "";
            this.metroTextBoxType.SelectionLength = 0;
            this.metroTextBoxType.SelectionStart = 0;
            this.metroTextBoxType.ShortcutsEnabled = true;
            this.metroTextBoxType.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxType.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTextBoxType.TabIndex = 20;
            this.metroTextBoxType.UseSelectable = true;
            this.metroTextBoxType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelType
            // 
            this.metroLabelType.AutoSize = true;
            this.metroLabelType.Location = new System.Drawing.Point(486, 217);
            this.metroLabelType.Name = "metroLabelType";
            this.metroLabelType.Size = new System.Drawing.Size(45, 20);
            this.metroLabelType.TabIndex = 21;
            this.metroLabelType.Text = "Tipus:";
            // 
            // metroTextBoxHeadTeacher
            // 
            // 
            // 
            // 
            this.metroTextBoxHeadTeacher.CustomButton.Image = null;
            this.metroTextBoxHeadTeacher.CustomButton.Location = new System.Drawing.Point(227, 2);
            this.metroTextBoxHeadTeacher.CustomButton.Name = "";
            this.metroTextBoxHeadTeacher.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxHeadTeacher.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxHeadTeacher.CustomButton.TabIndex = 1;
            this.metroTextBoxHeadTeacher.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxHeadTeacher.CustomButton.UseSelectable = true;
            this.metroTextBoxHeadTeacher.CustomButton.Visible = false;
            this.metroTextBoxHeadTeacher.Lines = new string[0];
            this.metroTextBoxHeadTeacher.Location = new System.Drawing.Point(805, 250);
            this.metroTextBoxHeadTeacher.MaxLength = 32767;
            this.metroTextBoxHeadTeacher.Name = "metroTextBoxHeadTeacher";
            this.metroTextBoxHeadTeacher.PasswordChar = '\0';
            this.metroTextBoxHeadTeacher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxHeadTeacher.SelectedText = "";
            this.metroTextBoxHeadTeacher.SelectionLength = 0;
            this.metroTextBoxHeadTeacher.SelectionStart = 0;
            this.metroTextBoxHeadTeacher.ShortcutsEnabled = true;
            this.metroTextBoxHeadTeacher.Size = new System.Drawing.Size(253, 28);
            this.metroTextBoxHeadTeacher.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTextBoxHeadTeacher.TabIndex = 22;
            this.metroTextBoxHeadTeacher.UseSelectable = true;
            this.metroTextBoxHeadTeacher.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxHeadTeacher.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelHTeacher
            // 
            this.metroLabelHTeacher.AutoSize = true;
            this.metroLabelHTeacher.Location = new System.Drawing.Point(805, 217);
            this.metroLabelHTeacher.Name = "metroLabelHTeacher";
            this.metroLabelHTeacher.Size = new System.Drawing.Size(92, 20);
            this.metroLabelHTeacher.TabIndex = 23;
            this.metroLabelHTeacher.Text = "Osztályfönők:";
            // 
            // metroComboBoxChildren
            // 
            this.metroComboBoxChildren.FormattingEnabled = true;
            this.metroComboBoxChildren.ItemHeight = 24;
            this.metroComboBoxChildren.Location = new System.Drawing.Point(168, 248);
            this.metroComboBoxChildren.Name = "metroComboBoxChildren";
            this.metroComboBoxChildren.Size = new System.Drawing.Size(256, 30);
            this.metroComboBoxChildren.TabIndex = 24;
            this.metroComboBoxChildren.UseSelectable = true;
            // 
            // metroTextBoxIdS
            // 
            this.metroTextBoxIdS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            // 
            // 
            // 
            this.metroTextBoxIdS.CustomButton.Image = null;
            this.metroTextBoxIdS.CustomButton.Location = new System.Drawing.Point(66, 2);
            this.metroTextBoxIdS.CustomButton.Name = "";
            this.metroTextBoxIdS.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxIdS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxIdS.CustomButton.TabIndex = 1;
            this.metroTextBoxIdS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxIdS.CustomButton.UseSelectable = true;
            this.metroTextBoxIdS.CustomButton.Visible = false;
            this.metroTextBoxIdS.ForeColor = System.Drawing.Color.White;
            this.metroTextBoxIdS.Lines = new string[0];
            this.metroTextBoxIdS.Location = new System.Drawing.Point(54, 252);
            this.metroTextBoxIdS.MaxLength = 32767;
            this.metroTextBoxIdS.Name = "metroTextBoxIdS";
            this.metroTextBoxIdS.PasswordChar = '\0';
            this.metroTextBoxIdS.ReadOnly = true;
            this.metroTextBoxIdS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxIdS.SelectedText = "";
            this.metroTextBoxIdS.SelectionLength = 0;
            this.metroTextBoxIdS.SelectionStart = 0;
            this.metroTextBoxIdS.ShortcutsEnabled = true;
            this.metroTextBoxIdS.Size = new System.Drawing.Size(92, 28);
            this.metroTextBoxIdS.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTextBoxIdS.TabIndex = 25;
            this.metroTextBoxIdS.UseCustomBackColor = true;
            this.metroTextBoxIdS.UseCustomForeColor = true;
            this.metroTextBoxIdS.UseSelectable = true;
            this.metroTextBoxIdS.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxIdS.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 217);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 20);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Azonsító:";
            // 
            // metroDateTimeFinish
            // 
            this.metroDateTimeFinish.CustomFormat = "yyyy-MM-dd";
            this.metroDateTimeFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTimeFinish.Location = new System.Drawing.Point(874, 168);
            this.metroDateTimeFinish.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTimeFinish.Name = "metroDateTimeFinish";
            this.metroDateTimeFinish.Size = new System.Drawing.Size(184, 30);
            this.metroDateTimeFinish.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroDateTimeFinish.TabIndex = 17;
            // 
            // metroButtonClearCells
            // 
            this.metroButtonClearCells.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonClearCells.Location = new System.Drawing.Point(1097, 168);
            this.metroButtonClearCells.Name = "metroButtonClearCells";
            this.metroButtonClearCells.Size = new System.Drawing.Size(145, 28);
            this.metroButtonClearCells.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonClearCells.TabIndex = 30;
            this.metroButtonClearCells.Text = "Cella ürítés";
            this.metroButtonClearCells.UseCustomBackColor = true;
            this.metroButtonClearCells.UseSelectable = true;
            this.metroButtonClearCells.Click += new System.EventHandler(this.metroButtonClearCells_Click);
            // 
            // metroButtonSearch
            // 
            this.metroButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonSearch.Location = new System.Drawing.Point(1097, 250);
            this.metroButtonSearch.Name = "metroButtonSearch";
            this.metroButtonSearch.Size = new System.Drawing.Size(145, 28);
            this.metroButtonSearch.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonSearch.TabIndex = 29;
            this.metroButtonSearch.Text = "Keresés";
            this.metroButtonSearch.UseCustomBackColor = true;
            this.metroButtonSearch.UseSelectable = true;
            this.metroButtonSearch.Click += new System.EventHandler(this.metroButtonSearch_Click);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonAdd.Location = new System.Drawing.Point(23, 636);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(208, 28);
            this.metroButtonAdd.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonAdd.TabIndex = 34;
            this.metroButtonAdd.Text = "Felvétel";
            this.metroButtonAdd.UseCustomBackColor = true;
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroButtonModify
            // 
            this.metroButtonModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonModify.Location = new System.Drawing.Point(286, 636);
            this.metroButtonModify.Name = "metroButtonModify";
            this.metroButtonModify.Size = new System.Drawing.Size(208, 28);
            this.metroButtonModify.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonModify.TabIndex = 33;
            this.metroButtonModify.Text = "Módosítás";
            this.metroButtonModify.UseCustomBackColor = true;
            this.metroButtonModify.UseSelectable = true;
            this.metroButtonModify.Click += new System.EventHandler(this.metroButtonModify_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonDelete.Location = new System.Drawing.Point(547, 636);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(208, 28);
            this.metroButtonDelete.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonDelete.TabIndex = 32;
            this.metroButtonDelete.Text = "Törlés";
            this.metroButtonDelete.UseCustomBackColor = true;
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // errorProviderBeginn
            // 
            this.errorProviderBeginn.ContainerControl = this;
            // 
            // errorProviderFinish
            // 
            this.errorProviderFinish.ContainerControl = this;
            // 
            // errorProviderType
            // 
            this.errorProviderType.ContainerControl = this;
            // 
            // errorProviderHTeacher
            // 
            this.errorProviderHTeacher.ContainerControl = this;
            // 
            // errorProviderSchool
            // 
            this.errorProviderSchool.ContainerControl = this;
            // 
            // errorProviderChildren
            // 
            this.errorProviderChildren.ContainerControl = this;
            // 
            // Schools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 687);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroButtonModify);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonClearCells);
            this.Controls.Add(this.metroButtonSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxIdS);
            this.Controls.Add(this.metroComboBoxChildren);
            this.Controls.Add(this.metroLabelHTeacher);
            this.Controls.Add(this.metroTextBoxHeadTeacher);
            this.Controls.Add(this.metroLabelType);
            this.Controls.Add(this.metroTextBoxType);
            this.Controls.Add(this.metroLabelFinish);
            this.Controls.Add(this.metroLabelBegin);
            this.Controls.Add(this.metroDateTimeFinish);
            this.Controls.Add(this.metroDateTimeBegin);
            this.Controls.Add(this.metroLabelName);
            this.Controls.Add(this.metroLabelLoggedName);
            this.Controls.Add(this.metroLabelWelcome);
            this.Controls.Add(this.metroLabelInt);
            this.Controls.Add(this.metroComboBoxSchool);
            this.Controls.Add(this.metroGridChildSchool);
            this.Controls.Add(this.metroButtonLogOut);
            this.Controls.Add(this.metroButtonAddSchool);
            this.Name = "Schools";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Közoktatás";
            this.Load += new System.EventHandler(this.Schools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridChildSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBeginn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChildren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonAddSchool;
        private MetroFramework.Controls.MetroButton metroButtonLogOut;
        private MetroFramework.Controls.MetroGrid metroGridChildSchool;
        private MetroFramework.Controls.MetroComboBox metroComboBoxSchool;
        private MetroFramework.Controls.MetroLabel metroLabelInt;
        private MetroFramework.Controls.MetroLabel metroLabelLoggedName;
        private MetroFramework.Controls.MetroLabel metroLabelWelcome;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroDateTime metroDateTimeBegin;
        private MetroFramework.Controls.MetroLabel metroLabelBegin;
        private MetroFramework.Controls.MetroLabel metroLabelFinish;
        private MetroFramework.Controls.MetroTextBox metroTextBoxType;
        private MetroFramework.Controls.MetroLabel metroLabelType;
        private MetroFramework.Controls.MetroTextBox metroTextBoxHeadTeacher;
        private MetroFramework.Controls.MetroLabel metroLabelHTeacher;
        private MetroFramework.Controls.MetroComboBox metroComboBoxChildren;
        private MetroFramework.Controls.MetroTextBox metroTextBoxIdS;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFinish;
        private MetroFramework.Controls.MetroButton metroButtonClearCells;
        private MetroFramework.Controls.MetroButton metroButtonSearch;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroButton metroButtonModify;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private System.Windows.Forms.ErrorProvider errorProviderBeginn;
        private System.Windows.Forms.ErrorProvider errorProviderFinish;
        private System.Windows.Forms.ErrorProvider errorProviderType;
        private System.Windows.Forms.ErrorProvider errorProviderHTeacher;
        private System.Windows.Forms.ErrorProvider errorProviderSchool;
        private System.Windows.Forms.ErrorProvider errorProviderChildren;
    }
}