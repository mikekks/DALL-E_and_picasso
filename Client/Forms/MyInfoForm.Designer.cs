namespace Client.Forms
{
    partial class MyInfoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tier = new System.Windows.Forms.PictureBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_ans = new System.Windows.Forms.Label();
            this.lbl_Pans = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.TryCount = new System.Windows.Forms.Label();
            this.Ans = new System.Windows.Forms.Label();
            this.AnsRate = new System.Windows.Forms.Label();
            this.btn_unregister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btn_unregister);
            this.panel1.Controls.Add(this.AnsRate);
            this.panel1.Controls.Add(this.Ans);
            this.panel1.Controls.Add(this.TryCount);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.lbl_Pans);
            this.panel1.Controls.Add(this.lbl_ans);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.lbl_ID);
            this.panel1.Controls.Add(this.Tier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 295);
            this.panel1.TabIndex = 9;
            // 
            // Tier
            // 
            this.Tier.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Tier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tier.Location = new System.Drawing.Point(46, 10);
            this.Tier.Name = "Tier";
            this.Tier.Size = new System.Drawing.Size(129, 110);
            this.Tier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tier.TabIndex = 2;
            this.Tier.TabStop = false;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_ID.Location = new System.Drawing.Point(44, 135);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(28, 12);
            this.lbl_ID.TabIndex = 20;
            this.lbl_ID.Text = "ID : ";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_total.Location = new System.Drawing.Point(44, 165);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(69, 12);
            this.lbl_total.TabIndex = 21;
            this.lbl_total.Text = "시도 횟수 : ";
            // 
            // lbl_ans
            // 
            this.lbl_ans.AutoSize = true;
            this.lbl_ans.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_ans.Location = new System.Drawing.Point(44, 195);
            this.lbl_ans.Name = "lbl_ans";
            this.lbl_ans.Size = new System.Drawing.Size(69, 12);
            this.lbl_ans.TabIndex = 22;
            this.lbl_ans.Text = "정답 횟수 : ";
            // 
            // lbl_Pans
            // 
            this.lbl_Pans.AutoSize = true;
            this.lbl_Pans.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Pans.Location = new System.Drawing.Point(44, 225);
            this.lbl_Pans.Name = "lbl_Pans";
            this.lbl_Pans.Size = new System.Drawing.Size(53, 12);
            this.lbl_Pans.TabIndex = 23;
            this.lbl_Pans.Text = "정답률 : ";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ID.Location = new System.Drawing.Point(97, 135);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 12);
            this.ID.TabIndex = 24;
            this.ID.Text = "ID";
            // 
            // TryCount
            // 
            this.TryCount.AutoSize = true;
            this.TryCount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TryCount.Location = new System.Drawing.Point(119, 165);
            this.TryCount.Name = "TryCount";
            this.TryCount.Size = new System.Drawing.Size(19, 12);
            this.TryCount.TabIndex = 25;
            this.TryCount.Text = "try";
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Ans.Location = new System.Drawing.Point(119, 195);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(30, 12);
            this.Ans.TabIndex = 26;
            this.Ans.Text = "ANS";
            // 
            // AnsRate
            // 
            this.AnsRate.AutoSize = true;
            this.AnsRate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AnsRate.Location = new System.Drawing.Point(119, 225);
            this.AnsRate.Name = "AnsRate";
            this.AnsRate.Size = new System.Drawing.Size(30, 12);
            this.AnsRate.TabIndex = 27;
            this.AnsRate.Text = "Rate";
            // 
            // btn_unregister
            // 
            this.btn_unregister.BackColor = System.Drawing.Color.Yellow;
            this.btn_unregister.FlatAppearance.BorderSize = 0;
            this.btn_unregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unregister.Location = new System.Drawing.Point(142, 265);
            this.btn_unregister.Name = "btn_unregister";
            this.btn_unregister.Size = new System.Drawing.Size(75, 23);
            this.btn_unregister.TabIndex = 28;
            this.btn_unregister.Text = "회원탈퇴";
            this.btn_unregister.UseVisualStyleBackColor = false;
            this.btn_unregister.Click += new System.EventHandler(this.btn_unregister_Click_1);
            // 
            // MyInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 375);
            this.Controls.Add(this.panel1);
            this.Name = "MyInfoForm";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "내 정보";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.MyInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Tier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_unregister;
        private System.Windows.Forms.Label AnsRate;
        private System.Windows.Forms.Label Ans;
        private System.Windows.Forms.Label TryCount;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label lbl_Pans;
        private System.Windows.Forms.Label lbl_ans;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_ID;
    }
}