namespace Szakdolgozat2020.Forms.Soul
{
    partial class SoulForm
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
            this.metroTileAddMEvents = new MetroFramework.Controls.MetroTile();
            this.metroLabelLoggedName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelWelcome = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLogOut = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTileAddMEvents
            // 
            this.metroTileAddMEvents.ActiveControl = null;
            this.metroTileAddMEvents.Location = new System.Drawing.Point(42, 115);
            this.metroTileAddMEvents.Name = "metroTileAddMEvents";
            this.metroTileAddMEvents.Size = new System.Drawing.Size(191, 123);
            this.metroTileAddMEvents.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTileAddMEvents.TabIndex = 10;
            this.metroTileAddMEvents.Text = "Vizsgálat felvétele: ";
            this.metroTileAddMEvents.UseSelectable = true;
            this.metroTileAddMEvents.Click += new System.EventHandler(this.metroTileAddMEvents_Click);
            // 
            // metroLabelLoggedName
            // 
            this.metroLabelLoggedName.AutoSize = true;
            this.metroLabelLoggedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(114)))), ((int)(((byte)(208)))));
            this.metroLabelLoggedName.Location = new System.Drawing.Point(785, 32);
            this.metroLabelLoggedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelLoggedName.Name = "metroLabelLoggedName";
            this.metroLabelLoggedName.Size = new System.Drawing.Size(0, 0);
            this.metroLabelLoggedName.TabIndex = 12;
            this.metroLabelLoggedName.UseCustomForeColor = true;
            // 
            // metroLabelWelcome
            // 
            this.metroLabelWelcome.AutoSize = true;
            this.metroLabelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabelWelcome.Location = new System.Drawing.Point(577, 32);
            this.metroLabelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelWelcome.Name = "metroLabelWelcome";
            this.metroLabelWelcome.Size = new System.Drawing.Size(172, 20);
            this.metroLabelWelcome.TabIndex = 11;
            this.metroLabelWelcome.Text = "Üdvözölek a rendszerben:";
            // 
            // metroButtonLogOut
            // 
            this.metroButtonLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButtonLogOut.Location = new System.Drawing.Point(826, 444);
            this.metroButtonLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.metroButtonLogOut.Name = "metroButtonLogOut";
            this.metroButtonLogOut.Size = new System.Drawing.Size(156, 28);
            this.metroButtonLogOut.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroButtonLogOut.TabIndex = 13;
            this.metroButtonLogOut.Text = "Kijelentkezés";
            this.metroButtonLogOut.UseCustomBackColor = true;
            this.metroButtonLogOut.UseSelectable = true;
            this.metroButtonLogOut.UseStyleColors = true;
            // 
            // SoulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 496);
            this.Controls.Add(this.metroButtonLogOut);
            this.Controls.Add(this.metroLabelLoggedName);
            this.Controls.Add(this.metroLabelWelcome);
            this.Controls.Add(this.metroTileAddMEvents);
            this.Name = "SoulForm";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Orvosi ellátás:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileAddMEvents;
        private MetroFramework.Controls.MetroLabel metroLabelLoggedName;
        private MetroFramework.Controls.MetroLabel metroLabelWelcome;
        private MetroFramework.Controls.MetroButton metroButtonLogOut;
    }
}