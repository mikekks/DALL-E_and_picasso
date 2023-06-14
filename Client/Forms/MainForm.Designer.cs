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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.TierPic = new System.Windows.Forms.PictureBox();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_Myinfo = new System.Windows.Forms.Button();
            this.btn_CreateRoom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Tier = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TierPic)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(384, 81);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(8, 8);
            this.metroProgressSpinner1.TabIndex = 1;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 198);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.lbl_Tier);
            this.panel1.Controls.Add(this.lbl_Id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProfilePic);
            this.panel1.Controls.Add(this.TierPic);
            this.panel1.Location = new System.Drawing.Point(8, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 288);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ProfilePic
            // 
            this.ProfilePic.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfilePic.Location = new System.Drawing.Point(32, 15);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(124, 100);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 7;
            this.ProfilePic.TabStop = false;
            // 
            // TierPic
            // 
            this.TierPic.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TierPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TierPic.InitialImage = null;
            this.TierPic.Location = new System.Drawing.Point(32, 153);
            this.TierPic.Name = "TierPic";
            this.TierPic.Size = new System.Drawing.Size(124, 96);
            this.TierPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TierPic.TabIndex = 10;
            this.TierPic.TabStop = false;
            this.TierPic.Click += new System.EventHandler(this.TierPic_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackgroundImage = global::Client.Properties.Resources.logout_removebg_preview;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Location = new System.Drawing.Point(567, 326);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(102, 44);
            this.btn_quit.TabIndex = 23;
            this.btn_quit.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.BackgroundImage = global::Client.Properties.Resources.reLoad_removebg_preview;
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(508, 326);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(53, 43);
            this.btn_reset.TabIndex = 22;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click_1);
            // 
            // btn_Myinfo
            // 
            this.btn_Myinfo.BackColor = System.Drawing.Color.White;
            this.btn_Myinfo.BackgroundImage = global::Client.Properties.Resources.profile_removebg_preview;
            this.btn_Myinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Myinfo.FlatAppearance.BorderSize = 0;
            this.btn_Myinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Myinfo.Location = new System.Drawing.Point(44, 341);
            this.btn_Myinfo.Name = "btn_Myinfo";
            this.btn_Myinfo.Size = new System.Drawing.Size(88, 37);
            this.btn_Myinfo.TabIndex = 20;
            this.btn_Myinfo.UseVisualStyleBackColor = false;
            this.btn_Myinfo.Click += new System.EventHandler(this.btn_Myinfo_Click_1);
            // 
            // btn_CreateRoom
            // 
            this.btn_CreateRoom.BackColor = System.Drawing.Color.White;
            this.btn_CreateRoom.BackgroundImage = global::Client.Properties.Resources.newgame_removebg_preview;
            this.btn_CreateRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CreateRoom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CreateRoom.FlatAppearance.BorderSize = 0;
            this.btn_CreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateRoom.ForeColor = System.Drawing.Color.White;
            this.btn_CreateRoom.Location = new System.Drawing.Point(209, 330);
            this.btn_CreateRoom.Name = "btn_CreateRoom";
            this.btn_CreateRoom.Size = new System.Drawing.Size(144, 43);
            this.btn_CreateRoom.TabIndex = 18;
            this.btn_CreateRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CreateRoom.UseVisualStyleBackColor = false;
            this.btn_CreateRoom.Click += new System.EventHandler(this.btn_CreateRoom_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(45, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(34, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tier : ";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Id.Location = new System.Drawing.Point(81, 126);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(34, 12);
            this.lbl_Id.TabIndex = 15;
            this.lbl_Id.Text = "lbl_Id";
            // 
            // lbl_Tier
            // 
            this.lbl_Tier.AutoSize = true;
            this.lbl_Tier.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Tier.Location = new System.Drawing.Point(89, 262);
            this.lbl_Tier.Name = "lbl_Tier";
            this.lbl_Tier.Size = new System.Drawing.Size(46, 12);
            this.lbl_Tier.TabIndex = 16;
            this.lbl_Tier.Text = "lbl_Tier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(5, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "DALL-E && PICASSO";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(209, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 273);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage6
            // 
            this.tabPage6.AutoScroll = true;
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(460, 245);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Level 6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(460, 245);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Level 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(460, 245);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Level 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(460, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Level 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Level 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Level 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.main2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackMaxSize = 700;
            this.ClientSize = new System.Drawing.Size(694, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Myinfo);
            this.Controls.Add(this.btn_CreateRoom);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Dall-E n Picasso";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.LemonChiffon;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TierPic)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.PictureBox ProfilePic;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox TierPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_CreateRoom;
        private System.Windows.Forms.Button btn_Myinfo;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Tier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}