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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersRegistration));
            this.metroLabelUserId = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxEjobtype = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxEID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelEJobtype = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabelELocation = new MetroFramework.Controls.MetroLabel();
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
            this.metroButtonSearch = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonCleanCells = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonModify = new MetroFramework.Controls.MetroButton();
            this.metroDateTimeEBirth = new MetroFramework.Controls.MetroDateTime();
            this.errorProviderBPlace = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroButtonTheSame = new MetroFramework.Controls.MetroButton();
            this.metroButtonNone = new MetroFramework.Controls.MetroButton();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSex = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLocation = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderJob = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.errorProviderMaidenName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBirthdayDate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEmployes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMaidenName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBirthdayDate)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelUserId
            // 
            this.metroLabelUserId.AutoSize = true;
            this.metroLabelUserId.Location = new System.Drawing.Point(28, 103);
            this.metroLabelUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelUserId.Name = "metroLabelUserId";
            this.metroLabelUserId.Size = new System.Drawing.Size(93, 20);
            this.metroLabelUserId.TabIndex = 0;
            this.metroLabelUserId.Text = "Azonosítója *:";
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
            "Rendszergazda",
            "Ügyintéző"});
            this.metroComboBoxEjobtype.Location = new System.Drawing.Point(739, 244);
            this.metroComboBoxEjobtype.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBoxEjobtype.Name = "metroComboBoxEjobtype";
            this.metroComboBoxEjobtype.Size = new System.Drawing.Size(268, 30);
            this.metroComboBoxEjobtype.Style = MetroFramework.MetroColorStyle.Red;
            this.metroComboBoxEjobtype.TabIndex = 1;
            this.metroComboBoxEjobtype.UseSelectable = true;
            // 
            // metroTextBoxEID
            // 
            this.metroTextBoxEID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(29)))), ((int)(((byte)(71)))));
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
            this.metroTextBoxEID.ForeColor = System.Drawing.Color.White;
            this.metroTextBoxEID.Lines = new string[0];
            this.metroTextBoxEID.Location = new System.Drawing.Point(161, 106);
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
            this.metroTextBoxEID.UseCustomBackColor = true;
            this.metroTextBoxEID.UseCustomForeColor = true;
            this.metroTextBoxEID.UseSelectable = true;
            this.metroTextBoxEID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelEJobtype
            // 
            this.metroLabelEJobtype.AutoSize = true;
            this.metroLabelEJobtype.Location = new System.Drawing.Point(537, 251);
            this.metroLabelEJobtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEJobtype.Name = "metroLabelEJobtype";
            this.metroLabelEJobtype.Size = new System.Drawing.Size(130, 20);
            this.metroLabelEJobtype.TabIndex = 3;
            this.metroLabelEJobtype.Text = "Betöltött munkakör:";
            // 
            // metroLabelEDate
            // 
            this.metroLabelEDate.AutoSize = true;
            this.metroLabelEDate.Location = new System.Drawing.Point(537, 112);
            this.metroLabelEDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEDate.Name = "metroLabelEDate";
            this.metroLabelEDate.Size = new System.Drawing.Size(89, 20);
            this.metroLabelEDate.TabIndex = 4;
            this.metroLabelEDate.Text = "Születési idő:";
            // 
            // metroLabelELocation
            // 
            this.metroLabelELocation.AutoSize = true;
            this.metroLabelELocation.Location = new System.Drawing.Point(539, 206);
            this.metroLabelELocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelELocation.Name = "metroLabelELocation";
            this.metroLabelELocation.Size = new System.Drawing.Size(148, 20);
            this.metroLabelELocation.TabIndex = 12;
            this.metroLabelELocation.Text = "Lakcím (lakcím kártya):";
            // 
            // metroButtonAddWorker
            // 
            this.metroButtonAddWorker.Location = new System.Drawing.Point(37, 672);
            this.metroButtonAddWorker.Margin = new System.Windows.Forms.Padding(4);
            this.metroButtonAddWorker.Name = "metroButtonAddWorker";
            this.metroButtonAddWorker.Size = new System.Drawing.Size(208, 28);
            this.metroButtonAddWorker.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonAddWorker.TabIndex = 14;
            this.metroButtonAddWorker.Text = "Felvétel";
            this.metroButtonAddWorker.UseCustomBackColor = true;
            this.metroButtonAddWorker.UseSelectable = true;
            this.metroButtonAddWorker.UseStyleColors = true;
            this.metroButtonAddWorker.Click += new System.EventHandler(this.metroButtonAddWorker_Click);
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
            this.metroTextBoxBPlace.Location = new System.Drawing.Point(739, 151);
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
            this.metroTextBoxBPlace.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBoxBPlace.TabIndex = 9;
            this.metroTextBoxBPlace.UseSelectable = true;
            this.metroTextBoxBPlace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxBPlace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelBPlace
            // 
            this.metroLabelBPlace.AutoSize = true;
            this.metroLabelBPlace.Location = new System.Drawing.Point(537, 155);
            this.metroLabelBPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelBPlace.Name = "metroLabelBPlace";
            this.metroLabelBPlace.Size = new System.Drawing.Size(96, 20);
            this.metroLabelBPlace.TabIndex = 8;
            this.metroLabelBPlace.Text = "Születési hely:";
            // 
            // metroLabelEName
            // 
            this.metroLabelEName.AutoSize = true;
            this.metroLabelEName.Location = new System.Drawing.Point(29, 205);
            this.metroLabelEName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEName.Name = "metroLabelEName";
            this.metroLabelEName.Size = new System.Drawing.Size(46, 20);
            this.metroLabelEName.TabIndex = 16;
            this.metroLabelEName.Text = "Neve:";
            // 
            // metroLabelEMaidenname
            // 
            this.metroLabelEMaidenname.AutoSize = true;
            this.metroLabelEMaidenname.Location = new System.Drawing.Point(28, 246);
            this.metroLabelEMaidenname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEMaidenname.Name = "metroLabelEMaidenname";
            this.metroLabelEMaidenname.Size = new System.Drawing.Size(99, 20);
            this.metroLabelEMaidenname.TabIndex = 17;
            this.metroLabelEMaidenname.Text = "Lánykori neve:";
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
            this.metroTextBoxEname.Location = new System.Drawing.Point(160, 198);
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
            this.metroTextBoxEname.Style = MetroFramework.MetroColorStyle.Red;
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
            this.metroTextBoxEMaidname.CustomButton.Location = new System.Drawing.Point(139, 2);
            this.metroTextBoxEMaidname.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEMaidname.CustomButton.Name = "";
            this.metroTextBoxEMaidname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxEMaidname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEMaidname.CustomButton.TabIndex = 1;
            this.metroTextBoxEMaidname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEMaidname.CustomButton.UseSelectable = true;
            this.metroTextBoxEMaidname.CustomButton.Visible = false;
            this.metroTextBoxEMaidname.Lines = new string[0];
            this.metroTextBoxEMaidname.Location = new System.Drawing.Point(161, 246);
            this.metroTextBoxEMaidname.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxEMaidname.MaxLength = 32767;
            this.metroTextBoxEMaidname.Name = "metroTextBoxEMaidname";
            this.metroTextBoxEMaidname.PasswordChar = '\0';
            this.metroTextBoxEMaidname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEMaidname.SelectedText = "";
            this.metroTextBoxEMaidname.SelectionLength = 0;
            this.metroTextBoxEMaidname.SelectionStart = 0;
            this.metroTextBoxEMaidname.ShortcutsEnabled = true;
            this.metroTextBoxEMaidname.Size = new System.Drawing.Size(165, 28);
            this.metroTextBoxEMaidname.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBoxEMaidname.TabIndex = 19;
            this.metroTextBoxEMaidname.UseSelectable = true;
            this.metroTextBoxEMaidname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEMaidname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelESex
            // 
            this.metroLabelESex.AutoSize = true;
            this.metroLabelESex.Location = new System.Drawing.Point(28, 159);
            this.metroLabelESex.Name = "metroLabelESex";
            this.metroLabelESex.Size = new System.Drawing.Size(51, 20);
            this.metroLabelESex.TabIndex = 20;
            this.metroLabelESex.Text = "Neme:";
            // 
            // metroComboBoxESex
            // 
            this.metroComboBoxESex.FormattingEnabled = true;
            this.metroComboBoxESex.ItemHeight = 24;
            this.metroComboBoxESex.Items.AddRange(new object[] {
            "nő",
            "férfi"});
            this.metroComboBoxESex.Location = new System.Drawing.Point(160, 151);
            this.metroComboBoxESex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroComboBoxESex.Name = "metroComboBoxESex";
            this.metroComboBoxESex.Size = new System.Drawing.Size(268, 30);
            this.metroComboBoxESex.Style = MetroFramework.MetroColorStyle.Red;
            this.metroComboBoxESex.TabIndex = 1;
            this.metroComboBoxESex.UseSelectable = true;
            // 
            // metroLabelEUname
            // 
            this.metroLabelEUname.AutoSize = true;
            this.metroLabelEUname.Location = new System.Drawing.Point(1075, 111);
            this.metroLabelEUname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEUname.Name = "metroLabelEUname";
            this.metroLabelEUname.Size = new System.Drawing.Size(117, 20);
            this.metroLabelEUname.TabIndex = 22;
            this.metroLabelEUname.Text = "Felhasználónév *:";
            // 
            // metroLabelEPassword
            // 
            this.metroLabelEPassword.AutoSize = true;
            this.metroLabelEPassword.Location = new System.Drawing.Point(1075, 155);
            this.metroLabelEPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEPassword.Name = "metroLabelEPassword";
            this.metroLabelEPassword.Size = new System.Drawing.Size(59, 20);
            this.metroLabelEPassword.TabIndex = 23;
            this.metroLabelEPassword.Text = "Jelszó *:";
            // 
            // metroTextBoxEUserName
            // 
            this.metroTextBoxEUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(29)))), ((int)(((byte)(71)))));
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
            this.metroTextBoxEUserName.ForeColor = System.Drawing.Color.White;
            this.metroTextBoxEUserName.Lines = new string[0];
            this.metroTextBoxEUserName.Location = new System.Drawing.Point(1228, 106);
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
            this.metroTextBoxEUserName.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBoxEUserName.TabIndex = 24;
            this.metroTextBoxEUserName.UseCustomBackColor = true;
            this.metroTextBoxEUserName.UseCustomForeColor = true;
            this.metroTextBoxEUserName.UseSelectable = true;
            this.metroTextBoxEUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxEPassword
            // 
            this.metroTextBoxEPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(29)))), ((int)(((byte)(71)))));
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
            this.metroTextBoxEPassword.ForeColor = System.Drawing.Color.White;
            this.metroTextBoxEPassword.Lines = new string[0];
            this.metroTextBoxEPassword.Location = new System.Drawing.Point(1229, 151);
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
            this.metroTextBoxEPassword.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBoxEPassword.TabIndex = 25;
            this.metroTextBoxEPassword.UseCustomBackColor = true;
            this.metroTextBoxEPassword.UseCustomForeColor = true;
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
            this.metroGridEmployes.Location = new System.Drawing.Point(29, 364);
            this.metroGridEmployes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.metroGridEmployes.Size = new System.Drawing.Size(1468, 288);
            this.metroGridEmployes.Style = MetroFramework.MetroColorStyle.Red;
            this.metroGridEmployes.TabIndex = 26;
            this.metroGridEmployes.UseStyleColors = true;
            this.metroGridEmployes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridEmployes_CellClick);
            // 
            // metroButtonSearch
            // 
            this.metroButtonSearch.Location = new System.Drawing.Point(1299, 244);
            this.metroButtonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonSearch.Name = "metroButtonSearch";
            this.metroButtonSearch.Size = new System.Drawing.Size(199, 23);
            this.metroButtonSearch.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonSearch.TabIndex = 27;
            this.metroButtonSearch.Text = "Keresés";
            this.metroButtonSearch.UseCustomBackColor = true;
            this.metroButtonSearch.UseSelectable = true;
            this.metroButtonSearch.UseStyleColors = true;
            this.metroButtonSearch.Click += new System.EventHandler(this.metroButtonSearch_Click);
            // 
            // metroTextBoxAddress
            // 
            // 
            // 
            // 
            this.metroTextBoxAddress.CustomButton.Image = null;
            this.metroTextBoxAddress.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxAddress.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxAddress.CustomButton.Name = "";
            this.metroTextBoxAddress.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAddress.CustomButton.TabIndex = 1;
            this.metroTextBoxAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAddress.CustomButton.UseSelectable = true;
            this.metroTextBoxAddress.CustomButton.Visible = false;
            this.metroTextBoxAddress.Lines = new string[0];
            this.metroTextBoxAddress.Location = new System.Drawing.Point(739, 196);
            this.metroTextBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxAddress.MaxLength = 32767;
            this.metroTextBoxAddress.Name = "metroTextBoxAddress";
            this.metroTextBoxAddress.PasswordChar = '\0';
            this.metroTextBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAddress.SelectedText = "";
            this.metroTextBoxAddress.SelectionLength = 0;
            this.metroTextBoxAddress.SelectionStart = 0;
            this.metroTextBoxAddress.ShortcutsEnabled = true;
            this.metroTextBoxAddress.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxAddress.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBoxAddress.TabIndex = 28;
            this.metroTextBoxAddress.UseSelectable = true;
            this.metroTextBoxAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonCleanCells
            // 
            this.metroButtonCleanCells.Location = new System.Drawing.Point(1299, 206);
            this.metroButtonCleanCells.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonCleanCells.Name = "metroButtonCleanCells";
            this.metroButtonCleanCells.Size = new System.Drawing.Size(199, 23);
            this.metroButtonCleanCells.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonCleanCells.TabIndex = 29;
            this.metroButtonCleanCells.Text = "Cella ürítés";
            this.metroButtonCleanCells.UseCustomBackColor = true;
            this.metroButtonCleanCells.UseSelectable = true;
            this.metroButtonCleanCells.UseStyleColors = true;
            this.metroButtonCleanCells.Click += new System.EventHandler(this.metroButtonCleanCells_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(301, 672);
            this.metroButtonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(208, 28);
            this.metroButtonDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonDelete.TabIndex = 30;
            this.metroButtonDelete.Text = "Törlés";
            this.metroButtonDelete.UseCustomBackColor = true;
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.UseStyleColors = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroButtonModify
            // 
            this.metroButtonModify.Location = new System.Drawing.Point(565, 672);
            this.metroButtonModify.Margin = new System.Windows.Forms.Padding(4);
            this.metroButtonModify.Name = "metroButtonModify";
            this.metroButtonModify.Size = new System.Drawing.Size(208, 28);
            this.metroButtonModify.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonModify.TabIndex = 31;
            this.metroButtonModify.Text = "Módosítása";
            this.metroButtonModify.UseCustomBackColor = true;
            this.metroButtonModify.UseSelectable = true;
            this.metroButtonModify.UseStyleColors = true;
            this.metroButtonModify.Click += new System.EventHandler(this.metroButtonModify_Click);
            // 
            // metroDateTimeEBirth
            // 
            this.metroDateTimeEBirth.CustomFormat = "yyyy-MM-dd ";
            this.metroDateTimeEBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTimeEBirth.Location = new System.Drawing.Point(739, 103);
            this.metroDateTimeEBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroDateTimeEBirth.MaxDate = new System.DateTime(2020, 3, 3, 0, 0, 0, 0);
            this.metroDateTimeEBirth.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTimeEBirth.Name = "metroDateTimeEBirth";
            this.metroDateTimeEBirth.Size = new System.Drawing.Size(269, 30);
            this.metroDateTimeEBirth.Style = MetroFramework.MetroColorStyle.Red;
            this.metroDateTimeEBirth.TabIndex = 32;
            this.metroDateTimeEBirth.Value = new System.DateTime(2020, 1, 28, 0, 0, 0, 0);
            // 
            // errorProviderBPlace
            // 
            this.errorProviderBPlace.ContainerControl = this;
            this.errorProviderBPlace.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderBPlace.Icon")));
            // 
            // metroButtonTheSame
            // 
            this.metroButtonTheSame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroButtonTheSame.Location = new System.Drawing.Point(333, 246);
            this.metroButtonTheSame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonTheSame.Name = "metroButtonTheSame";
            this.metroButtonTheSame.Size = new System.Drawing.Size(44, 30);
            this.metroButtonTheSame.TabIndex = 33;
            this.metroButtonTheSame.Text = "U";
            this.metroButtonTheSame.UseCustomBackColor = true;
            this.metroButtonTheSame.UseSelectable = true;
            this.metroButtonTheSame.Click += new System.EventHandler(this.metroButtonTheSame_Click);
            // 
            // metroButtonNone
            // 
            this.metroButtonNone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroButtonNone.Location = new System.Drawing.Point(387, 246);
            this.metroButtonNone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonNone.Name = "metroButtonNone";
            this.metroButtonNone.Size = new System.Drawing.Size(44, 30);
            this.metroButtonNone.TabIndex = 34;
            this.metroButtonNone.Text = "X";
            this.metroButtonNone.UseCustomBackColor = true;
            this.metroButtonNone.UseSelectable = true;
            this.metroButtonNone.Click += new System.EventHandler(this.metroButtonNone_Click);
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
            // errorProviderLocation
            // 
            this.errorProviderLocation.ContainerControl = this;
            this.errorProviderLocation.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderLocation.Icon")));
            // 
            // errorProviderJob
            // 
            this.errorProviderJob.ContainerControl = this;
            this.errorProviderJob.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderJob.Icon")));
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(444, 314);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(507, 17);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "* ezzel a jelel megjelölt cellákat a gép autómatikusan genrálja, nem tud bele írn" +
    "i a cellába.";
            // 
            // errorProviderMaidenName
            // 
            this.errorProviderMaidenName.ContainerControl = this;
            // 
            // errorProviderBirthdayDate
            // 
            this.errorProviderBirthdayDate.ContainerControl = this;
            // 
            // WorkersRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 729);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonNone);
            this.Controls.Add(this.metroButtonTheSame);
            this.Controls.Add(this.metroDateTimeEBirth);
            this.Controls.Add(this.metroButtonModify);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonCleanCells);
            this.Controls.Add(this.metroTextBoxAddress);
            this.Controls.Add(this.metroButtonSearch);
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
            this.Controls.Add(this.metroLabelELocation);
            this.Controls.Add(this.metroTextBoxBPlace);
            this.Controls.Add(this.metroLabelBPlace);
            this.Controls.Add(this.metroLabelEDate);
            this.Controls.Add(this.metroLabelEJobtype);
            this.Controls.Add(this.metroTextBoxEID);
            this.Controls.Add(this.metroComboBoxEjobtype);
            this.Controls.Add(this.metroLabelUserId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkersRegistration";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Dolgozó regisztrálása:";
            this.Load += new System.EventHandler(this.WorkersRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEmployes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMaidenName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBirthdayDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelUserId;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEjobtype;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEID;
        private MetroFramework.Controls.MetroLabel metroLabelEJobtype;
        private MetroFramework.Controls.MetroLabel metroLabelEDate;
        private MetroFramework.Controls.MetroLabel metroLabelELocation;
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
        private MetroFramework.Controls.MetroButton metroButtonSearch;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAddress;
        private MetroFramework.Controls.MetroButton metroButtonCleanCells;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroButton metroButtonModify;
        private MetroFramework.Controls.MetroDateTime metroDateTimeEBirth;
        private System.Windows.Forms.ErrorProvider errorProviderBPlace;
        private MetroFramework.Controls.MetroButton metroButtonNone;
        private MetroFramework.Controls.MetroButton metroButtonTheSame;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderSex;
        private System.Windows.Forms.ErrorProvider errorProviderLocation;
        private System.Windows.Forms.ErrorProvider errorProviderJob;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ErrorProvider errorProviderMaidenName;
        private System.Windows.Forms.ErrorProvider errorProviderBirthdayDate;
    }
}