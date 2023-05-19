﻿namespace Client
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.rdy_list = new System.Windows.Forms.RichTextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btn_Send = new MetroFramework.Controls.MetroButton();
            this.btn_Ready = new MetroFramework.Controls.MetroButton();
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.btn_Start = new MetroFramework.Controls.MetroButton();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timeLimit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Answer1 = new MetroFramework.Controls.MetroTile();
            this.Answer2 = new MetroFramework.Controls.MetroTile();
            this.Answer3 = new MetroFramework.Controls.MetroTile();
            this.Answer4 = new MetroFramework.Controls.MetroTile();
            this.Answer5 = new MetroFramework.Controls.MetroTile();
            this.Answer6 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(584, 298);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(141, 21);
            this.tbAnswer.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "테스트버튼";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(608, 89);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(182, 154);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // rdy_list
            // 
            this.rdy_list.Location = new System.Drawing.Point(8, 63);
            this.rdy_list.Name = "rdy_list";
            this.rdy_list.Size = new System.Drawing.Size(193, 218);
            this.rdy_list.TabIndex = 10;
            this.rdy_list.Text = "";
            this.rdy_list.TextChanged += new System.EventHandler(this.rdy_list_TextChanged);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(207, 63);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(366, 209);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.WaitOnLoad = true;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(731, 296);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 13;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseSelectable = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Ready
            // 
            this.btn_Ready.Location = new System.Drawing.Point(715, 249);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(75, 23);
            this.btn_Ready.TabIndex = 14;
            this.btn_Ready.Text = "Ready";
            this.btn_Ready.UseSelectable = true;
            this.btn_Ready.Click += new System.EventHandler(this.btn_Ready_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Exit.Location = new System.Drawing.Point(731, 351);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseSelectable = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(608, 249);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 17;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseSelectable = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
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
            this.label1.Location = new System.Drawing.Point(596, 60);
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
            this.timeLimit.Location = new System.Drawing.Point(711, 60);
            this.timeLimit.Name = "timeLimit";
            this.timeLimit.Size = new System.Drawing.Size(31, 19);
            this.timeLimit.TabIndex = 19;
            this.timeLimit.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F);
            this.label3.Location = new System.Drawing.Point(748, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "초";
            // 
            // Answer1
            // 
            this.Answer1.ActiveControl = null;
            this.Answer1.Location = new System.Drawing.Point(207, 287);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(95, 47);
            this.Answer1.Style = MetroFramework.MetroColorStyle.Orange;
            this.Answer1.TabIndex = 21;
            this.Answer1.Text = "뭘까요?";
            this.Answer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer1.UseSelectable = true;
            // 
            // Answer2
            // 
            this.Answer2.ActiveControl = null;
            this.Answer2.Location = new System.Drawing.Point(344, 287);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(95, 47);
            this.Answer2.TabIndex = 22;
            this.Answer2.Text = "뭘까요?";
            this.Answer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer2.UseSelectable = true;
            // 
            // Answer3
            // 
            this.Answer3.ActiveControl = null;
            this.Answer3.Location = new System.Drawing.Point(478, 287);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(95, 47);
            this.Answer3.Style = MetroFramework.MetroColorStyle.Pink;
            this.Answer3.TabIndex = 23;
            this.Answer3.Text = "뭘까요?";
            this.Answer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer3.UseSelectable = true;
            // 
            // Answer4
            // 
            this.Answer4.ActiveControl = null;
            this.Answer4.Location = new System.Drawing.Point(207, 352);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(95, 47);
            this.Answer4.Style = MetroFramework.MetroColorStyle.Green;
            this.Answer4.TabIndex = 24;
            this.Answer4.Text = "뭘까요?";
            this.Answer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer4.UseSelectable = true;
            // 
            // Answer5
            // 
            this.Answer5.ActiveControl = null;
            this.Answer5.Location = new System.Drawing.Point(344, 351);
            this.Answer5.Name = "Answer5";
            this.Answer5.Size = new System.Drawing.Size(95, 47);
            this.Answer5.Style = MetroFramework.MetroColorStyle.Purple;
            this.Answer5.TabIndex = 25;
            this.Answer5.Text = "뭘까요?";
            this.Answer5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer5.UseSelectable = true;
            // 
            // Answer6
            // 
            this.Answer6.ActiveControl = null;
            this.Answer6.Location = new System.Drawing.Point(478, 351);
            this.Answer6.Name = "Answer6";
            this.Answer6.Size = new System.Drawing.Size(95, 47);
            this.Answer6.Style = MetroFramework.MetroColorStyle.Silver;
            this.Answer6.TabIndex = 26;
            this.Answer6.Text = "뭘까요?";
            this.Answer6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer6.UseSelectable = true;
            // 
            // GameRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 422);
            this.Controls.Add(this.Answer6);
            this.Controls.Add(this.Answer5);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Ready);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.rdy_list);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.picBox);
            this.Name = "GameRoom";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameRoom_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox rdy_list;
        private MetroFramework.Controls.MetroButton btn_Send;
        private MetroFramework.Controls.MetroButton btn_Ready;
        private MetroFramework.Controls.MetroButton btn_Exit;
        private MetroFramework.Controls.MetroButton btn_Start;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLimit;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTile Answer1;
        private MetroFramework.Controls.MetroTile Answer2;
        private MetroFramework.Controls.MetroTile Answer3;
        private MetroFramework.Controls.MetroTile Answer4;
        private MetroFramework.Controls.MetroTile Answer5;
        private MetroFramework.Controls.MetroTile Answer6;
    }
}

