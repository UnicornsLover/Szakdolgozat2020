namespace Szakdolgozat2020.Forms.Foster
{
    partial class HomePageNevelo
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
            this.metroTileChildrenReg = new MetroFramework.Controls.MetroTile();
            this.metroLabelLoggedName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelWelcome = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLogOut = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTileChildrenReg
            // 
            this.metroTileChildrenReg.ActiveControl = null;
            this.metroTileChildrenReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroTileChildrenReg.Location = new System.Drawing.Point(41, 106);
            this.metroTileChildrenReg.Name = "metroTileChildrenReg";
            this.metroTileChildrenReg.Size = new System.Drawing.Size(191, 123);
            this.metroTileChildrenReg.TabIndex = 0;
            this.metroTileChildrenReg.Text = "Gyermek regisztráció";
            this.metroTileChildrenReg.UseCustomBackColor = true;
            this.metroTileChildrenReg.UseSelectable = true;
            this.metroTileChildrenReg.Click += new System.EventHandler(this.metroTileChildrenReg_Click);
            // 
            // metroLabelLoggedName
            // 
            this.metroLabelLoggedName.AutoSize = true;
            this.metroLabelLoggedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.metroLabelLoggedName.Location = new System.Drawing.Point(881, 51);
            this.metroLabelLoggedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelLoggedName.Name = "metroLabelLoggedName";
            this.metroLabelLoggedName.Size = new System.Drawing.Size(0, 0);
            this.metroLabelLoggedName.TabIndex = 6;
            this.metroLabelLoggedName.UseCustomForeColor = true;
            // 
            // metroLabelWelcome
            // 
            this.metroLabelWelcome.AutoSize = true;
            this.metroLabelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabelWelcome.Location = new System.Drawing.Point(673, 51);
            this.metroLabelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelWelcome.Name = "metroLabelWelcome";
            this.metroLabelWelcome.Size = new System.Drawing.Size(172, 20);
            this.metroLabelWelcome.TabIndex = 5;
            this.metroLabelWelcome.Text = "Üdvözölek a rendszerben:";
            // 
            // metroButtonLogOut
            // 
            this.metroButtonLogOut.Location = new System.Drawing.Point(863, 497);
            this.metroButtonLogOut.Name = "metroButtonLogOut";
            this.metroButtonLogOut.Size = new System.Drawing.Size(156, 28);
            this.metroButtonLogOut.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonLogOut.TabIndex = 7;
            this.metroButtonLogOut.Text = "Kijelentkezés";
            this.metroButtonLogOut.UseCustomBackColor = true;
            this.metroButtonLogOut.UseSelectable = true;
            this.metroButtonLogOut.UseStyleColors = true;
            // 
            // HomePageNevelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.metroButtonLogOut);
            this.Controls.Add(this.metroLabelLoggedName);
            this.Controls.Add(this.metroLabelWelcome);
            this.Controls.Add(this.metroTileChildrenReg);
            this.Name = "HomePageNevelo";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Nevelő:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileChildrenReg;
        private MetroFramework.Controls.MetroLabel metroLabelLoggedName;
        private MetroFramework.Controls.MetroLabel metroLabelWelcome;
        private MetroFramework.Controls.MetroButton metroButtonLogOut;
    }
}