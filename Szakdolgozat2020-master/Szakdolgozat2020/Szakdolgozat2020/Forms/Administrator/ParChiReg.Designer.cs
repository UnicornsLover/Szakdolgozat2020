namespace Szakdolgozat2020.Forms.Administrator
{
    partial class ParChiReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParChiReg));
            this.metroComboBoxChildrenName = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxParenttName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelcname = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPName = new MetroFramework.Controls.MetroLabel();
            this.metroGridPC = new MetroFramework.Controls.MetroGrid();
            this.metroButtonSearch = new MetroFramework.Controls.MetroButton();
            this.metroButtonClearCells = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonModify = new MetroFramework.Controls.MetroButton();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelID = new MetroFramework.Controls.MetroLabel();
            this.errorProviderChildren = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderParent = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParent)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBoxChildrenName
            // 
            this.metroComboBoxChildrenName.FormattingEnabled = true;
            this.metroComboBoxChildrenName.ItemHeight = 24;
            this.metroComboBoxChildrenName.Items.AddRange(new object[] {
            "nő",
            "férfi"});
            this.metroComboBoxChildrenName.Location = new System.Drawing.Point(517, 202);
            this.metroComboBoxChildrenName.Name = "metroComboBoxChildrenName";
            this.metroComboBoxChildrenName.Size = new System.Drawing.Size(391, 30);
            this.metroComboBoxChildrenName.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBoxChildrenName.TabIndex = 18;
            this.metroComboBoxChildrenName.UseSelectable = true;
            // 
            // metroComboBoxParenttName
            // 
            this.metroComboBoxParenttName.FormattingEnabled = true;
            this.metroComboBoxParenttName.ItemHeight = 24;
            this.metroComboBoxParenttName.Items.AddRange(new object[] {
            "nő",
            "férfi"});
            this.metroComboBoxParenttName.Location = new System.Drawing.Point(61, 202);
            this.metroComboBoxParenttName.Name = "metroComboBoxParenttName";
            this.metroComboBoxParenttName.Size = new System.Drawing.Size(391, 30);
            this.metroComboBoxParenttName.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBoxParenttName.TabIndex = 19;
            this.metroComboBoxParenttName.UseSelectable = true;
            // 
            // metroLabelcname
            // 
            this.metroLabelcname.AutoSize = true;
            this.metroLabelcname.Location = new System.Drawing.Point(517, 165);
            this.metroLabelcname.Name = "metroLabelcname";
            this.metroLabelcname.Size = new System.Drawing.Size(92, 20);
            this.metroLabelcname.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelcname.TabIndex = 20;
            this.metroLabelcname.Text = "Gyerek neve:";
            // 
            // metroLabelPName
            // 
            this.metroLabelPName.AutoSize = true;
            this.metroLabelPName.Location = new System.Drawing.Point(61, 165);
            this.metroLabelPName.Name = "metroLabelPName";
            this.metroLabelPName.Size = new System.Drawing.Size(80, 20);
            this.metroLabelPName.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelPName.TabIndex = 21;
            this.metroLabelPName.Text = "Szülő neve:";
            // 
            // metroGridPC
            // 
            this.metroGridPC.AllowUserToResizeRows = false;
            this.metroGridPC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridPC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridPC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridPC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridPC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridPC.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridPC.EnableHeadersVisualStyles = false;
            this.metroGridPC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridPC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridPC.Location = new System.Drawing.Point(263, 284);
            this.metroGridPC.Name = "metroGridPC";
            this.metroGridPC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridPC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridPC.RowHeadersWidth = 51;
            this.metroGridPC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridPC.RowTemplate.Height = 24;
            this.metroGridPC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridPC.Size = new System.Drawing.Size(460, 244);
            this.metroGridPC.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGridPC.TabIndex = 22;
            this.metroGridPC.SelectionChanged += new System.EventHandler(this.metroGridPC_SelectionChanged);
            // 
            // metroButtonSearch
            // 
            this.metroButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonSearch.Location = new System.Drawing.Point(622, 250);
            this.metroButtonSearch.Name = "metroButtonSearch";
            this.metroButtonSearch.Size = new System.Drawing.Size(208, 28);
            this.metroButtonSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonSearch.TabIndex = 28;
            this.metroButtonSearch.Text = "Keresés";
            this.metroButtonSearch.UseCustomBackColor = true;
            this.metroButtonSearch.UseCustomForeColor = true;
            this.metroButtonSearch.UseSelectable = true;
            this.metroButtonSearch.Click += new System.EventHandler(this.metroButtonSearch_Click);
            // 
            // metroButtonClearCells
            // 
            this.metroButtonClearCells.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonClearCells.Location = new System.Drawing.Point(898, 250);
            this.metroButtonClearCells.Name = "metroButtonClearCells";
            this.metroButtonClearCells.Size = new System.Drawing.Size(208, 28);
            this.metroButtonClearCells.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonClearCells.TabIndex = 27;
            this.metroButtonClearCells.Text = "Cella üritése";
            this.metroButtonClearCells.UseCustomBackColor = true;
            this.metroButtonClearCells.UseCustomForeColor = true;
            this.metroButtonClearCells.UseSelectable = true;
            this.metroButtonClearCells.Click += new System.EventHandler(this.metroButtonClearCells_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonDelete.Location = new System.Drawing.Point(556, 580);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(208, 28);
            this.metroButtonDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonDelete.TabIndex = 31;
            this.metroButtonDelete.Text = "Törlés";
            this.metroButtonDelete.UseCustomBackColor = true;
            this.metroButtonDelete.UseCustomForeColor = true;
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroButtonModify
            // 
            this.metroButtonModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonModify.Location = new System.Drawing.Point(288, 580);
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
            this.metroButtonAdd.Location = new System.Drawing.Point(20, 580);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(208, 28);
            this.metroButtonAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonAdd.TabIndex = 29;
            this.metroButtonAdd.Text = "Felvétel";
            this.metroButtonAdd.UseCustomBackColor = true;
            this.metroButtonAdd.UseCustomForeColor = true;
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
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
            this.metroTextBoxID.Location = new System.Drawing.Point(61, 118);
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
            this.metroTextBoxID.TabIndex = 37;
            this.metroTextBoxID.UseCustomBackColor = true;
            this.metroTextBoxID.UseCustomForeColor = true;
            this.metroTextBoxID.UseSelectable = true;
            this.metroTextBoxID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelID
            // 
            this.metroLabelID.AutoSize = true;
            this.metroLabelID.Location = new System.Drawing.Point(61, 82);
            this.metroLabelID.Name = "metroLabelID";
            this.metroLabelID.Size = new System.Drawing.Size(73, 20);
            this.metroLabelID.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelID.TabIndex = 38;
            this.metroLabelID.Text = "Azonosító:";
            // 
            // errorProviderChildren
            // 
            this.errorProviderChildren.ContainerControl = this;
            this.errorProviderChildren.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderChildren.Icon")));
            // 
            // errorProviderParent
            // 
            this.errorProviderParent.ContainerControl = this;
            this.errorProviderParent.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderParent.Icon")));
            // 
            // ParChiReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 631);
            this.Controls.Add(this.metroLabelID);
            this.Controls.Add(this.metroTextBoxID);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonModify);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroButtonSearch);
            this.Controls.Add(this.metroButtonClearCells);
            this.Controls.Add(this.metroGridPC);
            this.Controls.Add(this.metroLabelPName);
            this.Controls.Add(this.metroLabelcname);
            this.Controls.Add(this.metroComboBoxParenttName);
            this.Controls.Add(this.metroComboBoxChildrenName);
            this.Name = "ParChiReg";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Szölő-gyerek:";
            this.Load += new System.EventHandler(this.ParChiReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBoxChildrenName;
        private MetroFramework.Controls.MetroComboBox metroComboBoxParenttName;
        private MetroFramework.Controls.MetroLabel metroLabelcname;
        private MetroFramework.Controls.MetroLabel metroLabelPName;
        private MetroFramework.Controls.MetroGrid metroGridPC;
        private MetroFramework.Controls.MetroButton metroButtonSearch;
        private MetroFramework.Controls.MetroButton metroButtonClearCells;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroButton metroButtonModify;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroTextBox metroTextBoxID;
        private MetroFramework.Controls.MetroLabel metroLabelID;
        private System.Windows.Forms.ErrorProvider errorProviderChildren;
        private System.Windows.Forms.ErrorProvider errorProviderParent;
    }
}