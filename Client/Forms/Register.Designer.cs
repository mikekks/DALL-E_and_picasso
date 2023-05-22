namespace WindowsFormsApp2
{
    partial class Register_Form
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
            this.btn_Check = new System.Windows.Forms.Button();
            this.lab_Answer = new System.Windows.Forms.Label();
            this.lab_Quest = new System.Windows.Forms.Label();
            this.btn_IDcheck = new System.Windows.Forms.Button();
            this.lab_Mail = new System.Windows.Forms.Label();
            this.lab_RePW = new System.Windows.Forms.Label();
            this.lab_PW = new System.Windows.Forms.Label();
            this.lab_ID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prompt = new System.Windows.Forms.Label();
            this.tb_recovery_A = new MetroFramework.Controls.MetroTextBox();
            this.tb_nickName = new MetroFramework.Controls.MetroTextBox();
            this.tb_pwd_Check = new MetroFramework.Controls.MetroTextBox();
            this.tb_pwd = new MetroFramework.Controls.MetroTextBox();
            this.tb_id = new MetroFramework.Controls.MetroTextBox();
            this.recovery_Q = new MetroFramework.Controls.MetroComboBox();
            this.btn_Cancer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Check.FlatAppearance.BorderSize = 0;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Check.ForeColor = System.Drawing.Color.White;
            this.btn_Check.Location = new System.Drawing.Point(20, 270);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(76, 23);
            this.btn_Check.TabIndex = 40;
            this.btn_Check.Text = "확인";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // lab_Answer
            // 
            this.lab_Answer.AutoSize = true;
            this.lab_Answer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_Answer.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_Answer.ForeColor = System.Drawing.Color.White;
            this.lab_Answer.Location = new System.Drawing.Point(23, 223);
            this.lab_Answer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Answer.Name = "lab_Answer";
            this.lab_Answer.Size = new System.Drawing.Size(96, 17);
            this.lab_Answer.TabIndex = 39;
            this.lab_Answer.Text = "질문에 대한 답\r\n";
            // 
            // lab_Quest
            // 
            this.lab_Quest.AutoSize = true;
            this.lab_Quest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_Quest.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_Quest.ForeColor = System.Drawing.Color.White;
            this.lab_Quest.Location = new System.Drawing.Point(10, 183);
            this.lab_Quest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Quest.Name = "lab_Quest";
            this.lab_Quest.Size = new System.Drawing.Size(109, 17);
            this.lab_Quest.TabIndex = 37;
            this.lab_Quest.Text = "본인 확인용 질문";
            // 
            // btn_IDcheck
            // 
            this.btn_IDcheck.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_IDcheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IDcheck.FlatAppearance.BorderSize = 0;
            this.btn_IDcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IDcheck.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IDcheck.ForeColor = System.Drawing.Color.White;
            this.btn_IDcheck.Location = new System.Drawing.Point(137, 16);
            this.btn_IDcheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_IDcheck.Name = "btn_IDcheck";
            this.btn_IDcheck.Size = new System.Drawing.Size(64, 22);
            this.btn_IDcheck.TabIndex = 36;
            this.btn_IDcheck.Text = "중복확인";
            this.btn_IDcheck.UseVisualStyleBackColor = false;
            this.btn_IDcheck.Click += new System.EventHandler(this.btn_IDcheck_Click);
            // 
            // lab_Mail
            // 
            this.lab_Mail.AutoSize = true;
            this.lab_Mail.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_Mail.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_Mail.ForeColor = System.Drawing.Color.White;
            this.lab_Mail.Location = new System.Drawing.Point(70, 138);
            this.lab_Mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Mail.Name = "lab_Mail";
            this.lab_Mail.Size = new System.Drawing.Size(47, 17);
            this.lab_Mail.TabIndex = 31;
            this.lab_Mail.Text = "닉네임";
            // 
            // lab_RePW
            // 
            this.lab_RePW.AutoSize = true;
            this.lab_RePW.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_RePW.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_RePW.ForeColor = System.Drawing.Color.White;
            this.lab_RePW.Location = new System.Drawing.Point(27, 98);
            this.lab_RePW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_RePW.Name = "lab_RePW";
            this.lab_RePW.Size = new System.Drawing.Size(91, 17);
            this.lab_RePW.TabIndex = 30;
            this.lab_RePW.Text = "비밀번호 확인";
            // 
            // lab_PW
            // 
            this.lab_PW.AutoSize = true;
            this.lab_PW.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_PW.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_PW.ForeColor = System.Drawing.Color.White;
            this.lab_PW.Location = new System.Drawing.Point(57, 58);
            this.lab_PW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_PW.Name = "lab_PW";
            this.lab_PW.Size = new System.Drawing.Size(60, 17);
            this.lab_PW.TabIndex = 29;
            this.lab_PW.Text = "비밀번호";
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_ID.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_ID.ForeColor = System.Drawing.Color.White;
            this.lab_ID.Location = new System.Drawing.Point(70, 18);
            this.lab_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(47, 17);
            this.lab_ID.TabIndex = 28;
            this.lab_ID.Text = "아이디";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.lab_ID);
            this.panel1.Controls.Add(this.lab_RePW);
            this.panel1.Controls.Add(this.lab_PW);
            this.panel1.Controls.Add(this.lab_Answer);
            this.panel1.Controls.Add(this.lab_Mail);
            this.panel1.Controls.Add(this.lab_Quest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 313);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.prompt);
            this.panel2.Controls.Add(this.tb_recovery_A);
            this.panel2.Controls.Add(this.tb_nickName);
            this.panel2.Controls.Add(this.tb_pwd_Check);
            this.panel2.Controls.Add(this.tb_pwd);
            this.panel2.Controls.Add(this.tb_id);
            this.panel2.Controls.Add(this.recovery_Q);
            this.panel2.Controls.Add(this.btn_Cancer);
            this.panel2.Controls.Add(this.btn_Check);
            this.panel2.Controls.Add(this.btn_IDcheck);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(147, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 313);
            this.panel2.TabIndex = 45;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // prompt
            // 
            this.prompt.AutoSize = true;
            this.prompt.Location = new System.Drawing.Point(18, 242);
            this.prompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(0, 12);
            this.prompt.TabIndex = 48;
            // 
            // tb_recovery_A
            // 
            // 
            // 
            // 
            this.tb_recovery_A.CustomButton.Image = null;
            this.tb_recovery_A.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.tb_recovery_A.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_recovery_A.CustomButton.Name = "";
            this.tb_recovery_A.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_recovery_A.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_recovery_A.CustomButton.TabIndex = 1;
            this.tb_recovery_A.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_recovery_A.CustomButton.UseSelectable = true;
            this.tb_recovery_A.CustomButton.Visible = false;
            this.tb_recovery_A.Lines = new string[0];
            this.tb_recovery_A.Location = new System.Drawing.Point(10, 220);
            this.tb_recovery_A.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_recovery_A.MaxLength = 32767;
            this.tb_recovery_A.Name = "tb_recovery_A";
            this.tb_recovery_A.PasswordChar = '\0';
            this.tb_recovery_A.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_recovery_A.SelectedText = "";
            this.tb_recovery_A.SelectionLength = 0;
            this.tb_recovery_A.SelectionStart = 0;
            this.tb_recovery_A.ShortcutsEnabled = true;
            this.tb_recovery_A.Size = new System.Drawing.Size(189, 23);
            this.tb_recovery_A.TabIndex = 47;
            this.tb_recovery_A.UseSelectable = true;
            this.tb_recovery_A.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_recovery_A.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_nickName
            // 
            // 
            // 
            // 
            this.tb_nickName.CustomButton.Image = null;
            this.tb_nickName.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tb_nickName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_nickName.CustomButton.Name = "";
            this.tb_nickName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_nickName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_nickName.CustomButton.TabIndex = 1;
            this.tb_nickName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_nickName.CustomButton.UseSelectable = true;
            this.tb_nickName.CustomButton.Visible = false;
            this.tb_nickName.Lines = new string[0];
            this.tb_nickName.Location = new System.Drawing.Point(10, 135);
            this.tb_nickName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_nickName.MaxLength = 32767;
            this.tb_nickName.Name = "tb_nickName";
            this.tb_nickName.PasswordChar = '\0';
            this.tb_nickName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_nickName.SelectedText = "";
            this.tb_nickName.SelectionLength = 0;
            this.tb_nickName.SelectionStart = 0;
            this.tb_nickName.ShortcutsEnabled = true;
            this.tb_nickName.Size = new System.Drawing.Size(191, 23);
            this.tb_nickName.TabIndex = 46;
            this.tb_nickName.UseSelectable = true;
            this.tb_nickName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_nickName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_pwd_Check
            // 
            // 
            // 
            // 
            this.tb_pwd_Check.CustomButton.Image = null;
            this.tb_pwd_Check.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tb_pwd_Check.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_pwd_Check.CustomButton.Name = "";
            this.tb_pwd_Check.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_pwd_Check.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_pwd_Check.CustomButton.TabIndex = 1;
            this.tb_pwd_Check.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_pwd_Check.CustomButton.UseSelectable = true;
            this.tb_pwd_Check.CustomButton.Visible = false;
            this.tb_pwd_Check.Lines = new string[0];
            this.tb_pwd_Check.Location = new System.Drawing.Point(10, 95);
            this.tb_pwd_Check.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_pwd_Check.MaxLength = 32767;
            this.tb_pwd_Check.Name = "tb_pwd_Check";
            this.tb_pwd_Check.PasswordChar = '●';
            this.tb_pwd_Check.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_pwd_Check.SelectedText = "";
            this.tb_pwd_Check.SelectionLength = 0;
            this.tb_pwd_Check.SelectionStart = 0;
            this.tb_pwd_Check.ShortcutsEnabled = true;
            this.tb_pwd_Check.Size = new System.Drawing.Size(191, 23);
            this.tb_pwd_Check.TabIndex = 45;
            this.tb_pwd_Check.UseSelectable = true;
            this.tb_pwd_Check.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_pwd_Check.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_pwd
            // 
            // 
            // 
            // 
            this.tb_pwd.CustomButton.Image = null;
            this.tb_pwd.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tb_pwd.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_pwd.CustomButton.Name = "";
            this.tb_pwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_pwd.CustomButton.TabIndex = 1;
            this.tb_pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_pwd.CustomButton.UseSelectable = true;
            this.tb_pwd.CustomButton.Visible = false;
            this.tb_pwd.Lines = new string[0];
            this.tb_pwd.Location = new System.Drawing.Point(10, 55);
            this.tb_pwd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_pwd.MaxLength = 32767;
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '●';
            this.tb_pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_pwd.SelectedText = "";
            this.tb_pwd.SelectionLength = 0;
            this.tb_pwd.SelectionStart = 0;
            this.tb_pwd.ShortcutsEnabled = true;
            this.tb_pwd.Size = new System.Drawing.Size(191, 23);
            this.tb_pwd.TabIndex = 44;
            this.tb_pwd.UseSelectable = true;
            this.tb_pwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_pwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_id
            // 
            // 
            // 
            // 
            this.tb_id.CustomButton.Image = null;
            this.tb_id.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.tb_id.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_id.CustomButton.Name = "";
            this.tb_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_id.CustomButton.TabIndex = 1;
            this.tb_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_id.CustomButton.UseSelectable = true;
            this.tb_id.CustomButton.Visible = false;
            this.tb_id.Lines = new string[0];
            this.tb_id.Location = new System.Drawing.Point(10, 15);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_id.MaxLength = 32767;
            this.tb_id.Name = "tb_id";
            this.tb_id.PasswordChar = '\0';
            this.tb_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_id.SelectedText = "";
            this.tb_id.SelectionLength = 0;
            this.tb_id.SelectionStart = 0;
            this.tb_id.ShortcutsEnabled = true;
            this.tb_id.Size = new System.Drawing.Size(119, 23);
            this.tb_id.TabIndex = 43;
            this.tb_id.UseSelectable = true;
            this.tb_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // recovery_Q
            // 
            this.recovery_Q.FormattingEnabled = true;
            this.recovery_Q.ItemHeight = 23;
            this.recovery_Q.Items.AddRange(new object[] {
            "나의 보물 1호는?",
            "내 친한친구의 이름은?",
            "가장 재밌게 본 영화는?",
            "인상깊은 장소는?"});
            this.recovery_Q.Location = new System.Drawing.Point(10, 175);
            this.recovery_Q.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.recovery_Q.Name = "recovery_Q";
            this.recovery_Q.Size = new System.Drawing.Size(190, 29);
            this.recovery_Q.TabIndex = 42;
            this.recovery_Q.UseSelectable = true;
            // 
            // btn_Cancer
            // 
            this.btn_Cancer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Cancer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancer.FlatAppearance.BorderSize = 0;
            this.btn_Cancer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Cancer.ForeColor = System.Drawing.Color.White;
            this.btn_Cancer.Location = new System.Drawing.Point(113, 270);
            this.btn_Cancer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cancer.Name = "btn_Cancer";
            this.btn_Cancer.Size = new System.Drawing.Size(76, 23);
            this.btn_Cancer.TabIndex = 41;
            this.btn_Cancer.Text = "취소";
            this.btn_Cancer.UseVisualStyleBackColor = false;
            this.btn_Cancer.Click += new System.EventHandler(this.btn_Cancer_Click);
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Register_Form";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "회원가입";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Register_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label lab_Answer;
        private System.Windows.Forms.Label lab_Quest;
        private System.Windows.Forms.Button btn_IDcheck;
        private System.Windows.Forms.Label lab_Mail;
        private System.Windows.Forms.Label lab_RePW;
        private System.Windows.Forms.Label lab_PW;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Cancer;
        private MetroFramework.Controls.MetroTextBox tb_pwd;
        private MetroFramework.Controls.MetroTextBox tb_id;
        private MetroFramework.Controls.MetroComboBox recovery_Q;
        private MetroFramework.Controls.MetroTextBox tb_pwd_Check;
        private MetroFramework.Controls.MetroTextBox tb_recovery_A;
        private MetroFramework.Controls.MetroTextBox tb_nickName;
        private System.Windows.Forms.Label prompt;
    }
}