namespace Client
{
    partial class GameRoom
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.RichTextBox();
            this.rdy_list = new System.Windows.Forms.RichTextBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timeLimit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Answer6 = new MetroFramework.Controls.MetroTile();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Answer5 = new MetroFramework.Controls.MetroTile();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Answer4 = new MetroFramework.Controls.MetroTile();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Answer3 = new MetroFramework.Controls.MetroTile();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Answer2 = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Answer1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Send = new MetroFramework.Controls.MetroButton();
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.btn_Start = new MetroFramework.Controls.MetroButton();
            this.btn_Ready = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(6, 524);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(253, 25);
            this.tbAnswer.TabIndex = 1;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(6, 16);
            this.log.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(284, 499);
            this.log.TabIndex = 8;
            this.log.Text = "";
            // 
            // rdy_list
            // 
            this.rdy_list.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rdy_list.Location = new System.Drawing.Point(6, 12);
            this.rdy_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdy_list.Name = "rdy_list";
            this.rdy_list.Size = new System.Drawing.Size(216, 603);
            this.rdy_list.TabIndex = 10;
            this.rdy_list.Text = "";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(796, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "남은 시간 : ";
            // 
            // timeLimit
            // 
            this.timeLimit.AutoSize = true;
            this.timeLimit.BackColor = System.Drawing.Color.Lavender;
            this.timeLimit.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLimit.ForeColor = System.Drawing.Color.IndianRed;
            this.timeLimit.Location = new System.Drawing.Point(927, 54);
            this.timeLimit.Name = "timeLimit";
            this.timeLimit.Size = new System.Drawing.Size(38, 24);
            this.timeLimit.TabIndex = 19;
            this.timeLimit.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F);
            this.label3.Location = new System.Drawing.Point(970, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "초";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Answer6);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.Answer5);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.Answer4);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.rdy_list);
            this.groupBox1.Controls.Add(this.Answer3);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.Answer2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.Answer1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.picBox);
            this.groupBox1.Location = new System.Drawing.Point(231, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(541, 692);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // Answer6
            // 
            this.Answer6.ActiveControl = null;
            this.Answer6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(204)))), ((int)(((byte)(85)))));
            this.Answer6.ForeColor = System.Drawing.Color.Black;
            this.Answer6.Location = new System.Drawing.Point(395, 592);
            this.Answer6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Answer6.Name = "Answer6";
            this.Answer6.Size = new System.Drawing.Size(121, 54);
            this.Answer6.TabIndex = 44;
            this.Answer6.Text = "뭘까요?";
            this.Answer6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer6.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer6.UseCustomBackColor = true;
            this.Answer6.UseCustomForeColor = true;
            this.Answer6.UseSelectable = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = global::Client.Properties.Resources.button1_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(369, 565);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(170, 119);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // Answer5
            // 
            this.Answer5.ActiveControl = null;
            this.Answer5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.Answer5.ForeColor = System.Drawing.Color.Black;
            this.Answer5.Location = new System.Drawing.Point(217, 592);
            this.Answer5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Answer5.Name = "Answer5";
            this.Answer5.Size = new System.Drawing.Size(121, 54);
            this.Answer5.TabIndex = 42;
            this.Answer5.Text = "뭘까요?";
            this.Answer5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer5.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer5.UseCustomBackColor = true;
            this.Answer5.UseCustomForeColor = true;
            this.Answer5.UseSelectable = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = global::Client.Properties.Resources.button4_removebg_preview;
            this.pictureBox5.Location = new System.Drawing.Point(191, 565);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(170, 119);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // Answer4
            // 
            this.Answer4.ActiveControl = null;
            this.Answer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(206)))));
            this.Answer4.ForeColor = System.Drawing.Color.Black;
            this.Answer4.Location = new System.Drawing.Point(39, 592);
            this.Answer4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(121, 54);
            this.Answer4.TabIndex = 40;
            this.Answer4.Text = "뭘까요?";
            this.Answer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer4.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer4.UseCustomBackColor = true;
            this.Answer4.UseCustomForeColor = true;
            this.Answer4.UseSelectable = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = global::Client.Properties.Resources.button3_removebg_preview;
            this.pictureBox6.Location = new System.Drawing.Point(13, 565);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(170, 119);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // Answer3
            // 
            this.Answer3.ActiveControl = null;
            this.Answer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(206)))));
            this.Answer3.ForeColor = System.Drawing.Color.Black;
            this.Answer3.Location = new System.Drawing.Point(395, 480);
            this.Answer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(121, 54);
            this.Answer3.TabIndex = 38;
            this.Answer3.Text = "뭘까요?";
            this.Answer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer3.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer3.UseCustomBackColor = true;
            this.Answer3.UseCustomForeColor = true;
            this.Answer3.UseSelectable = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::Client.Properties.Resources.button3_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(369, 453);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // Answer2
            // 
            this.Answer2.ActiveControl = null;
            this.Answer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(216)))), ((int)(((byte)(213)))));
            this.Answer2.ForeColor = System.Drawing.Color.Black;
            this.Answer2.Location = new System.Drawing.Point(217, 480);
            this.Answer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(121, 54);
            this.Answer2.TabIndex = 36;
            this.Answer2.Text = "뭘까요?";
            this.Answer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer2.UseCustomBackColor = true;
            this.Answer2.UseCustomForeColor = true;
            this.Answer2.UseSelectable = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::Client.Properties.Resources.button2_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(191, 453);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Answer1
            // 
            this.Answer1.ActiveControl = null;
            this.Answer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(204)))), ((int)(((byte)(85)))));
            this.Answer1.ForeColor = System.Drawing.Color.Black;
            this.Answer1.Location = new System.Drawing.Point(39, 480);
            this.Answer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(121, 54);
            this.Answer1.TabIndex = 34;
            this.Answer1.Text = "뭘까요?";
            this.Answer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer1.UseCustomBackColor = true;
            this.Answer1.UseCustomForeColor = true;
            this.Answer1.UseSelectable = true;
            this.Answer1.Click += new System.EventHandler(this.Answer1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Client.Properties.Resources.button1_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(13, 453);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(13, 29);
            this.picBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(522, 416);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.WaitOnLoad = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.log);
            this.groupBox2.Controls.Add(this.tbAnswer);
            this.groupBox2.Controls.Add(this.btn_Send);
            this.groupBox2.Location = new System.Drawing.Point(781, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(296, 557);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // btn_Send
            // 
            this.btn_Send.BackgroundImage = global::Client.Properties.Resources.upload_removebg_preview;
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send.Location = new System.Drawing.Point(265, 523);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(25, 25);
            this.btn_Send.TabIndex = 13;
            this.btn_Send.UseSelectable = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = global::Client.Properties.Resources.exit2_removebg_preview;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Exit.Location = new System.Drawing.Point(962, 647);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(115, 83);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.UseSelectable = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // btn_Start
            // 
            this.btn_Start.BackgroundImage = global::Client.Properties.Resources.start_removebg_preview;
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Start.Location = new System.Drawing.Point(781, 647);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(184, 76);
            this.btn_Start.TabIndex = 17;
            this.btn_Start.UseSelectable = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Ready
            // 
            this.btn_Ready.BackgroundImage = global::Client.Properties.Resources.ready_removebg_preview;
            this.btn_Ready.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ready.Location = new System.Drawing.Point(9, 659);
            this.btn_Ready.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(216, 71);
            this.btn_Ready.TabIndex = 14;
            this.btn_Ready.UseSelectable = true;
            this.btn_Ready.Click += new System.EventHandler(this.btn_Ready_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(216, 598);
            this.dataGridView1.TabIndex = 29;
            // 
            // GameRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1085, 751);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Ready);
            this.Controls.Add(this.timeLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameRoom";
            this.Padding = new System.Windows.Forms.Padding(23, 38, 23, 25);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TransparencyKey = System.Drawing.SystemColors.InfoText;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameRoom_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.RichTextBox rdy_list;
        private MetroFramework.Controls.MetroButton btn_Send;
        private MetroFramework.Controls.MetroButton btn_Ready;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLimit;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btn_Exit;
        private MetroFramework.Controls.MetroButton btn_Start;
        private MetroFramework.Controls.MetroTile Answer6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroTile Answer5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MetroFramework.Controls.MetroTile Answer4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MetroFramework.Controls.MetroTile Answer3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroTile Answer2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile Answer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

