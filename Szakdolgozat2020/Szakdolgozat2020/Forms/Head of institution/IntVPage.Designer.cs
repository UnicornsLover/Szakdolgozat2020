namespace Szakdolgozat2020.Forms
{
    partial class IntVPage
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
            this.metroButtonLogOut = new MetroFramework.Controls.MetroButton();
            this.metroTileChildrenReg = new MetroFramework.Controls.MetroTile();
            this.metroTileWorkerReg = new MetroFramework.Controls.MetroTile();
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
            this.metroLabelWelcome.TabIndex = 1;
            this.metroLabelWelcome.Text = "Üdvözölek a rendszerben:";
            // 
            // metroLabelLoggedName
            // 
            this.metroLabelLoggedName.AutoSize = true;
            this.metroLabelLoggedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabelLoggedName.Location = new System.Drawing.Point(875, 30);
            this.metroLabelLoggedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelLoggedName.Name = "metroLabelLoggedName";
            this.metroLabelLoggedName.Size = new System.Drawing.Size(0, 0);
            this.metroLabelLoggedName.TabIndex = 4;
            this.metroLabelLoggedName.UseCustomForeColor = true;
            // 
            // metroButtonLogOut
            // 
            this.metroButtonLogOut.Location = new System.Drawing.Point(863, 497);
            this.metroButtonLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButtonLogOut.Name = "metroButtonLogOut";
            this.metroButtonLogOut.Size = new System.Drawing.Size(156, 28);
            this.metroButtonLogOut.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonLogOut.TabIndex = 5;
            this.metroButtonLogOut.Text = "Kijelentkezés";
            this.metroButtonLogOut.UseCustomBackColor = true;
            this.metroButtonLogOut.UseSelectable = true;
            this.metroButtonLogOut.UseStyleColors = true;
            this.metroButtonLogOut.Click += new System.EventHandler(this.metroButtonLogOut_Click);
            // 
            // metroTileChildrenReg
            // 
            this.metroTileChildrenReg.ActiveControl = null;
            this.metroTileChildrenReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroTileChildrenReg.Location = new System.Drawing.Point(284, 142);
            this.metroTileChildrenReg.Name = "metroTileChildrenReg";
            this.metroTileChildrenReg.Size = new System.Drawing.Size(191, 123);
            this.metroTileChildrenReg.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileChildrenReg.TabIndex = 6;
            this.metroTileChildrenReg.Text = "Gyermek regisztráció";
            this.metroTileChildrenReg.UseCustomBackColor = true;
            this.metroTileChildrenReg.UseSelectable = true;
            this.metroTileChildrenReg.Click += new System.EventHandler(this.metroTileChildrenReg_Click);
            // 
            // metroTileWorkerReg
            // 
            this.metroTileWorkerReg.ActiveControl = null;
            this.metroTileWorkerReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(37)))));
            this.metroTileWorkerReg.Location = new System.Drawing.Point(39, 142);
            this.metroTileWorkerReg.Name = "metroTileWorkerReg";
            this.metroTileWorkerReg.Size = new System.Drawing.Size(191, 123);
            this.metroTileWorkerReg.TabIndex = 7;
            this.metroTileWorkerReg.Text = "Dolgozók felvétele";
            this.metroTileWorkerReg.UseCustomBackColor = true;
            this.metroTileWorkerReg.UseSelectable = true;
            this.metroTileWorkerReg.Click += new System.EventHandler(this.metroTileWorkerReg_Click);
            // 
            // IntVPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.metroTileWorkerReg);
            this.Controls.Add(this.metroTileChildrenReg);
            this.Controls.Add(this.metroButtonLogOut);
            this.Controls.Add(this.metroLabelLoggedName);
            this.Controls.Add(this.metroLabelWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IntVPage";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Intézményvezető";
            this.Load += new System.EventHandler(this.IntVPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabelWelcome;
        private MetroFramework.Controls.MetroLabel metroLabelLoggedName;
        private MetroFramework.Controls.MetroButton metroButtonLogOut;
        private MetroFramework.Controls.MetroTile metroTileChildrenReg;
        private MetroFramework.Controls.MetroTile metroTileWorkerReg;
    }
}