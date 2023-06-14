namespace Client.Forms
{
    partial class CreateRoomForm
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
            this.txt_roonName = new MetroFramework.Controls.MetroTextBox();
            this.txt_level = new MetroFramework.Controls.MetroTrackBar();
            this.cmb_Thema = new MetroFramework.Controls.MetroComboBox();
            this.cmb_TotalCnt = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_createRoom = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_roonName
            // 
            // 
            // 
            // 
            this.txt_roonName.CustomButton.Image = null;
            this.txt_roonName.CustomButton.Location = new System.Drawing.Point(314, 1);
            this.txt_roonName.CustomButton.Name = "";
            this.txt_roonName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_roonName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_roonName.CustomButton.TabIndex = 1;
            this.txt_roonName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_roonName.CustomButton.UseSelectable = true;
            this.txt_roonName.CustomButton.Visible = false;
            this.txt_roonName.Lines = new string[0];
            this.txt_roonName.Location = new System.Drawing.Point(130, 26);
            this.txt_roonName.MaxLength = 32767;
            this.txt_roonName.Name = "txt_roonName";
            this.txt_roonName.PasswordChar = '\0';
            this.txt_roonName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_roonName.SelectedText = "";
            this.txt_roonName.SelectionLength = 0;
            this.txt_roonName.SelectionStart = 0;
            this.txt_roonName.ShortcutsEnabled = true;
            this.txt_roonName.Size = new System.Drawing.Size(336, 23);
            this.txt_roonName.TabIndex = 2;
            this.txt_roonName.UseSelectable = true;
            this.txt_roonName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_roonName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_level
            // 
            this.txt_level.BackColor = System.Drawing.Color.Transparent;
            this.txt_level.LargeChange = 1;
            this.txt_level.Location = new System.Drawing.Point(130, 77);
            this.txt_level.Maximum = 5;
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(336, 23);
            this.txt_level.TabIndex = 4;
            this.txt_level.Text = "metroTrackBar1";
            this.txt_level.Value = 2;
            // 
            // cmb_Thema
            // 
            this.cmb_Thema.FormattingEnabled = true;
            this.cmb_Thema.ItemHeight = 23;
            this.cmb_Thema.Items.AddRange(new object[] {
            "동물",
            "식물",
            "직업",
            "나라",
            "인물"});
            this.cmb_Thema.Location = new System.Drawing.Point(130, 123);
            this.cmb_Thema.Name = "cmb_Thema";
            this.cmb_Thema.Size = new System.Drawing.Size(175, 29);
            this.cmb_Thema.TabIndex = 7;
            this.cmb_Thema.UseSelectable = true;
            // 
            // cmb_TotalCnt
            // 
            this.cmb_TotalCnt.FormattingEnabled = true;
            this.cmb_TotalCnt.ItemHeight = 23;
            this.cmb_TotalCnt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmb_TotalCnt.Location = new System.Drawing.Point(130, 174);
            this.cmb_TotalCnt.Name = "cmb_TotalCnt";
            this.cmb_TotalCnt.Size = new System.Drawing.Size(175, 29);
            this.cmb_TotalCnt.TabIndex = 8;
            this.cmb_TotalCnt.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_createRoom);
            this.metroPanel1.Controls.Add(this.txt_roonName);
            this.metroPanel1.Controls.Add(this.cmb_TotalCnt);
            this.metroPanel1.Controls.Add(this.txt_level);
            this.metroPanel1.Controls.Add(this.cmb_Thema);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(523, 257);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.metroPanel2.Controls.Add(this.label4);
            this.metroPanel2.Controls.Add(this.label3);
            this.metroPanel2.Controls.Add(this.label2);
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Controls.Add(this.metroButton2);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(118, 257);
            this.metroPanel2.TabIndex = 11;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(310, 219);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "나가기";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(140, 219);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 0;
            this.metroButton2.Text = "만들기";
            this.metroButton2.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "  방 제목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "   난이도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "     주제";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(19, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "참여 인원";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(207, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "방 만들기";
            // 
            // btn_createRoom
            // 
            this.btn_createRoom.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_createRoom.FlatAppearance.BorderSize = 0;
            this.btn_createRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createRoom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_createRoom.Location = new System.Drawing.Point(344, 220);
            this.btn_createRoom.Name = "btn_createRoom";
            this.btn_createRoom.Size = new System.Drawing.Size(75, 23);
            this.btn_createRoom.TabIndex = 12;
            this.btn_createRoom.Text = "만들기";
            this.btn_createRoom.UseVisualStyleBackColor = false;
            this.btn_createRoom.Click += new System.EventHandler(this.btn_createRoom_Click_1);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Cancel.Location = new System.Drawing.Point(434, 219);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "나가기";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CreateRoomForm";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.CreateRoomForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txt_roonName;
        private MetroFramework.Controls.MetroTrackBar txt_level;
        private MetroFramework.Controls.MetroComboBox cmb_Thema;
        private MetroFramework.Controls.MetroComboBox cmb_TotalCnt;
        private MetroFramework.Controls.MetroPanel metroPanel1;

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_createRoom;
        private System.Windows.Forms.Button btn_Cancel;
    }
}