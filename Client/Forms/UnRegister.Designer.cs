namespace Client.Forms
{
    partial class UnRegister
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_no = new MetroFramework.Controls.MetroButton();
            this.btn_yes = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(184, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "그래도 탈퇴하시겠습니까?";
            // 
            // btn_no
            // 
            this.btn_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_no.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_no.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_no.ForeColor = System.Drawing.Color.White;
            this.btn_no.Location = new System.Drawing.Point(414, 139);
            this.btn_no.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(86, 29);
            this.btn_no.TabIndex = 7;
            this.btn_no.Text = "아니오";
            this.btn_no.UseCustomBackColor = true;
            this.btn_no.UseCustomForeColor = true;
            this.btn_no.UseSelectable = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_yes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_yes.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_yes.ForeColor = System.Drawing.Color.Red;
            this.btn_yes.Location = new System.Drawing.Point(364, 139);
            this.btn_yes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(44, 29);
            this.btn_yes.TabIndex = 8;
            this.btn_yes.Text = "예";
            this.btn_yes.UseCustomBackColor = true;
            this.btn_yes.UseCustomForeColor = true;
            this.btn_yes.UseSelectable = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // UnRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 192);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UnRegister";
            this.Text = "탈퇴 시 회원정보가 모두 사라집니다.";
            this.Load += new System.EventHandler(this.UnRegistercs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_no;
        private MetroFramework.Controls.MetroButton btn_yes;
    }
}