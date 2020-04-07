namespace Szakdolgozat2020.Forms.Foster
{
    partial class EventChildForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventChildForm));
            this.metroComboBoxChildrenName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelChName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEvent = new MetroFramework.Controls.MetroLabel();
            this.metrocomboboxEvent = new MetroFramework.Controls.MetroComboBox();
            this.metroGridEventChildren = new MetroFramework.Controls.MetroGrid();
            this.metroTextBoxId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelId = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeeventDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabelDate = new MetroFramework.Controls.MetroLabel();
            this.metroButtonClearCells = new MetroFramework.Controls.MetroButton();
            this.metroButtonSearch = new MetroFramework.Controls.MetroButton();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonModify = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.errorProviderChildrenName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEventName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEventChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChildrenName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEventName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBoxChildrenName
            // 
            this.metroComboBoxChildrenName.FormattingEnabled = true;
            this.metroComboBoxChildrenName.ItemHeight = 24;
            this.metroComboBoxChildrenName.Location = new System.Drawing.Point(23, 206);
            this.metroComboBoxChildrenName.Name = "metroComboBoxChildrenName";
            this.metroComboBoxChildrenName.Size = new System.Drawing.Size(527, 30);
            this.metroComboBoxChildrenName.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBoxChildrenName.TabIndex = 0;
            this.metroComboBoxChildrenName.UseSelectable = true;
            // 
            // metroLabelChName
            // 
            this.metroLabelChName.AutoSize = true;
            this.metroLabelChName.Location = new System.Drawing.Point(24, 170);
            this.metroLabelChName.Name = "metroLabelChName";
            this.metroLabelChName.Size = new System.Drawing.Size(104, 20);
            this.metroLabelChName.TabIndex = 1;
            this.metroLabelChName.Text = "Gyermek neve:";
            // 
            // metroLabelEvent
            // 
            this.metroLabelEvent.AutoSize = true;
            this.metroLabelEvent.Location = new System.Drawing.Point(606, 170);
            this.metroLabelEvent.Name = "metroLabelEvent";
            this.metroLabelEvent.Size = new System.Drawing.Size(104, 20);
            this.metroLabelEvent.TabIndex = 3;
            this.metroLabelEvent.Text = "Esemény neve:";
            // 
            // metrocomboboxEvent
            // 
            this.metrocomboboxEvent.FormattingEnabled = true;
            this.metrocomboboxEvent.ItemHeight = 24;
            this.metrocomboboxEvent.Location = new System.Drawing.Point(605, 206);
            this.metrocomboboxEvent.Name = "metrocomboboxEvent";
            this.metrocomboboxEvent.Size = new System.Drawing.Size(523, 30);
            this.metrocomboboxEvent.Style = MetroFramework.MetroColorStyle.Silver;
            this.metrocomboboxEvent.TabIndex = 2;
            this.metrocomboboxEvent.UseSelectable = true;
            // 
            // metroGridEventChildren
            // 
            this.metroGridEventChildren.AllowUserToResizeRows = false;
            this.metroGridEventChildren.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEventChildren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridEventChildren.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridEventChildren.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEventChildren.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridEventChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridEventChildren.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridEventChildren.EnableHeadersVisualStyles = false;
            this.metroGridEventChildren.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridEventChildren.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEventChildren.Location = new System.Drawing.Point(257, 319);
            this.metroGridEventChildren.Name = "metroGridEventChildren";
            this.metroGridEventChildren.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEventChildren.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridEventChildren.RowHeadersWidth = 51;
            this.metroGridEventChildren.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridEventChildren.RowTemplate.Height = 24;
            this.metroGridEventChildren.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridEventChildren.Size = new System.Drawing.Size(811, 273);
            this.metroGridEventChildren.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGridEventChildren.TabIndex = 4;
            this.metroGridEventChildren.SelectionChanged += new System.EventHandler(this.metroGridEventChildren_SelectionChanged);
            // 
            // metroTextBoxId
            // 
            this.metroTextBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            // 
            // 
            // 
            this.metroTextBoxId.CustomButton.Image = null;
            this.metroTextBoxId.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.metroTextBoxId.CustomButton.Name = "";
            this.metroTextBoxId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxId.CustomButton.TabIndex = 1;
            this.metroTextBoxId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxId.CustomButton.UseSelectable = true;
            this.metroTextBoxId.CustomButton.Visible = false;
            this.metroTextBoxId.ForeColor = System.Drawing.Color.White;
            this.metroTextBoxId.Lines = new string[0];
            this.metroTextBoxId.Location = new System.Drawing.Point(24, 128);
            this.metroTextBoxId.MaxLength = 32767;
            this.metroTextBoxId.Name = "metroTextBoxId";
            this.metroTextBoxId.PasswordChar = '\0';
            this.metroTextBoxId.ReadOnly = true;
            this.metroTextBoxId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxId.SelectedText = "";
            this.metroTextBoxId.SelectionLength = 0;
            this.metroTextBoxId.SelectionStart = 0;
            this.metroTextBoxId.ShortcutsEnabled = true;
            this.metroTextBoxId.Size = new System.Drawing.Size(269, 28);
            this.metroTextBoxId.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTextBoxId.TabIndex = 21;
            this.metroTextBoxId.UseCustomBackColor = true;
            this.metroTextBoxId.UseCustomForeColor = true;
            this.metroTextBoxId.UseSelectable = true;
            this.metroTextBoxId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelId
            // 
            this.metroLabelId.AutoSize = true;
            this.metroLabelId.ForeColor = System.Drawing.Color.White;
            this.metroLabelId.Location = new System.Drawing.Point(23, 90);
            this.metroLabelId.Name = "metroLabelId";
            this.metroLabelId.Size = new System.Drawing.Size(73, 20);
            this.metroLabelId.TabIndex = 22;
            this.metroLabelId.Text = "Azonosító:";
            // 
            // metroDateTimeeventDate
            // 
            this.metroDateTimeeventDate.CustomFormat = "yyyy-MM-dd";
            this.metroDateTimeeventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTimeeventDate.Location = new System.Drawing.Point(606, 126);
            this.metroDateTimeeventDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTimeeventDate.Name = "metroDateTimeeventDate";
            this.metroDateTimeeventDate.Size = new System.Drawing.Size(254, 30);
            this.metroDateTimeeventDate.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroDateTimeeventDate.TabIndex = 23;
            // 
            // metroLabelDate
            // 
            this.metroLabelDate.AutoSize = true;
            this.metroLabelDate.ForeColor = System.Drawing.Color.White;
            this.metroLabelDate.Location = new System.Drawing.Point(606, 90);
            this.metroLabelDate.Name = "metroLabelDate";
            this.metroLabelDate.Size = new System.Drawing.Size(103, 20);
            this.metroLabelDate.TabIndex = 25;
            this.metroLabelDate.Text = "Esemény ideje:";
            // 
            // metroButtonClearCells
            // 
            this.metroButtonClearCells.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonClearCells.Location = new System.Drawing.Point(1007, 126);
            this.metroButtonClearCells.Name = "metroButtonClearCells";
            this.metroButtonClearCells.Size = new System.Drawing.Size(145, 28);
            this.metroButtonClearCells.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonClearCells.TabIndex = 32;
            this.metroButtonClearCells.Text = "Cella ürítés";
            this.metroButtonClearCells.UseCustomBackColor = true;
            this.metroButtonClearCells.UseSelectable = true;
            this.metroButtonClearCells.Click += new System.EventHandler(this.metroButtonClearCells_Click);
            // 
            // metroButtonSearch
            // 
            this.metroButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonSearch.Location = new System.Drawing.Point(1007, 162);
            this.metroButtonSearch.Name = "metroButtonSearch";
            this.metroButtonSearch.Size = new System.Drawing.Size(145, 28);
            this.metroButtonSearch.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonSearch.TabIndex = 31;
            this.metroButtonSearch.Text = "Keresés";
            this.metroButtonSearch.UseCustomBackColor = true;
            this.metroButtonSearch.UseSelectable = true;
            this.metroButtonSearch.Click += new System.EventHandler(this.metroButtonSearch_Click);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonAdd.Location = new System.Drawing.Point(28, 610);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(208, 28);
            this.metroButtonAdd.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonAdd.TabIndex = 37;
            this.metroButtonAdd.Text = "Felvétel";
            this.metroButtonAdd.UseCustomBackColor = true;
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroButtonModify
            // 
            this.metroButtonModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonModify.Location = new System.Drawing.Point(291, 610);
            this.metroButtonModify.Name = "metroButtonModify";
            this.metroButtonModify.Size = new System.Drawing.Size(208, 28);
            this.metroButtonModify.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonModify.TabIndex = 36;
            this.metroButtonModify.Text = "Módosítás";
            this.metroButtonModify.UseCustomBackColor = true;
            this.metroButtonModify.UseSelectable = true;
            this.metroButtonModify.Click += new System.EventHandler(this.metroButtonModify_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroButtonDelete.Location = new System.Drawing.Point(552, 610);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(208, 28);
            this.metroButtonDelete.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonDelete.TabIndex = 35;
            this.metroButtonDelete.Text = "Törlés";
            this.metroButtonDelete.UseCustomBackColor = true;
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // errorProviderChildrenName
            // 
            this.errorProviderChildrenName.ContainerControl = this;
            this.errorProviderChildrenName.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderChildrenName.Icon")));
            // 
            // errorProviderEventName
            // 
            this.errorProviderEventName.ContainerControl = this;
            this.errorProviderEventName.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderEventName.Icon")));
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            this.errorProviderDate.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderDate.Icon")));
            // 
            // EventChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 661);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroButtonModify);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonClearCells);
            this.Controls.Add(this.metroButtonSearch);
            this.Controls.Add(this.metroLabelDate);
            this.Controls.Add(this.metroDateTimeeventDate);
            this.Controls.Add(this.metroLabelId);
            this.Controls.Add(this.metroTextBoxId);
            this.Controls.Add(this.metroGridEventChildren);
            this.Controls.Add(this.metroLabelEvent);
            this.Controls.Add(this.metrocomboboxEvent);
            this.Controls.Add(this.metroLabelChName);
            this.Controls.Add(this.metroComboBoxChildrenName);
            this.Name = "EventChildForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Gyerek-esemény kapcsolás:";
            this.Load += new System.EventHandler(this.EventChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEventChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChildrenName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEventName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBoxChildrenName;
        private MetroFramework.Controls.MetroLabel metroLabelChName;
        private MetroFramework.Controls.MetroLabel metroLabelEvent;
        private MetroFramework.Controls.MetroComboBox metrocomboboxEvent;
        private MetroFramework.Controls.MetroGrid metroGridEventChildren;
        private MetroFramework.Controls.MetroTextBox metroTextBoxId;
        private MetroFramework.Controls.MetroLabel metroLabelId;
        private MetroFramework.Controls.MetroDateTime metroDateTimeeventDate;
        private MetroFramework.Controls.MetroLabel metroLabelDate;
        private MetroFramework.Controls.MetroButton metroButtonClearCells;
        private MetroFramework.Controls.MetroButton metroButtonSearch;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroButton metroButtonModify;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private System.Windows.Forms.ErrorProvider errorProviderChildrenName;
        private System.Windows.Forms.ErrorProvider errorProviderEventName;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
    }
}