namespace Client
{
    partial class InGame
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
            this.timerLimit = new System.Windows.Forms.Timer(this.components);
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rdy_list = new System.Windows.Forms.RichTextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btn_Ready = new MetroFramework.Controls.MetroButton();
            this.btn_Send = new MetroFramework.Controls.MetroButton();
            this.btn_Start = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLimit
            // 
            this.timerLimit.Interval = 1000;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(521, 296);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(141, 21);
            this.tbAnswer.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(121, 296);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(366, 78);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(540, 89);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(182, 154);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // rdy_list
            // 
            this.rdy_list.Location = new System.Drawing.Point(8, 89);
            this.rdy_list.Name = "rdy_list";
            this.rdy_list.Size = new System.Drawing.Size(107, 154);
            this.rdy_list.TabIndex = 10;
            this.rdy_list.Text = "";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(647, 351);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "나가기";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(121, 63);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(366, 209);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.WaitOnLoad = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(552, 31);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(151, 52);
            this.metroTile1.TabIndex = 12;
            this.metroTile1.Text = "남은 시간 1:00";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseSelectable = true;
            // 
            // btn_Ready
            // 
            this.btn_Ready.Location = new System.Drawing.Point(668, 249);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(75, 23);
            this.btn_Ready.TabIndex = 13;
            this.btn_Ready.Text = "Ready";
            this.btn_Ready.UseSelectable = true;
            this.btn_Ready.Click += new System.EventHandler(this.btn_Ready_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(668, 294);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 14;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseSelectable = true;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(521, 249);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 16;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseSelectable = true;
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 397);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Ready);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.rdy_list);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.picBox);
            this.Name = "InGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Timer timerLimit;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rdy_list;
        private System.Windows.Forms.Button btn_exit;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton btn_Ready;
        private MetroFramework.Controls.MetroButton btn_Send;
        private MetroFramework.Controls.MetroButton btn_Start;
    }
}

