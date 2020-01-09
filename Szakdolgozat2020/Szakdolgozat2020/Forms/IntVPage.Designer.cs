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
            this.metroTileReg = new MetroFramework.Controls.MetroTile();
            this.metroLabelWelcome = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLoggedIn = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTileReg
            // 
            this.metroTileReg.ActiveControl = null;
            this.metroTileReg.AllowDrop = true;
            this.metroTileReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTileReg.Location = new System.Drawing.Point(32, 115);
            this.metroTileReg.Name = "metroTileReg";
            this.metroTileReg.Size = new System.Drawing.Size(153, 100);
            this.metroTileReg.TabIndex = 0;
            this.metroTileReg.Text = "Dolgozó regisztrációja";
            this.metroTileReg.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileReg.UseCustomBackColor = true;
            this.metroTileReg.UseSelectable = true;
            // 
            // metroLabelWelcome
            // 
            this.metroLabelWelcome.AutoSize = true;
            this.metroLabelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabelWelcome.Location = new System.Drawing.Point(487, 29);
            this.metroLabelWelcome.Name = "metroLabelWelcome";
            this.metroLabelWelcome.Size = new System.Drawing.Size(160, 19);
            this.metroLabelWelcome.TabIndex = 1;
            this.metroLabelWelcome.Text = "Üdvözölek a rendszerben:";
            // 
            // metroLabelLoggedIn
            // 
            this.metroLabelLoggedIn.AutoSize = true;
            this.metroLabelLoggedIn.ForeColor = System.Drawing.Color.Red;
            this.metroLabelLoggedIn.Location = new System.Drawing.Point(643, 29);
            this.metroLabelLoggedIn.Name = "metroLabelLoggedIn";
            this.metroLabelLoggedIn.Size = new System.Drawing.Size(0, 0);
            this.metroLabelLoggedIn.TabIndex = 2;
            // 
            // IntVPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabelLoggedIn);
            this.Controls.Add(this.metroLabelWelcome);
            this.Controls.Add(this.metroTileReg);
            this.Name = "IntVPage";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Intézmányvezető";
            this.Load += new System.EventHandler(this.IntVPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileReg;
        private MetroFramework.Controls.MetroLabel metroLabelWelcome;
        private MetroFramework.Controls.MetroLabel metroLabelLoggedIn;
    }
}