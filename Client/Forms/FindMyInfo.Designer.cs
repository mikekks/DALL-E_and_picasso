namespace Client.Forms
{
    partial class FindMyInfo
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
            this.label7 = new System.Windows.Forms.Label();
            this.lab_Answer = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_Quest = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.findId_tb_identificationNumber = new MetroFramework.Controls.MetroTextBox();
            this.prompt = new System.Windows.Forms.Label();
            this.findId_tb_recovery_A = new MetroFramework.Controls.MetroTextBox();
            this.findId_tb_name = new MetroFramework.Controls.MetroTextBox();
            this.findId_tb_recovery_Q = new MetroFramework.Controls.MetroComboBox();
            this.btn_Check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.findPw_tb_name = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.findPw_tb_recovery_A = new MetroFramework.Controls.MetroTextBox();
            this.findPw_tb_id = new MetroFramework.Controls.MetroTextBox();
            this.findPw_tb_recovery_Q = new MetroFramework.Controls.MetroComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lab_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.findPw_tb_identificationNumber = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lab_Answer);
            this.panel1.Controls.Add(this.lab_name);
            this.panel1.Controls.Add(this.lab_Quest);
            this.panel1.Location = new System.Drawing.Point(24, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 183);
            this.panel1.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "주민등록번호";
            // 
            // lab_Answer
            // 
            this.lab_Answer.AutoSize = true;
            this.lab_Answer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_Answer.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_Answer.ForeColor = System.Drawing.Color.White;
            this.lab_Answer.Location = new System.Drawing.Point(11, 130);
            this.lab_Answer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_Answer.Name = "lab_Answer";
            this.lab_Answer.Size = new System.Drawing.Size(124, 23);
            this.lab_Answer.TabIndex = 39;
            this.lab_Answer.Text = "질문에 대한 답\r\n";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_name.ForeColor = System.Drawing.Color.White;
            this.lab_name.Location = new System.Drawing.Point(11, 22);
            this.lab_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(44, 23);
            this.lab_name.TabIndex = 31;
            this.lab_name.Text = "이름";
            // 
            // lab_Quest
            // 
            this.lab_Quest.AutoSize = true;
            this.lab_Quest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_Quest.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_Quest.ForeColor = System.Drawing.Color.White;
            this.lab_Quest.Location = new System.Drawing.Point(11, 92);
            this.lab_Quest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_Quest.Name = "lab_Quest";
            this.lab_Quest.Size = new System.Drawing.Size(141, 23);
            this.lab_Quest.TabIndex = 37;
            this.lab_Quest.Text = "본인 확인용 질문";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.findId_tb_identificationNumber);
            this.panel2.Controls.Add(this.prompt);
            this.panel2.Controls.Add(this.findId_tb_recovery_A);
            this.panel2.Controls.Add(this.findId_tb_name);
            this.panel2.Controls.Add(this.findId_tb_recovery_Q);
            this.panel2.Location = new System.Drawing.Point(186, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 183);
            this.panel2.TabIndex = 46;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // findId_tb_identificationNumber
            // 
            // 
            // 
            // 
            this.findId_tb_identificationNumber.CustomButton.Image = null;
            this.findId_tb_identificationNumber.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.findId_tb_identificationNumber.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findId_tb_identificationNumber.CustomButton.Name = "";
            this.findId_tb_identificationNumber.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.findId_tb_identificationNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.findId_tb_identificationNumber.CustomButton.TabIndex = 1;
            this.findId_tb_identificationNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.findId_tb_identificationNumber.CustomButton.UseSelectable = true;
            this.findId_tb_identificationNumber.CustomButton.Visible = false;
            this.findId_tb_identificationNumber.Lines = new string[0];
            this.findId_tb_identificationNumber.Location = new System.Drawing.Point(13, 53);
            this.findId_tb_identificationNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findId_tb_identificationNumber.MaxLength = 32767;
            this.findId_tb_identificationNumber.Name = "findId_tb_identificationNumber";
            this.findId_tb_identificationNumber.PasswordChar = '\0';
            this.findId_tb_identificationNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.findId_tb_identificationNumber.SelectedText = "";
            this.findId_tb_identificationNumber.SelectionLength = 0;
            this.findId_tb_identificationNumber.SelectionStart = 0;
            this.findId_tb_identificationNumber.ShortcutsEnabled = true;
            this.findId_tb_identificationNumber.Size = new System.Drawing.Size(218, 29);
            this.findId_tb_identificationNumber.TabIndex = 49;
            this.findId_tb_identificationNumber.UseSelectable = true;
            this.findId_tb_identificationNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.findId_tb_identificationNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // prompt
            // 
            this.prompt.AutoSize = true;
            this.prompt.Location = new System.Drawing.Point(21, 302);
            this.prompt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(0, 15);
            this.prompt.TabIndex = 48;
            // 
            // findId_tb_recovery_A
            // 
            // 
            // 
            // 
            this.findId_tb_recovery_A.CustomButton.Image = null;
            this.findId_tb_recovery_A.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.findId_tb_recovery_A.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findId_tb_recovery_A.CustomButton.Name = "";
            this.findId_tb_recovery_A.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.findId_tb_recovery_A.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.findId_tb_recovery_A.CustomButton.TabIndex = 1;
            this.findId_tb_recovery_A.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.findId_tb_recovery_A.CustomButton.UseSelectable = true;
            this.findId_tb_recovery_A.CustomButton.Visible = false;
            this.findId_tb_recovery_A.Lines = new string[0];
            this.findId_tb_recovery_A.Location = new System.Drawing.Point(13, 131);
            this.findId_tb_recovery_A.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findId_tb_recovery_A.MaxLength = 32767;
            this.findId_tb_recovery_A.Name = "findId_tb_recovery_A";
            this.findId_tb_recovery_A.PasswordChar = '\0';
            this.findId_tb_recovery_A.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.findId_tb_recovery_A.SelectedText = "";
            this.findId_tb_recovery_A.SelectionLength = 0;
            this.findId_tb_recovery_A.SelectionStart = 0;
            this.findId_tb_recovery_A.ShortcutsEnabled = true;
            this.findId_tb_recovery_A.Size = new System.Drawing.Size(218, 29);
            this.findId_tb_recovery_A.TabIndex = 45;
            this.findId_tb_recovery_A.UseSelectable = true;
            this.findId_tb_recovery_A.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.findId_tb_recovery_A.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // findId_tb_name
            // 
            // 
            // 
            // 
            this.findId_tb_name.CustomButton.Image = null;
            this.findId_tb_name.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.findId_tb_name.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findId_tb_name.CustomButton.Name = "";
            this.findId_tb_name.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.findId_tb_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.findId_tb_name.CustomButton.TabIndex = 1;
            this.findId_tb_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.findId_tb_name.CustomButton.UseSelectable = true;
            this.findId_tb_name.CustomButton.Visible = false;
            this.findId_tb_name.Lines = new string[0];
            this.findId_tb_name.Location = new System.Drawing.Point(13, 16);
            this.findId_tb_name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findId_tb_name.MaxLength = 32767;
            this.findId_tb_name.Name = "findId_tb_name";
            this.findId_tb_name.PasswordChar = '\0';
            this.findId_tb_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.findId_tb_name.SelectedText = "";
            this.findId_tb_name.SelectionLength = 0;
            this.findId_tb_name.SelectionStart = 0;
            this.findId_tb_name.ShortcutsEnabled = true;
            this.findId_tb_name.Size = new System.Drawing.Size(218, 29);
            this.findId_tb_name.TabIndex = 44;
            this.findId_tb_name.UseSelectable = true;
            this.findId_tb_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.findId_tb_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.findId_tb_name.Click += new System.EventHandler(this.tb_pwd_Click);
            // 
            // findId_tb_recovery_Q
            // 
            this.findId_tb_recovery_Q.FormattingEnabled = true;
            this.findId_tb_recovery_Q.ItemHeight = 24;
            this.findId_tb_recovery_Q.Items.AddRange(new object[] {
            "나의 보물 1호는?",
            "내 친한친구의 이름은?",
            "가장 재밌게 본 영화는?",
            "인상깊은 장소는?"});
            this.findId_tb_recovery_Q.Location = new System.Drawing.Point(13, 93);
            this.findId_tb_recovery_Q.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findId_tb_recovery_Q.Name = "findId_tb_recovery_Q";
            this.findId_tb_recovery_Q.Size = new System.Drawing.Size(217, 30);
            this.findId_tb_recovery_Q.TabIndex = 42;
            this.findId_tb_recovery_Q.UseSelectable = true;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Check.FlatAppearance.BorderSize = 0;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Check.ForeColor = System.Drawing.Color.White;
            this.btn_Check.Location = new System.Drawing.Point(348, 278);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(87, 29);
            this.btn_Check.TabIndex = 40;
            this.btn_Check.Text = "찾기";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 47;
            this.label1.Text = "아이디 찾기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(19, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 38);
            this.label2.TabIndex = 51;
            this.label2.Text = "비밀번호 찾기";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.findPw_tb_identificationNumber);
            this.panel3.Controls.Add(this.findPw_tb_name);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.findPw_tb_recovery_A);
            this.panel3.Controls.Add(this.findPw_tb_id);
            this.panel3.Controls.Add(this.findPw_tb_recovery_Q);
            this.panel3.Location = new System.Drawing.Point(186, 367);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 209);
            this.panel3.TabIndex = 50;
            // 
            // findPw_tb_name
            // 
            // 
            // 
            // 
            this.findPw_tb_name.CustomButton.Image = null;
            this.findPw_tb_name.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.findPw_tb_name.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findPw_tb_name.CustomButton.Name = "";
            this.findPw_tb_name.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.findPw_tb_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.findPw_tb_name.CustomButton.TabIndex = 1;
            this.findPw_tb_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.findPw_tb_name.CustomButton.UseSelectable = true;
            this.findPw_tb_name.CustomButton.Visible = false;
            this.findPw_tb_name.Lines = new string[0];
            this.findPw_tb_name.Location = new System.Drawing.Point(13, 47);
            this.findPw_tb_name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findPw_tb_name.MaxLength = 32767;
            this.findPw_tb_name.Name = "findPw_tb_name";
            this.findPw_tb_name.PasswordChar = '\0';
            this.findPw_tb_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.findPw_tb_name.SelectedText = "";
            this.findPw_tb_name.SelectionLength = 0;
            this.findPw_tb_name.SelectionStart = 0;
            this.findPw_tb_name.ShortcutsEnabled = true;
            this.findPw_tb_name.Size = new System.Drawing.Size(218, 29);
            this.findPw_tb_name.TabIndex = 49;
            this.findPw_tb_name.UseSelectable = true;
            this.findPw_tb_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.findPw_tb_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 48;
            // 
            // findPw_tb_recovery_A
            // 
            // 
            // 
            // 
            this.findPw_tb_recovery_A.CustomButton.Image = null;
            this.findPw_tb_recovery_A.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.findPw_tb_recovery_A.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findPw_tb_recovery_A.CustomButton.Name = "";
            this.findPw_tb_recovery_A.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.findPw_tb_recovery_A.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.findPw_tb_recovery_A.CustomButton.TabIndex = 1;
            this.findPw_tb_recovery_A.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.findPw_tb_recovery_A.CustomButton.UseSelectable = true;
            this.findPw_tb_recovery_A.CustomButton.Visible = false;
            this.findPw_tb_recovery_A.Lines = new string[0];
            this.findPw_tb_recovery_A.Location = new System.Drawing.Point(13, 163);
            this.findPw_tb_recovery_A.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findPw_tb_recovery_A.MaxLength = 32767;
            this.findPw_tb_recovery_A.Name = "findPw_tb_recovery_A";
            this.findPw_tb_recovery_A.PasswordChar = '\0';
            this.findPw_tb_recovery_A.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.findPw_tb_recovery_A.SelectedText = "";
            this.findPw_tb_recovery_A.SelectionLength = 0;
            this.findPw_tb_recovery_A.SelectionStart = 0;
            this.findPw_tb_recovery_A.ShortcutsEnabled = true;
            this.findPw_tb_recovery_A.Size = new System.Drawing.Size(218, 29);
            this.findPw_tb_recovery_A.TabIndex = 45;
            this.findPw_tb_recovery_A.UseSelectable = true;
            this.findPw_tb_recovery_A.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.findPw_tb_recovery_A.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // findPw_tb_id
            // 
            // 
            // 
            // 
            this.findPw_tb_id.CustomButton.Image = null;
            this.findPw_tb_id.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.findPw_tb_id.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findPw_tb_id.CustomButton.Name = "";
            this.findPw_tb_id.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.findPw_tb_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.findPw_tb_id.CustomButton.TabIndex = 1;
            this.findPw_tb_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.findPw_tb_id.CustomButton.UseSelectable = true;
            this.findPw_tb_id.CustomButton.Visible = false;
            this.findPw_tb_id.Lines = new string[0];
            this.findPw_tb_id.Location = new System.Drawing.Point(13, 10);
            this.findPw_tb_id.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findPw_tb_id.MaxLength = 32767;
            this.findPw_tb_id.Name = "findPw_tb_id";
            this.findPw_tb_id.PasswordChar = '\0';
            this.findPw_tb_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.findPw_tb_id.SelectedText = "";
            this.findPw_tb_id.SelectionLength = 0;
            this.findPw_tb_id.SelectionStart = 0;
            this.findPw_tb_id.ShortcutsEnabled = true;
            this.findPw_tb_id.Size = new System.Drawing.Size(218, 29);
            this.findPw_tb_id.TabIndex = 44;
            this.findPw_tb_id.UseSelectable = true;
            this.findPw_tb_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.findPw_tb_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.findPw_tb_id.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // findPw_tb_recovery_Q
            // 
            this.findPw_tb_recovery_Q.FormattingEnabled = true;
            this.findPw_tb_recovery_Q.ItemHeight = 24;
            this.findPw_tb_recovery_Q.Items.AddRange(new object[] {
            "나의 보물 1호는?",
            "내 친한친구의 이름은?",
            "가장 재밌게 본 영화는?",
            "인상깊은 장소는?"});
            this.findPw_tb_recovery_Q.Location = new System.Drawing.Point(12, 125);
            this.findPw_tb_recovery_Q.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findPw_tb_recovery_Q.Name = "findPw_tb_recovery_Q";
            this.findPw_tb_recovery_Q.Size = new System.Drawing.Size(217, 30);
            this.findPw_tb_recovery_Q.TabIndex = 42;
            this.findPw_tb_recovery_Q.UseSelectable = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lab_ID);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(24, 367);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 209);
            this.panel4.TabIndex = 49;
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_ID.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_ID.ForeColor = System.Drawing.Color.White;
            this.lab_ID.Location = new System.Drawing.Point(11, 10);
            this.lab_ID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(61, 23);
            this.lab_ID.TabIndex = 40;
            this.lab_ID.Text = "아이디";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "질문에 대한 답\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "이름";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "본인 확인용 질문";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(350, 595);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 48;
            this.button1.Text = "찾기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "주민등록번호";
            // 
            // findPw_tb_identificationNumber
            // 
            // 
            // 
            // 
            this.findPw_tb_identificationNumber.CustomButton.Image = null;
            this.findPw_tb_identificationNumber.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.findPw_tb_identificationNumber.CustomButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findPw_tb_identificationNumber.CustomButton.Name = "";
            this.findPw_tb_identificationNumber.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.findPw_tb_identificationNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.findPw_tb_identificationNumber.CustomButton.TabIndex = 1;
            this.findPw_tb_identificationNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.findPw_tb_identificationNumber.CustomButton.UseSelectable = true;
            this.findPw_tb_identificationNumber.CustomButton.Visible = false;
            this.findPw_tb_identificationNumber.Lines = new string[0];
            this.findPw_tb_identificationNumber.Location = new System.Drawing.Point(12, 88);
            this.findPw_tb_identificationNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findPw_tb_identificationNumber.MaxLength = 32767;
            this.findPw_tb_identificationNumber.Name = "findPw_tb_identificationNumber";
            this.findPw_tb_identificationNumber.PasswordChar = '\0';
            this.findPw_tb_identificationNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.findPw_tb_identificationNumber.SelectedText = "";
            this.findPw_tb_identificationNumber.SelectionLength = 0;
            this.findPw_tb_identificationNumber.SelectionStart = 0;
            this.findPw_tb_identificationNumber.ShortcutsEnabled = true;
            this.findPw_tb_identificationNumber.Size = new System.Drawing.Size(218, 29);
            this.findPw_tb_identificationNumber.TabIndex = 50;
            this.findPw_tb_identificationNumber.UseSelectable = true;
            this.findPw_tb_identificationNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.findPw_tb_identificationNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FindMyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Check);
            this.Name = "FindMyInfo";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FindMyInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_Answer;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_Quest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label prompt;
        private MetroFramework.Controls.MetroTextBox findId_tb_recovery_A;
        private MetroFramework.Controls.MetroTextBox findId_tb_name;
        private MetroFramework.Controls.MetroComboBox findId_tb_recovery_Q;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox findPw_tb_recovery_A;
        private MetroFramework.Controls.MetroTextBox findPw_tb_id;
        private MetroFramework.Controls.MetroComboBox findPw_tb_recovery_Q;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox findPw_tb_name;
        private System.Windows.Forms.Label lab_ID;
        private MetroFramework.Controls.MetroTextBox findId_tb_identificationNumber;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox findPw_tb_identificationNumber;
        private System.Windows.Forms.Label label8;
    }
}