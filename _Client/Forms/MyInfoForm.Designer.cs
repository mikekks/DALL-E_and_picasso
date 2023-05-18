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
            this.lbl_ID = new MetroFramework.Controls.MetroLabel();
            this.lbl_total = new MetroFramework.Controls.MetroLabel();
            this.Tier = new System.Windows.Forms.PictureBox();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.TryCount = new MetroFramework.Controls.MetroLabel();
            this.Ans = new MetroFramework.Controls.MetroLabel();
            this.lbl_ans = new MetroFramework.Controls.MetroLabel();
            this.AnsRate = new MetroFramework.Controls.MetroLabel();
            this.lbl_Pans = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Tier)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(66, 199);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(32, 19);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID : ";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(36, 230);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(62, 19);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "플레이 : ";
            // 
            // Tier
            // 
            this.Tier.Location = new System.Drawing.Point(66, 73);
            this.Tier.Name = "Tier";
            this.Tier.Size = new System.Drawing.Size(129, 110);
            this.Tier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tier.TabIndex = 2;
            this.Tier.TabStop = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(104, 199);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(65, 19);
            this.ID.TabIndex = 3;
            this.ID.Text = "Song1234";
            // 
            // TryCount
            // 
            this.TryCount.AutoSize = true;
            this.TryCount.Location = new System.Drawing.Point(104, 230);
            this.TryCount.Name = "TryCount";
            this.TryCount.Size = new System.Drawing.Size(21, 19);
            this.TryCount.TabIndex = 4;
            this.TryCount.Text = "10";
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.Location = new System.Drawing.Point(104, 260);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(16, 19);
            this.Ans.TabIndex = 6;
            this.Ans.Text = "7";
            // 
            // lbl_ans
            // 
            this.lbl_ans.AutoSize = true;
            this.lbl_ans.Location = new System.Drawing.Point(50, 260);
            this.lbl_ans.Name = "lbl_ans";
            this.lbl_ans.Size = new System.Drawing.Size(48, 19);
            this.lbl_ans.TabIndex = 5;
            this.lbl_ans.Text = "정답 : ";
            // 
            // AnsRate
            // 
            this.AnsRate.AutoSize = true;
            this.AnsRate.Location = new System.Drawing.Point(104, 288);
            this.AnsRate.Name = "AnsRate";
            this.AnsRate.Size = new System.Drawing.Size(34, 19);
            this.AnsRate.TabIndex = 8;
            this.AnsRate.Text = "70%";
            // 
            // lbl_Pans
            // 
            this.lbl_Pans.AutoSize = true;
            this.lbl_Pans.Location = new System.Drawing.Point(36, 288);
            this.lbl_Pans.Name = "lbl_Pans";
            this.lbl_Pans.Size = new System.Drawing.Size(62, 19);
            this.lbl_Pans.TabIndex = 7;
            this.lbl_Pans.Text = "정답률 : ";
            // 
            // MyInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 327);
            this.Controls.Add(this.AnsRate);
            this.Controls.Add(this.lbl_Pans);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.lbl_ans);
            this.Controls.Add(this.TryCount);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Tier);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_ID);
            this.Name = "MyInfoForm";
            this.Text = "내 정보";
            this.Load += new System.EventHandler(this.MyInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_ID;
        private MetroFramework.Controls.MetroLabel lbl_total;
        private System.Windows.Forms.PictureBox Tier;
        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroLabel TryCount;
        private MetroFramework.Controls.MetroLabel Ans;
        private MetroFramework.Controls.MetroLabel lbl_ans;
        private MetroFramework.Controls.MetroLabel AnsRate;
        private MetroFramework.Controls.MetroLabel lbl_Pans;
    }
}