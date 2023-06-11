namespace Client
{
    partial class MainForm
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
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Tab1 = new MetroFramework.Controls.MetroTabPage();
            this.Tab2 = new MetroFramework.Controls.MetroTabPage();
            this.Tab3 = new MetroFramework.Controls.MetroTabPage();
            this.Tab4 = new System.Windows.Forms.TabPage();
            this.Tab5 = new System.Windows.Forms.TabPage();
            this.Tab6 = new System.Windows.Forms.TabPage();
            this.btn_CreateRoom = new MetroFramework.Controls.MetroButton();
            this.btn_Myinfo = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.UserId = new MetroFramework.Controls.MetroLabel();
            this.UserTier = new MetroFramework.Controls.MetroLabel();
            this.TierPic = new System.Windows.Forms.PictureBox();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.btn_reset = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TierPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(439, 101);
            this.metroProgressSpinner1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(9, 10);
            this.metroProgressSpinner1.TabIndex = 1;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Tab1);
            this.metroTabControl1.Controls.Add(this.Tab2);
            this.metroTabControl1.Controls.Add(this.Tab3);
            this.metroTabControl1.Controls.Add(this.Tab4);
            this.metroTabControl1.Controls.Add(this.Tab5);
            this.metroTabControl1.Controls.Add(this.Tab6);
            this.metroTabControl1.Location = new System.Drawing.Point(209, 41);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(566, 328);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Tab1
            // 
            this.Tab1.AutoScroll = true;
            this.Tab1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tab1.HorizontalScrollbar = true;
            this.Tab1.HorizontalScrollbarBarColor = true;
            this.Tab1.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab1.HorizontalScrollbarSize = 12;
            this.Tab1.Location = new System.Drawing.Point(4, 38);
            this.Tab1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(558, 286);
            this.Tab1.TabIndex = 0;
            this.Tab1.Text = "★";
            this.Tab1.VerticalScrollbar = true;
            this.Tab1.VerticalScrollbarBarColor = true;
            this.Tab1.VerticalScrollbarHighlightOnWheel = false;
            this.Tab1.VerticalScrollbarSize = 11;
            this.Tab1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Tab1_Scroll);
            // 
            // Tab2
            // 
            this.Tab2.AutoScroll = true;
            this.Tab2.HorizontalScrollbar = true;
            this.Tab2.HorizontalScrollbarBarColor = true;
            this.Tab2.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab2.HorizontalScrollbarSize = 12;
            this.Tab2.Location = new System.Drawing.Point(4, 38);
            this.Tab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(558, 286);
            this.Tab2.TabIndex = 1;
            this.Tab2.Text = "★★";
            this.Tab2.VerticalScrollbar = true;
            this.Tab2.VerticalScrollbarBarColor = true;
            this.Tab2.VerticalScrollbarHighlightOnWheel = false;
            this.Tab2.VerticalScrollbarSize = 11;
            // 
            // Tab3
            // 
            this.Tab3.AutoScroll = true;
            this.Tab3.HorizontalScrollbar = true;
            this.Tab3.HorizontalScrollbarBarColor = true;
            this.Tab3.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab3.HorizontalScrollbarSize = 12;
            this.Tab3.Location = new System.Drawing.Point(4, 38);
            this.Tab3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab3.Name = "Tab3";
            this.Tab3.Size = new System.Drawing.Size(558, 286);
            this.Tab3.TabIndex = 2;
            this.Tab3.Text = "★★★";
            this.Tab3.VerticalScrollbar = true;
            this.Tab3.VerticalScrollbarBarColor = true;
            this.Tab3.VerticalScrollbarHighlightOnWheel = false;
            this.Tab3.VerticalScrollbarSize = 11;
            // 
            // Tab4
            // 
            this.Tab4.AutoScroll = true;
            this.Tab4.Location = new System.Drawing.Point(4, 38);
            this.Tab4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab4.Name = "Tab4";
            this.Tab4.Size = new System.Drawing.Size(558, 286);
            this.Tab4.TabIndex = 3;
            this.Tab4.Text = "★★★★";
            // 
            // Tab5
            // 
            this.Tab5.AutoScroll = true;
            this.Tab5.Location = new System.Drawing.Point(4, 38);
            this.Tab5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab5.Name = "Tab5";
            this.Tab5.Size = new System.Drawing.Size(558, 286);
            this.Tab5.TabIndex = 4;
            this.Tab5.Text = "★★★★★";
            // 
            // Tab6
            // 
            this.Tab6.AutoScroll = true;
            this.Tab6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Tab6.Location = new System.Drawing.Point(4, 38);
            this.Tab6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab6.Name = "Tab6";
            this.Tab6.Size = new System.Drawing.Size(558, 286);
            this.Tab6.TabIndex = 5;
            this.Tab6.Text = "★★★★★★";
            // 
            // btn_CreateRoom
            // 
            this.btn_CreateRoom.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_CreateRoom.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_CreateRoom.ForeColor = System.Drawing.Color.White;
            this.btn_CreateRoom.Location = new System.Drawing.Point(310, 376);
            this.btn_CreateRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CreateRoom.Name = "btn_CreateRoom";
            this.btn_CreateRoom.Size = new System.Drawing.Size(86, 29);
            this.btn_CreateRoom.TabIndex = 4;
            this.btn_CreateRoom.Text = "방 만들기";
            this.btn_CreateRoom.UseCustomBackColor = true;
            this.btn_CreateRoom.UseCustomForeColor = true;
            this.btn_CreateRoom.UseSelectable = true;
            this.btn_CreateRoom.Click += new System.EventHandler(this.btn_CreateRoom_Click);
            // 
            // btn_Myinfo
            // 
            this.btn_Myinfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Myinfo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Myinfo.ForeColor = System.Drawing.Color.White;
            this.btn_Myinfo.Location = new System.Drawing.Point(19, 430);
            this.btn_Myinfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Myinfo.Name = "btn_Myinfo";
            this.btn_Myinfo.Size = new System.Drawing.Size(187, 29);
            this.btn_Myinfo.TabIndex = 5;
            this.btn_Myinfo.Text = "내 정보";
            this.btn_Myinfo.UseCustomBackColor = true;
            this.btn_Myinfo.UseCustomForeColor = true;
            this.btn_Myinfo.UseSelectable = true;
            this.btn_Myinfo.Click += new System.EventHandler(this.btn_Myinfo_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(681, 430);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(86, 29);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "로그아웃";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(40, 248);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 8;
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.UserId.ForeColor = System.Drawing.Color.White;
            this.UserId.Location = new System.Drawing.Point(71, 189);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(43, 20);
            this.UserId.TabIndex = 9;
            this.UserId.Text = "Song";
            this.UserId.UseCustomBackColor = true;
            this.UserId.UseCustomForeColor = true;
            // 
            // UserTier
            // 
            this.UserTier.AutoSize = true;
            this.UserTier.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.UserTier.ForeColor = System.Drawing.Color.White;
            this.UserTier.Location = new System.Drawing.Point(67, 356);
            this.UserTier.Name = "UserTier";
            this.UserTier.Size = new System.Drawing.Size(53, 20);
            this.UserTier.TabIndex = 12;
            this.UserTier.Text = "Gold 3";
            this.UserTier.UseCustomBackColor = true;
            this.UserTier.UseCustomForeColor = true;
            // 
            // TierPic
            // 
            this.TierPic.BackColor = System.Drawing.Color.White;
            this.TierPic.InitialImage = null;
            this.TierPic.Location = new System.Drawing.Point(7, 216);
            this.TierPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TierPic.Name = "TierPic";
            this.TierPic.Size = new System.Drawing.Size(173, 138);
            this.TierPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TierPic.TabIndex = 10;
            this.TierPic.TabStop = false;
            // 
            // ProfilePic
            // 
            this.ProfilePic.BackColor = System.Drawing.Color.White;
            this.ProfilePic.Location = new System.Drawing.Point(7, 51);
            this.ProfilePic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(173, 136);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 7;
            this.ProfilePic.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_reset.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(217, 376);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(86, 29);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "새로고침";
            this.btn_reset.UseCustomBackColor = true;
            this.btn_reset.UseCustomForeColor = true;
            this.btn_reset.UseSelectable = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(3, 4);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(158, 25);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "DALL-E & PICASSO";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.ProfilePic);
            this.panel1.Controls.Add(this.TierPic);
            this.panel1.Controls.Add(this.UserTier);
            this.panel1.Controls.Add(this.UserId);
            this.panel1.Location = new System.Drawing.Point(19, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 381);
            this.panel1.TabIndex = 17;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(209, 430);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(466, 29);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "Team Build 알아보기";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(793, 484);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_Myinfo);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btn_CreateRoom);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 38, 23, 25);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Dall-E n Picasso";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.LemonChiffon;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TierPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Tab1;
        private MetroFramework.Controls.MetroTabPage Tab2;
        private MetroFramework.Controls.MetroTabPage Tab3;
        private MetroFramework.Controls.MetroButton btn_CreateRoom;
        private MetroFramework.Controls.MetroButton btn_Myinfo;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.PictureBox ProfilePic;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel UserId;
        private System.Windows.Forms.PictureBox TierPic;
        private MetroFramework.Controls.MetroLabel UserTier;
        private MetroFramework.Controls.MetroButton btn_reset;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage Tab4;
        private System.Windows.Forms.TabPage Tab5;
        private System.Windows.Forms.TabPage Tab6;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}