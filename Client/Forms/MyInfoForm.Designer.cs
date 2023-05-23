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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Tier)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_ID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(66, 188);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(34, 19);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID : ";
            this.lbl_ID.UseCustomBackColor = true;
            this.lbl_ID.UseCustomForeColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_total.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(66, 218);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(62, 19);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "플레이 : ";
            this.lbl_total.UseCustomBackColor = true;
            this.lbl_total.UseCustomForeColor = true;
            // 
            // Tier
            // 
            this.Tier.BackColor = System.Drawing.Color.White;
            this.Tier.Location = new System.Drawing.Point(46, 10);
            this.Tier.Name = "Tier";
            this.Tier.Size = new System.Drawing.Size(129, 110);
            this.Tier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tier.TabIndex = 2;
            this.Tier.TabStop = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(130, 188);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(65, 19);
            this.ID.TabIndex = 3;
            this.ID.Text = "Song1234";
            this.ID.UseCustomBackColor = true;
            this.ID.UseCustomForeColor = true;
            // 
            // TryCount
            // 
            this.TryCount.AutoSize = true;
            this.TryCount.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TryCount.ForeColor = System.Drawing.Color.White;
            this.TryCount.Location = new System.Drawing.Point(174, 218);
            this.TryCount.Name = "TryCount";
            this.TryCount.Size = new System.Drawing.Size(21, 19);
            this.TryCount.TabIndex = 4;
            this.TryCount.Text = "10";
            this.TryCount.UseCustomBackColor = true;
            this.TryCount.UseCustomForeColor = true;
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Ans.ForeColor = System.Drawing.Color.White;
            this.Ans.Location = new System.Drawing.Point(179, 248);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(16, 19);
            this.Ans.TabIndex = 6;
            this.Ans.Text = "7";
            this.Ans.UseCustomBackColor = true;
            this.Ans.UseCustomForeColor = true;
            // 
            // lbl_ans
            // 
            this.lbl_ans.AutoSize = true;
            this.lbl_ans.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_ans.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_ans.ForeColor = System.Drawing.Color.White;
            this.lbl_ans.Location = new System.Drawing.Point(66, 248);
            this.lbl_ans.Name = "lbl_ans";
            this.lbl_ans.Size = new System.Drawing.Size(48, 19);
            this.lbl_ans.TabIndex = 5;
            this.lbl_ans.Text = "정답 : ";
            this.lbl_ans.UseCustomBackColor = true;
            this.lbl_ans.UseCustomForeColor = true;
            // 
            // AnsRate
            // 
            this.AnsRate.AutoSize = true;
            this.AnsRate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AnsRate.ForeColor = System.Drawing.Color.White;
            this.AnsRate.Location = new System.Drawing.Point(161, 278);
            this.AnsRate.Name = "AnsRate";
            this.AnsRate.Size = new System.Drawing.Size(34, 19);
            this.AnsRate.TabIndex = 8;
            this.AnsRate.Text = "70%";
            this.AnsRate.UseCustomBackColor = true;
            this.AnsRate.UseCustomForeColor = true;
            // 
            // lbl_Pans
            // 
            this.lbl_Pans.AutoSize = true;
            this.lbl_Pans.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Pans.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_Pans.ForeColor = System.Drawing.Color.White;
            this.lbl_Pans.Location = new System.Drawing.Point(66, 278);
            this.lbl_Pans.Name = "lbl_Pans";
            this.lbl_Pans.Size = new System.Drawing.Size(62, 19);
            this.lbl_Pans.TabIndex = 7;
            this.lbl_Pans.Text = "정답률 : ";
            this.lbl_Pans.UseCustomBackColor = true;
            this.lbl_Pans.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.Tier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 247);
            this.panel1.TabIndex = 9;
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
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.panel1);
            this.Name = "MyInfoForm";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "내 정보";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.MyInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tier)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
    }
}