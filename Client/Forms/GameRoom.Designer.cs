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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timeLimit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Answer6 = new MetroFramework.Controls.MetroTile();
            this.Answer5 = new MetroFramework.Controls.MetroTile();
            this.Answer4 = new MetroFramework.Controls.MetroTile();
            this.Answer3 = new MetroFramework.Controls.MetroTile();
            this.Answer2 = new MetroFramework.Controls.MetroTile();
            this.Answer1 = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ready_list1 = new System.Windows.Forms.Panel();
            this.ready_list2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.chat_list = new System.Windows.Forms.Panel();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Ready = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btn_AnsSend = new System.Windows.Forms.Button();
            this.btn_ChatSend = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ready_list1.SuspendLayout();
            this.ready_list2.SuspendLayout();
            this.chat_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(5, 468);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(222, 21);
            this.tbAnswer.TabIndex = 1;
            this.tbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnswer_KeyDown);
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
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "남은 시간 : ";
            // 
            // timeLimit
            // 
            this.timeLimit.AutoSize = true;
            this.timeLimit.BackColor = System.Drawing.Color.Lavender;
            this.timeLimit.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLimit.ForeColor = System.Drawing.Color.IndianRed;
            this.timeLimit.Location = new System.Drawing.Point(126, 13);
            this.timeLimit.Name = "timeLimit";
            this.timeLimit.Size = new System.Drawing.Size(31, 19);
            this.timeLimit.TabIndex = 19;
            this.timeLimit.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F);
            this.label3.Location = new System.Drawing.Point(163, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
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
            this.groupBox1.Controls.Add(this.Answer3);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.Answer2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.Answer1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.picBox);
            this.groupBox1.Location = new System.Drawing.Point(243, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 563);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // Answer6
            // 
            this.Answer6.ActiveControl = null;
            this.Answer6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(204)))), ((int)(((byte)(85)))));
            this.Answer6.ForeColor = System.Drawing.Color.Black;
            this.Answer6.Location = new System.Drawing.Point(346, 474);
            this.Answer6.Name = "Answer6";
            this.Answer6.Size = new System.Drawing.Size(106, 43);
            this.Answer6.TabIndex = 44;
            this.Answer6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer6.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer6.UseCustomBackColor = true;
            this.Answer6.UseCustomForeColor = true;
            this.Answer6.UseSelectable = true;
            // 
            // Answer5
            // 
            this.Answer5.ActiveControl = null;
            this.Answer5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.Answer5.ForeColor = System.Drawing.Color.Black;
            this.Answer5.Location = new System.Drawing.Point(190, 474);
            this.Answer5.Name = "Answer5";
            this.Answer5.Size = new System.Drawing.Size(106, 43);
            this.Answer5.TabIndex = 42;
            this.Answer5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer5.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer5.UseCustomBackColor = true;
            this.Answer5.UseCustomForeColor = true;
            this.Answer5.UseSelectable = true;
            // 
            // Answer4
            // 
            this.Answer4.ActiveControl = null;
            this.Answer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(206)))));
            this.Answer4.ForeColor = System.Drawing.Color.Black;
            this.Answer4.Location = new System.Drawing.Point(34, 474);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(106, 43);
            this.Answer4.TabIndex = 40;
            this.Answer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer4.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer4.UseCustomBackColor = true;
            this.Answer4.UseCustomForeColor = true;
            this.Answer4.UseSelectable = true;
            // 
            // Answer3
            // 
            this.Answer3.ActiveControl = null;
            this.Answer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(206)))));
            this.Answer3.ForeColor = System.Drawing.Color.Black;
            this.Answer3.Location = new System.Drawing.Point(346, 384);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(106, 43);
            this.Answer3.TabIndex = 38;
            this.Answer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer3.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer3.UseCustomBackColor = true;
            this.Answer3.UseCustomForeColor = true;
            this.Answer3.UseSelectable = true;
            this.Answer3.Click += new System.EventHandler(this.Answer3_Click);
            // 
            // Answer2
            // 
            this.Answer2.ActiveControl = null;
            this.Answer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(216)))), ((int)(((byte)(213)))));
            this.Answer2.ForeColor = System.Drawing.Color.Black;
            this.Answer2.Location = new System.Drawing.Point(190, 384);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(106, 43);
            this.Answer2.TabIndex = 36;
            this.Answer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer2.UseCustomBackColor = true;
            this.Answer2.UseCustomForeColor = true;
            this.Answer2.UseSelectable = true;
            // 
            // Answer1
            // 
            this.Answer1.ActiveControl = null;
            this.Answer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(204)))), ((int)(((byte)(85)))));
            this.Answer1.ForeColor = System.Drawing.Color.Black;
            this.Answer1.Location = new System.Drawing.Point(34, 384);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(106, 43);
            this.Answer1.TabIndex = 34;
            this.Answer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Answer1.UseCustomBackColor = true;
            this.Answer1.UseCustomForeColor = true;
            this.Answer1.UseSelectable = true;
            this.Answer1.Click += new System.EventHandler(this.Answer1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chat_list);
            this.groupBox2.Controls.Add(this.btn_AnsSend);
            this.groupBox2.Controls.Add(this.tbAnswer);
            this.groupBox2.Controls.Add(this.btn_ChatSend);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.timeLimit);
            this.groupBox2.Location = new System.Drawing.Point(724, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 500);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(32, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 49;
            this.label2.Text = "방 제목 : ";
            // 
            // ready_list1
            // 
            this.ready_list1.Controls.Add(this.button6);
            this.ready_list1.Location = new System.Drawing.Point(12, 122);
            this.ready_list1.Name = "ready_list1";
            this.ready_list1.Size = new System.Drawing.Size(134, 318);
            this.ready_list1.TabIndex = 52;
            // 
            // ready_list2
            // 
            this.ready_list2.Controls.Add(this.button5);
            this.ready_list2.Location = new System.Drawing.Point(146, 122);
            this.ready_list2.Name = "ready_list2";
            this.ready_list2.Size = new System.Drawing.Size(86, 318);
            this.ready_list2.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(22, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "유저 리스트";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(152, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ready";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(0, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button4.Location = new System.Drawing.Point(0, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LemonChiffon;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button5.Location = new System.Drawing.Point(3, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LemonChiffon;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button6.Location = new System.Drawing.Point(1, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 42);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // chat_list
            // 
            this.chat_list.AutoScroll = true;
            this.chat_list.Controls.Add(this.button4);
            this.chat_list.Controls.Add(this.button2);
            this.chat_list.Location = new System.Drawing.Point(5, 48);
            this.chat_list.Name = "chat_list";
            this.chat_list.Size = new System.Drawing.Size(248, 338);
            this.chat_list.TabIndex = 22;
            // 
            // btn_Start
            // 
            this.btn_Start.BackgroundImage = global::Client.Properties.Resources.start_removebg_preview;
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Location = new System.Drawing.Point(724, 553);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(153, 59);
            this.btn_Start.TabIndex = 51;
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click_1);
            // 
            // btn_Ready
            // 
            this.btn_Ready.BackgroundImage = global::Client.Properties.Resources.ready_removebg_preview;
            this.btn_Ready.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ready.FlatAppearance.BorderSize = 0;
            this.btn_Ready.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ready.Location = new System.Drawing.Point(17, 465);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(215, 59);
            this.btn_Ready.TabIndex = 50;
            this.btn_Ready.UseVisualStyleBackColor = true;
            this.btn_Ready.Click += new System.EventHandler(this.btn_Ready_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = global::Client.Properties.Resources.button1_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(323, 452);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 95);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = global::Client.Properties.Resources.button4_removebg_preview;
            this.pictureBox5.Location = new System.Drawing.Point(167, 452);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(149, 95);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = global::Client.Properties.Resources.button3_removebg_preview;
            this.pictureBox6.Location = new System.Drawing.Point(11, 452);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(149, 95);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::Client.Properties.Resources.button3_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(323, 362);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::Client.Properties.Resources.button2_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(167, 362);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Client.Properties.Resources.button1_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(11, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBox.Image = global::Client.Properties.Resources.mainImage;
            this.picBox.Location = new System.Drawing.Point(11, 23);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(457, 333);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.WaitOnLoad = true;
            // 
            // btn_AnsSend
            // 
            this.btn_AnsSend.BackgroundImage = global::Client.Properties.Resources.realCheck;
            this.btn_AnsSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AnsSend.FlatAppearance.BorderSize = 0;
            this.btn_AnsSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnsSend.Location = new System.Drawing.Point(40, 390);
            this.btn_AnsSend.Name = "btn_AnsSend";
            this.btn_AnsSend.Size = new System.Drawing.Size(187, 72);
            this.btn_AnsSend.TabIndex = 14;
            this.btn_AnsSend.UseVisualStyleBackColor = true;
            this.btn_AnsSend.Click += new System.EventHandler(this.btn_AnsSend_Click);
            // 
            // btn_ChatSend
            // 
            this.btn_ChatSend.BackgroundImage = global::Client.Properties.Resources.upload_removebg_preview;
            this.btn_ChatSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChatSend.Location = new System.Drawing.Point(232, 467);
            this.btn_ChatSend.Name = "btn_ChatSend";
            this.btn_ChatSend.Size = new System.Drawing.Size(22, 20);
            this.btn_ChatSend.TabIndex = 13;
            this.btn_ChatSend.UseSelectable = true;
            this.btn_ChatSend.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::Client.Properties.Resources.exit2_removebg_preview;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(884, 553);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(99, 62);
            this.btn_exit.TabIndex = 56;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_2);
            // 
            // GameRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1031, 638);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ready_list2);
            this.Controls.Add(this.ready_list1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Ready);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.DisplayHeader = false;
            this.Name = "GameRoom";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TransparencyKey = System.Drawing.SystemColors.InfoText;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameRoom_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ready_list1.ResumeLayout(false);
            this.ready_list2.ResumeLayout(false);
            this.chat_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox tbAnswer;
        private MetroFramework.Controls.MetroButton btn_ChatSend;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLimit;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Button btn_AnsSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Ready;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Panel ready_list1;
        private System.Windows.Forms.Panel ready_list2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel chat_list;
        private System.Windows.Forms.Button btn_exit;
    }
}

