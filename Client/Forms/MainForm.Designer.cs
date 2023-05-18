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
            this.Room3 = new MetroFramework.Controls.MetroTile();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.Room2 = new MetroFramework.Controls.MetroTile();
            this.Room1 = new MetroFramework.Controls.MetroTile();
            this.Tab2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.Tab3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.btn_CreateRoom = new MetroFramework.Controls.MetroButton();
            this.btn_Myinfo = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_reset = new MetroFramework.Controls.MetroButton();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.Tab1.SuspendLayout();
            this.Tab2.SuspendLayout();
            this.Tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Tab1);
            this.metroTabControl1.Controls.Add(this.Tab2);
            this.metroTabControl1.Controls.Add(this.Tab3);
            this.metroTabControl1.Location = new System.Drawing.Point(194, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(477, 232);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Tab1
            // 
            this.Tab1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tab1.Controls.Add(this.Room3);
            this.Tab1.Controls.Add(this.metroScrollBar1);
            this.Tab1.Controls.Add(this.Room2);
            this.Tab1.Controls.Add(this.Room1);
            this.Tab1.HorizontalScrollbarBarColor = true;
            this.Tab1.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab1.HorizontalScrollbarSize = 10;
            this.Tab1.Location = new System.Drawing.Point(4, 38);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(469, 190);
            this.Tab1.TabIndex = 0;
            this.Tab1.Text = "★";
            this.Tab1.VerticalScrollbarBarColor = true;
            this.Tab1.VerticalScrollbarHighlightOnWheel = false;
            this.Tab1.VerticalScrollbarSize = 10;
            // 
            // Room3
            // 
            this.Room3.ActiveControl = null;
            this.Room3.Location = new System.Drawing.Point(3, 148);
            this.Room3.Name = "Room3";
            this.Room3.Size = new System.Drawing.Size(438, 60);
            this.Room3.TabIndex = 4;
            this.Room3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room3.TileImage = global::Client.Properties.Resources.Van;
            this.Room3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Room3.UseSelectable = true;
            this.Room3.UseTileImage = true;
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.LargeChange = 10;
            this.metroScrollBar1.Location = new System.Drawing.Point(459, 10);
            this.metroScrollBar1.Maximum = 100;
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.MouseWheelBarPartitions = 10;
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.ScrollbarSize = 10;
            this.metroScrollBar1.Size = new System.Drawing.Size(10, 200);
            this.metroScrollBar1.TabIndex = 3;
            this.metroScrollBar1.UseSelectable = true;
            // 
            // Room2
            // 
            this.Room2.ActiveControl = null;
            this.Room2.Location = new System.Drawing.Point(3, 82);
            this.Room2.Name = "Room2";
            this.Room2.Size = new System.Drawing.Size(438, 60);
            this.Room2.TabIndex = 2;
            this.Room2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room2.TileImage = global::Client.Properties.Resources.room_icon2;
            this.Room2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Room2.UseSelectable = true;
            this.Room2.UseTileImage = true;
            this.Room2.Click += new System.EventHandler(this.Room2_Click);
            // 
            // Room1
            // 
            this.Room1.ActiveControl = null;
            this.Room1.Location = new System.Drawing.Point(3, 16);
            this.Room1.Name = "Room1";
            this.Room1.Size = new System.Drawing.Size(438, 60);
            this.Room1.Style = MetroFramework.MetroColorStyle.Blue;
            this.Room1.TabIndex = 0;
            this.Room1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room1.TileImage = global::Client.Properties.Resources.dalle2;
            this.Room1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Room1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Room1.UseSelectable = true;
            this.Room1.UseTileImage = true;
            this.Room1.Click += new System.EventHandler(this.Room1_Click);
            // 
            // Tab2
            // 
            this.Tab2.Controls.Add(this.metroTile2);
            this.Tab2.Controls.Add(this.metroTile1);
            this.Tab2.HorizontalScrollbarBarColor = true;
            this.Tab2.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab2.HorizontalScrollbarSize = 10;
            this.Tab2.Location = new System.Drawing.Point(4, 38);
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(469, 190);
            this.Tab2.TabIndex = 1;
            this.Tab2.Text = "★★";
            this.Tab2.VerticalScrollbarBarColor = true;
            this.Tab2.VerticalScrollbarHighlightOnWheel = false;
            this.Tab2.VerticalScrollbarSize = 10;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(3, 80);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(455, 64);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(3, 12);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(455, 62);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // Tab3
            // 
            this.Tab3.Controls.Add(this.metroTile3);
            this.Tab3.HorizontalScrollbarBarColor = true;
            this.Tab3.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab3.HorizontalScrollbarSize = 10;
            this.Tab3.Location = new System.Drawing.Point(4, 38);
            this.Tab3.Name = "Tab3";
            this.Tab3.Size = new System.Drawing.Size(469, 190);
            this.Tab3.TabIndex = 2;
            this.Tab3.Text = "★★★";
            this.Tab3.VerticalScrollbarBarColor = true;
            this.Tab3.VerticalScrollbarHighlightOnWheel = false;
            this.Tab3.VerticalScrollbarSize = 10;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(3, 17);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(455, 60);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "metroTile3";
            this.metroTile3.UseSelectable = true;
            // 
            // btn_CreateRoom
            // 
            this.btn_CreateRoom.BackColor = System.Drawing.Color.Cyan;
            this.btn_CreateRoom.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_CreateRoom.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_CreateRoom.Location = new System.Drawing.Point(331, 315);
            this.btn_CreateRoom.Name = "btn_CreateRoom";
            this.btn_CreateRoom.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateRoom.TabIndex = 4;
            this.btn_CreateRoom.Text = "방 만들기";
            this.btn_CreateRoom.UseSelectable = true;
            this.btn_CreateRoom.Click += new System.EventHandler(this.btn_CreateRoom_Click);
            // 
            // btn_Myinfo
            // 
            this.btn_Myinfo.BackColor = System.Drawing.Color.Black;
            this.btn_Myinfo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Myinfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Myinfo.Location = new System.Drawing.Point(46, 323);
            this.btn_Myinfo.Name = "btn_Myinfo";
            this.btn_Myinfo.Size = new System.Drawing.Size(75, 23);
            this.btn_Myinfo.TabIndex = 5;
            this.btn_Myinfo.Text = "내 정보";
            this.btn_Myinfo.UseSelectable = true;
            this.btn_Myinfo.Click += new System.EventHandler(this.btn_Myinfo_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Cyan;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton2.Location = new System.Drawing.Point(592, 323);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "로그아웃";
            this.metroButton2.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 228);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 264);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Song";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(46, 283);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Gold 3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(46, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 76);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::Client.Properties.Resources.dalle2;
            this.pictureBox1.Location = new System.Drawing.Point(46, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_reset.Location = new System.Drawing.Point(201, 315);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "새로고침";
            this.btn_reset.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(694, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btn_Myinfo);
            this.Controls.Add(this.btn_CreateRoom);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroProgressSpinner1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "Dall-E n Picasso";
            this.TransparencyKey = System.Drawing.Color.LemonChiffon;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.Tab1.ResumeLayout(false);
            this.Tab2.ResumeLayout(false);
            this.Tab3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile Room1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroTile Room2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Tab1;
        private MetroFramework.Controls.MetroTabPage Tab2;
        private MetroFramework.Controls.MetroTabPage Tab3;
        private MetroFramework.Controls.MetroButton btn_CreateRoom;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroButton btn_Myinfo;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile Room3;
        private MetroFramework.Controls.MetroButton btn_reset;
        private System.Windows.Forms.Button button1;
    }
}