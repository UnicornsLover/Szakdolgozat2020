namespace Szakdolgozat2020.Forms.Foster
{
    partial class Fosterhomepage
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
            this.metroLabelLoggedName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelWelcome = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLogOut = new MetroFramework.Controls.MetroButton();
            this.metroTileEdu = new MetroFramework.Controls.MetroTile();
            this.metroTileIntAdd = new MetroFramework.Controls.MetroTile();
            this.metroTileEvents = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabelLoggedName
            // 
            this.metroLabelLoggedName.AutoSize = true;
            this.metroLabelLoggedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.metroLabelLoggedName.Location = new System.Drawing.Point(875, 34);
            this.metroLabelLoggedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelLoggedName.Name = "metroLabelLoggedName";
            this.metroLabelLoggedName.Size = new System.Drawing.Size(0, 0);
            this.metroLabelLoggedName.TabIndex = 8;
            this.metroLabelLoggedName.UseCustomForeColor = true;
            // 
            // metroLabelWelcome
            // 
            this.metroLabelWelcome.AutoSize = true;
            this.metroLabelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabelWelcome.Location = new System.Drawing.Point(667, 34);
            this.metroLabelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelWelcome.Name = "metroLabelWelcome";
            this.metroLabelWelcome.Size = new System.Drawing.Size(172, 20);
            this.metroLabelWelcome.TabIndex = 7;
            this.metroLabelWelcome.Text = "Üdvözölek a rendszerben:";
            // 
            // metroButtonLogOut
            // 
            this.metroButtonLogOut.Location = new System.Drawing.Point(890, 495);
            this.metroButtonLogOut.Name = "metroButtonLogOut";
            this.metroButtonLogOut.Size = new System.Drawing.Size(156, 28);
            this.metroButtonLogOut.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButtonLogOut.TabIndex = 9;
            this.metroButtonLogOut.Text = "Kijelentkezés";
            this.metroButtonLogOut.UseCustomBackColor = true;
            this.metroButtonLogOut.UseSelectable = true;
            this.metroButtonLogOut.UseStyleColors = true;
            this.metroButtonLogOut.Click += new System.EventHandler(this.metroButtonLogOut_Click);
            // 
            // metroTileEdu
            // 
            this.metroTileEdu.ActiveControl = null;
            this.metroTileEdu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.metroTileEdu.Location = new System.Drawing.Point(303, 93);
            this.metroTileEdu.Name = "metroTileEdu";
            this.metroTileEdu.Size = new System.Drawing.Size(191, 123);
            this.metroTileEdu.TabIndex = 10;
            this.metroTileEdu.Text = "Oktatás - Gyerek";
            this.metroTileEdu.UseCustomBackColor = true;
            this.metroTileEdu.UseSelectable = true;
            this.metroTileEdu.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTileIntAdd
            // 
            this.metroTileIntAdd.ActiveControl = null;
            this.metroTileIntAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.metroTileIntAdd.Location = new System.Drawing.Point(55, 93);
            this.metroTileIntAdd.Name = "metroTileIntAdd";
            this.metroTileIntAdd.Size = new System.Drawing.Size(191, 123);
            this.metroTileIntAdd.TabIndex = 11;
            this.metroTileIntAdd.Text = "Intézmény felvétele:";
            this.metroTileIntAdd.UseCustomBackColor = true;
            this.metroTileIntAdd.UseSelectable = true;
            this.metroTileIntAdd.Click += new System.EventHandler(this.metroTileIntAdd_Click);
            // 
            // metroTileEvents
            // 
            this.metroTileEvents.ActiveControl = null;
            this.metroTileEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.metroTileEvents.ForeColor = System.Drawing.Color.White;
            this.metroTileEvents.Location = new System.Drawing.Point(551, 93);
            this.metroTileEvents.Name = "metroTileEvents";
            this.metroTileEvents.Size = new System.Drawing.Size(191, 123);
            this.metroTileEvents.TabIndex = 12;
            this.metroTileEvents.Text = "Esemény felvétele";
            this.metroTileEvents.UseCustomBackColor = true;
            this.metroTileEvents.UseCustomForeColor = true;
            this.metroTileEvents.UseSelectable = true;
            this.metroTileEvents.Click += new System.EventHandler(this.metroTileEvents_Click);
            // 
            // Fosterhomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 546);
            this.Controls.Add(this.metroTileEvents);
            this.Controls.Add(this.metroTileIntAdd);
            this.Controls.Add(this.metroTileEdu);
            this.Controls.Add(this.metroButtonLogOut);
            this.Controls.Add(this.metroLabelLoggedName);
            this.Controls.Add(this.metroLabelWelcome);
            this.Name = "Fosterhomepage";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Nevelő";
            this.Load += new System.EventHandler(this.Fosterhomepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelLoggedName;
        private MetroFramework.Controls.MetroLabel metroLabelWelcome;
        private MetroFramework.Controls.MetroButton metroButtonLogOut;
        private MetroFramework.Controls.MetroTile metroTileEdu;
        private MetroFramework.Controls.MetroTile metroTileIntAdd;
        private MetroFramework.Controls.MetroTile metroTileEvents;
    }
}