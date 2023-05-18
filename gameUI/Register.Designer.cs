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
            this.btn_Cancer = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.lab_Answer = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.lab_Quest = new System.Windows.Forms.Label();
            this.btn_IDcheck = new System.Windows.Forms.Button();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.txt_RePW = new System.Windows.Forms.TextBox();
            this.lab_Mail = new System.Windows.Forms.Label();
            this.lab_RePW = new System.Windows.Forms.Label();
            this.lab_PW = new System.Windows.Forms.Label();
            this.lab_ID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancer
            // 
            this.btn_Cancer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Cancer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancer.FlatAppearance.BorderSize = 0;
            this.btn_Cancer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancer.Font = new System.Drawing.Font("Agency FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancer.ForeColor = System.Drawing.Color.White;
            this.btn_Cancer.Location = new System.Drawing.Point(100, 291);
            this.btn_Cancer.Name = "btn_Cancer";
            this.btn_Cancer.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancer.TabIndex = 41;
            this.btn_Cancer.Text = "취소";
            this.btn_Cancer.UseVisualStyleBackColor = false;
            this.btn_Cancer.Click += new System.EventHandler(this.btn_Cancer_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Check.FlatAppearance.BorderSize = 0;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("Agency FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.ForeColor = System.Drawing.Color.White;
            this.btn_Check.Location = new System.Drawing.Point(19, 291);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(75, 23);
            this.btn_Check.TabIndex = 40;
            this.btn_Check.Text = "확인";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // lab_Answer
            // 
            this.lab_Answer.AutoSize = true;
            this.lab_Answer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_Answer.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Answer.ForeColor = System.Drawing.Color.White;
            this.lab_Answer.Location = new System.Drawing.Point(33, 232);
            this.lab_Answer.Name = "lab_Answer";
            this.lab_Answer.Size = new System.Drawing.Size(92, 17);
            this.lab_Answer.TabIndex = 39;
            this.lab_Answer.Text = "질문에 대한 답\r\n";
            // 
            // txt_Answer
            // 
            this.txt_Answer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Answer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Answer.Location = new System.Drawing.Point(8, 230);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(169, 19);
            this.txt_Answer.TabIndex = 38;
            // 
            // lab_Quest
            // 
            this.lab_Quest.AutoSize = true;
            this.lab_Quest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_Quest.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Quest.ForeColor = System.Drawing.Color.White;
            this.lab_Quest.Location = new System.Drawing.Point(20, 199);
            this.lab_Quest.Name = "lab_Quest";
            this.lab_Quest.Size = new System.Drawing.Size(105, 17);
            this.lab_Quest.TabIndex = 37;
            this.lab_Quest.Text = "본인 확인용 질문";
            // 
            // btn_IDcheck
            // 
            this.btn_IDcheck.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_IDcheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IDcheck.FlatAppearance.BorderSize = 0;
            this.btn_IDcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IDcheck.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IDcheck.ForeColor = System.Drawing.Color.White;
            this.btn_IDcheck.Location = new System.Drawing.Point(113, 54);
            this.btn_IDcheck.Name = "btn_IDcheck";
            this.btn_IDcheck.Size = new System.Drawing.Size(64, 22);
            this.btn_IDcheck.TabIndex = 36;
            this.btn_IDcheck.Text = "중복확인";
            this.btn_IDcheck.UseVisualStyleBackColor = false;
            this.btn_IDcheck.Click += new System.EventHandler(this.btn_IDcheck_Click);
            // 
            // txt_Mail
            // 
            this.txt_Mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Mail.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mail.Location = new System.Drawing.Point(8, 161);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(169, 19);
            this.txt_Mail.TabIndex = 35;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.White;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(8, 126);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(169, 19);
            this.txt_ID.TabIndex = 34;
            // 
            // txt_PW
            // 
            this.txt_PW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PW.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PW.Location = new System.Drawing.Point(8, 91);
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.Size = new System.Drawing.Size(169, 19);
            this.txt_PW.TabIndex = 33;
            // 
            // txt_RePW
            // 
            this.txt_RePW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_RePW.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RePW.Location = new System.Drawing.Point(8, 56);
            this.txt_RePW.Name = "txt_RePW";
            this.txt_RePW.Size = new System.Drawing.Size(99, 19);
            this.txt_RePW.TabIndex = 32;
            // 
            // lab_Mail
            // 
            this.lab_Mail.AutoSize = true;
            this.lab_Mail.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_Mail.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Mail.ForeColor = System.Drawing.Color.White;
            this.lab_Mail.Location = new System.Drawing.Point(80, 163);
            this.lab_Mail.Name = "lab_Mail";
            this.lab_Mail.Size = new System.Drawing.Size(47, 17);
            this.lab_Mail.TabIndex = 31;
            this.lab_Mail.Text = "이메일";
            // 
            // lab_RePW
            // 
            this.lab_RePW.AutoSize = true;
            this.lab_RePW.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_RePW.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_RePW.ForeColor = System.Drawing.Color.White;
            this.lab_RePW.Location = new System.Drawing.Point(37, 128);
            this.lab_RePW.Name = "lab_RePW";
            this.lab_RePW.Size = new System.Drawing.Size(89, 17);
            this.lab_RePW.TabIndex = 30;
            this.lab_RePW.Text = "비밀번호 확인";
            // 
            // lab_PW
            // 
            this.lab_PW.AutoSize = true;
            this.lab_PW.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_PW.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PW.ForeColor = System.Drawing.Color.White;
            this.lab_PW.Location = new System.Drawing.Point(67, 93);
            this.lab_PW.Name = "lab_PW";
            this.lab_PW.Size = new System.Drawing.Size(60, 17);
            this.lab_PW.TabIndex = 29;
            this.lab_PW.Text = "비밀번호";
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lab_ID.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ID.ForeColor = System.Drawing.Color.White;
            this.lab_ID.Location = new System.Drawing.Point(80, 58);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(47, 17);
            this.lab_ID.TabIndex = 28;
            this.lab_ID.Text = "아이디";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 25);
            this.comboBox1.TabIndex = 42;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Cancel.Location = new System.Drawing.Point(305, 0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(30, 27);
            this.btn_Cancel.TabIndex = 43;
            this.btn_Cancel.Text = "x";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 340);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Cancer);
            this.panel2.Controls.Add(this.btn_Check);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txt_Answer);
            this.panel2.Controls.Add(this.btn_IDcheck);
            this.panel2.Controls.Add(this.txt_RePW);
            this.panel2.Controls.Add(this.txt_PW);
            this.panel2.Controls.Add(this.txt_ID);
            this.panel2.Controls.Add(this.txt_Mail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(125, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 340);
            this.panel2.TabIndex = 45;
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 340);
            this.Controls.Add(this.lab_ID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lab_Answer);
            this.Controls.Add(this.lab_Quest);
            this.Controls.Add(this.lab_Mail);
            this.Controls.Add(this.lab_RePW);
            this.Controls.Add(this.lab_PW);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register_Form";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancer;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label lab_Answer;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Label lab_Quest;
        private System.Windows.Forms.Button btn_IDcheck;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.TextBox txt_RePW;
        private System.Windows.Forms.Label lab_Mail;
        private System.Windows.Forms.Label lab_RePW;
        private System.Windows.Forms.Label lab_PW;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}