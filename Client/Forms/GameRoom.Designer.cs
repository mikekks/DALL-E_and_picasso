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
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.rdy_list = new System.Windows.Forms.RichTextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btn_Send = new MetroFramework.Controls.MetroButton();
            this.btn_Ready = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.btn_Start = new MetroFramework.Controls.MetroButton();
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(207, 296);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(366, 78);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
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
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(625, 38);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(155, 45);
            this.metroTile1.TabIndex = 15;
            this.metroTile1.Text = "남은 시간  01:00";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseSelectable = true;
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
            // GameRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 397);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btn_Ready);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.rdy_list);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.picBox);
            this.Name = "GameRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameRoom_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox rdy_list;
        private MetroFramework.Controls.MetroButton btn_Send;
        private MetroFramework.Controls.MetroButton btn_Ready;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton btn_Exit;
        private MetroFramework.Controls.MetroButton btn_Start;
    }
}

