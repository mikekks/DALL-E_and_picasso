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
            this.btn_createRoom = new MetroFramework.Controls.MetroButton();
            this.btn_Cancel = new MetroFramework.Controls.MetroButton();
            this.txt_roonName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_level = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmb_Thema = new MetroFramework.Controls.MetroComboBox();
            this.cmb_PartyCnt = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
<<<<<<< HEAD
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
=======
>>>>>>> develop
            this.SuspendLayout();
            // 
            // btn_createRoom
            // 
            this.btn_createRoom.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_createRoom.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_createRoom.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_createRoom.ForeColor = System.Drawing.Color.White;
            this.btn_createRoom.Location = new System.Drawing.Point(340, 220);
            this.btn_createRoom.Name = "btn_createRoom";
            this.btn_createRoom.Size = new System.Drawing.Size(75, 23);
            this.btn_createRoom.TabIndex = 0;
            this.btn_createRoom.Text = "만들기";
            this.btn_createRoom.UseCustomBackColor = true;
            this.btn_createRoom.UseCustomForeColor = true;
            this.btn_createRoom.UseSelectable = true;
            this.btn_createRoom.Click += new System.EventHandler(this.btn_createRoom_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Cancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(430, 220);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "나가기";
            this.btn_Cancel.UseCustomBackColor = true;
            this.btn_Cancel.UseCustomForeColor = true;
            this.btn_Cancel.UseSelectable = true;
            this.btn_Cancel.Click += new System.EventHandler(this.metroButton2_Click);
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
<<<<<<< HEAD
            this.txt_roonName.Location = new System.Drawing.Point(130, 26);
=======
            this.txt_roonName.Location = new System.Drawing.Point(144, 86);
>>>>>>> develop
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(55, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "방 제목";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txt_level
            // 
            this.txt_level.BackColor = System.Drawing.Color.Transparent;
            this.txt_level.LargeChange = 1;
            this.txt_level.Location = new System.Drawing.Point(130, 73);
            this.txt_level.Maximum = 5;
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(336, 23);
            this.txt_level.TabIndex = 4;
            this.txt_level.Text = "metroTrackBar1";
            this.txt_level.Value = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(59, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "난이도";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(73, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "주제";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
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
            this.cmb_Thema.Location = new System.Drawing.Point(130, 115);
            this.cmb_Thema.Name = "cmb_Thema";
            this.cmb_Thema.Size = new System.Drawing.Size(175, 29);
            this.cmb_Thema.TabIndex = 7;
            this.cmb_Thema.UseSelectable = true;
            // 
            // cmb_PartyCnt
            // 
            this.cmb_PartyCnt.FormattingEnabled = true;
            this.cmb_PartyCnt.ItemHeight = 23;
            this.cmb_PartyCnt.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cmb_PartyCnt.Location = new System.Drawing.Point(130, 160);
            this.cmb_PartyCnt.Name = "cmb_PartyCnt";
            this.cmb_PartyCnt.Size = new System.Drawing.Size(175, 29);
            this.cmb_PartyCnt.TabIndex = 8;
            this.cmb_PartyCnt.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(41, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "참여 인원";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
<<<<<<< HEAD
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.cmb_PartyCnt);
            this.metroPanel1.Controls.Add(this.txt_level);
            this.metroPanel1.Controls.Add(this.cmb_Thema);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.txt_roonName);
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_createRoom);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
=======
>>>>>>> develop
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
            this.metroPanel1.Visible = false;
            // 
<<<<<<< HEAD
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroButton2);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
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
            this.metroPanel2.Visible = false;
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
=======
>>>>>>> develop
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 337);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CreateRoomForm";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "방 만들기";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.CreateRoomForm_Load);
<<<<<<< HEAD
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
=======
>>>>>>> develop
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_Cancel;
        private MetroFramework.Controls.MetroTextBox txt_roonName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTrackBar txt_level;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmb_Thema;
        private MetroFramework.Controls.MetroComboBox cmb_PartyCnt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel1;
<<<<<<< HEAD
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btn_createRoom;
=======
>>>>>>> develop
    }
}