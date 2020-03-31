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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTileAddMEvents = new MetroFramework.Controls.MetroTile();
            this.metroTileIntAdd = new MetroFramework.Controls.MetroTile();
            this.metroTileEdu = new MetroFramework.Controls.MetroTile();
            this.metroTileEvents = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTilePC = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabelWelcome
            // 
            this.metroLabelWelcome.AutoSize = true;
            this.metroLabelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabelWelcome.Location = new System.Drawing.Point(669, 30);
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
            this.metroLabelLoggedName.Location = new System.Drawing.Point(877, 30);
            this.metroLabelLoggedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelLoggedName.Name = "metroLabelLoggedName";
            this.metroLabelLoggedName.Size = new System.Drawing.Size(0, 0);
            this.metroLabelLoggedName.TabIndex = 4;
            this.metroLabelLoggedName.UseCustomForeColor = true;
            // 
            // metroButtonLogOut
            // 
            this.metroButtonLogOut.Location = new System.Drawing.Point(865, 667);
            this.metroButtonLogOut.Margin = new System.Windows.Forms.Padding(4);
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
            this.metroTileChildrenReg.Location = new System.Drawing.Point(278, 142);
            this.metroTileChildrenReg.Name = "metroTileChildrenReg";
            this.metroTileChildrenReg.Size = new System.Drawing.Size(191, 123);
            this.metroTileChildrenReg.TabIndex = 6;
            this.metroTileChildrenReg.Text = "Gyermek regisztráció";
            this.metroTileChildrenReg.UseCustomBackColor = true;
            this.metroTileChildrenReg.UseSelectable = true;
            this.metroTileChildrenReg.UseTileImage = true;
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
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroTile1.Location = new System.Drawing.Point(516, 142);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(191, 123);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Szülő adatbázis";
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTileAddMEvents
            // 
            this.metroTileAddMEvents.ActiveControl = null;
            this.metroTileAddMEvents.Location = new System.Drawing.Point(39, 440);
            this.metroTileAddMEvents.Name = "metroTileAddMEvents";
            this.metroTileAddMEvents.Size = new System.Drawing.Size(191, 123);
            this.metroTileAddMEvents.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTileAddMEvents.TabIndex = 11;
            this.metroTileAddMEvents.Text = "Vizsgálat felvétele: ";
            this.metroTileAddMEvents.UseSelectable = true;
            this.metroTileAddMEvents.Click += new System.EventHandler(this.metroTileAddMEvents_Click);
            // 
            // metroTileIntAdd
            // 
            this.metroTileIntAdd.ActiveControl = null;
            this.metroTileIntAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.metroTileIntAdd.Location = new System.Drawing.Point(39, 291);
            this.metroTileIntAdd.Name = "metroTileIntAdd";
            this.metroTileIntAdd.Size = new System.Drawing.Size(191, 123);
            this.metroTileIntAdd.TabIndex = 13;
            this.metroTileIntAdd.Text = "Intézmény felvétele:";
            this.metroTileIntAdd.UseCustomBackColor = true;
            this.metroTileIntAdd.UseSelectable = true;
            this.metroTileIntAdd.Click += new System.EventHandler(this.metroTileIntAdd_Click);
            // 
            // metroTileEdu
            // 
            this.metroTileEdu.ActiveControl = null;
            this.metroTileEdu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.metroTileEdu.Location = new System.Drawing.Point(278, 291);
            this.metroTileEdu.Name = "metroTileEdu";
            this.metroTileEdu.Size = new System.Drawing.Size(191, 123);
            this.metroTileEdu.TabIndex = 12;
            this.metroTileEdu.Text = "Oktatás - Gyerek";
            this.metroTileEdu.UseCustomBackColor = true;
            this.metroTileEdu.UseSelectable = true;
            this.metroTileEdu.Click += new System.EventHandler(this.metroTileEdu_Click);
            // 
            // metroTileEvents
            // 
            this.metroTileEvents.ActiveControl = null;
            this.metroTileEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.metroTileEvents.ForeColor = System.Drawing.Color.White;
            this.metroTileEvents.Location = new System.Drawing.Point(516, 291);
            this.metroTileEvents.Name = "metroTileEvents";
            this.metroTileEvents.Size = new System.Drawing.Size(191, 123);
            this.metroTileEvents.TabIndex = 14;
            this.metroTileEvents.Text = "Esemény felvétele";
            this.metroTileEvents.UseCustomBackColor = true;
            this.metroTileEvents.UseCustomForeColor = true;
            this.metroTileEvents.UseSelectable = true;
            this.metroTileEvents.Click += new System.EventHandler(this.metroTileEvents_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.metroTile2.ForeColor = System.Drawing.Color.DarkOrange;
            this.metroTile2.Location = new System.Drawing.Point(747, 291);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(191, 123);
            this.metroTile2.TabIndex = 15;
            this.metroTile2.Text = "Gyerek - Esemény";
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTilePC
            // 
            this.metroTilePC.ActiveControl = null;
            this.metroTilePC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.metroTilePC.Location = new System.Drawing.Point(747, 142);
            this.metroTilePC.Name = "metroTilePC";
            this.metroTilePC.Size = new System.Drawing.Size(191, 123);
            this.metroTilePC.TabIndex = 16;
            this.metroTilePC.Text = "Szülő-gyerek";
            this.metroTilePC.UseCustomBackColor = true;
            this.metroTilePC.UseSelectable = true;
            this.metroTilePC.Click += new System.EventHandler(this.metroTilePC_Click);
            // 
            // IntVPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 724);
            this.Controls.Add(this.metroTilePC);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTileEvents);
            this.Controls.Add(this.metroTileIntAdd);
            this.Controls.Add(this.metroTileEdu);
            this.Controls.Add(this.metroTileAddMEvents);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTileWorkerReg);
            this.Controls.Add(this.metroTileChildrenReg);
            this.Controls.Add(this.metroButtonLogOut);
            this.Controls.Add(this.metroLabelLoggedName);
            this.Controls.Add(this.metroLabelWelcome);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTileAddMEvents;
        private MetroFramework.Controls.MetroTile metroTileIntAdd;
        private MetroFramework.Controls.MetroTile metroTileEdu;
        private MetroFramework.Controls.MetroTile metroTileEvents;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTilePC;
    }
}