namespace Szakdolgozat2020.Forms
{
    partial class Nevelo
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
            this.metroLabelWelcome = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLoggedName = new MetroFramework.Controls.MetroLabel();
            this.metroTileChildrenReg = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabelWelcome
            // 
            this.metroLabelWelcome.AutoSize = true;
            this.metroLabelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabelWelcome.Location = new System.Drawing.Point(667, 30);
            this.metroLabelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelWelcome.Name = "metroLabelWelcome";
            this.metroLabelWelcome.Size = new System.Drawing.Size(172, 20);
            this.metroLabelWelcome.TabIndex = 5;
            this.metroLabelWelcome.Text = "Üdvözölek a rendszerben:";
            // 
            // metroLabelLoggedName
            // 
            this.metroLabelLoggedName.AutoSize = true;
            this.metroLabelLoggedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroLabelLoggedName.Location = new System.Drawing.Point(875, 30);
            this.metroLabelLoggedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelLoggedName.Name = "metroLabelLoggedName";
            this.metroLabelLoggedName.Size = new System.Drawing.Size(0, 0);
            this.metroLabelLoggedName.TabIndex = 7;
            this.metroLabelLoggedName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabelLoggedName.UseCustomForeColor = true;
            // 
            // metroTileChildrenReg
            // 
            this.metroTileChildrenReg.ActiveControl = null;
            this.metroTileChildrenReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroTileChildrenReg.Location = new System.Drawing.Point(50, 121);
            this.metroTileChildrenReg.Name = "metroTileChildrenReg";
            this.metroTileChildrenReg.Size = new System.Drawing.Size(204, 123);
            this.metroTileChildrenReg.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileChildrenReg.TabIndex = 8;
            this.metroTileChildrenReg.Text = "Gyermek regisztráció";
            this.metroTileChildrenReg.UseCustomBackColor = true;
            this.metroTileChildrenReg.UseSelectable = true;
            this.metroTileChildrenReg.Click += new System.EventHandler(this.metroTileChildrenReg_Click);
            // 
            // Nevelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 559);
            this.Controls.Add(this.metroTileChildrenReg);
            this.Controls.Add(this.metroLabelLoggedName);
            this.Controls.Add(this.metroLabelWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Nevelo";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Nevelő:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabelWelcome;
        private MetroFramework.Controls.MetroLabel metroLabelLoggedName;
        private MetroFramework.Controls.MetroTile metroTileChildrenReg;
    }
}