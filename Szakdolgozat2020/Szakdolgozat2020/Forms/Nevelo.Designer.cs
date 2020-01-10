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
            this.SuspendLayout();
            // 
            // metroLabelWelcome
            // 
            this.metroLabelWelcome.AutoSize = true;
            this.metroLabelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabelWelcome.Location = new System.Drawing.Point(500, 24);
            this.metroLabelWelcome.Name = "metroLabelWelcome";
            this.metroLabelWelcome.Size = new System.Drawing.Size(160, 19);
            this.metroLabelWelcome.TabIndex = 5;
            this.metroLabelWelcome.Text = "Üdvözölek a rendszerben:";
            // 
            // metroLabelLoggedName
            // 
            this.metroLabelLoggedName.AutoSize = true;
            this.metroLabelLoggedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroLabelLoggedName.Location = new System.Drawing.Point(656, 24);
            this.metroLabelLoggedName.Name = "metroLabelLoggedName";
            this.metroLabelLoggedName.Size = new System.Drawing.Size(49, 19);
            this.metroLabelLoggedName.TabIndex = 7;
            this.metroLabelLoggedName.Text = "ddddd";
            this.metroLabelLoggedName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabelLoggedName.UseCustomForeColor = true;
            // 
            // Nevelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 454);
            this.Controls.Add(this.metroLabelLoggedName);
            this.Controls.Add(this.metroLabelWelcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Nevelo";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Nevelő:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabelWelcome;
        private MetroFramework.Controls.MetroLabel metroLabelLoggedName;
    }
}