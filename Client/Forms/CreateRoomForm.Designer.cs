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
            this.SuspendLayout();
            // 
            // btn_createRoom
            // 
            this.btn_createRoom.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_createRoom.Location = new System.Drawing.Point(144, 291);
            this.btn_createRoom.Name = "btn_createRoom";
            this.btn_createRoom.Size = new System.Drawing.Size(75, 23);
            this.btn_createRoom.TabIndex = 0;
            this.btn_createRoom.Text = "만들기";
            this.btn_createRoom.UseSelectable = true;
            this.btn_createRoom.Click += new System.EventHandler(this.btn_createRoom_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Cancel.Location = new System.Drawing.Point(330, 291);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "나가기";
            this.btn_Cancel.UseSelectable = true;
            this.btn_Cancel.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txt_roonName
            // 
            // 
            // 
            // 
            this.txt_roonName.CustomButton.Image = null;
            this.txt_roonName.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.txt_roonName.CustomButton.Name = "";
            this.txt_roonName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_roonName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_roonName.CustomButton.TabIndex = 1;
            this.txt_roonName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_roonName.CustomButton.UseSelectable = true;
            this.txt_roonName.CustomButton.Visible = false;
            this.txt_roonName.Lines = new string[0];
            this.txt_roonName.Location = new System.Drawing.Point(144, 86);
            this.txt_roonName.MaxLength = 32767;
            this.txt_roonName.Name = "txt_roonName";
            this.txt_roonName.PasswordChar = '\0';
            this.txt_roonName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_roonName.SelectedText = "";
            this.txt_roonName.SelectionLength = 0;
            this.txt_roonName.SelectionStart = 0;
            this.txt_roonName.ShortcutsEnabled = true;
            this.txt_roonName.Size = new System.Drawing.Size(288, 23);
            this.txt_roonName.TabIndex = 2;
            this.txt_roonName.UseSelectable = true;
            this.txt_roonName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_roonName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "방 제목 : ";
            // 
            // txt_level
            // 
            this.txt_level.BackColor = System.Drawing.Color.Transparent;
            this.txt_level.LargeChange = 1;
            this.txt_level.Location = new System.Drawing.Point(144, 131);
            this.txt_level.Maximum = 5;
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(272, 23);
            this.txt_level.TabIndex = 4;
            this.txt_level.Text = "metroTrackBar1";
            this.txt_level.Value = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(67, 131);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "난이도 : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(81, 174);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "주제 : ";
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
            this.cmb_Thema.Location = new System.Drawing.Point(144, 166);
            this.cmb_Thema.Name = "cmb_Thema";
            this.cmb_Thema.Size = new System.Drawing.Size(121, 29);
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
            this.cmb_PartyCnt.Location = new System.Drawing.Point(144, 226);
            this.cmb_PartyCnt.Name = "cmb_PartyCnt";
            this.cmb_PartyCnt.Size = new System.Drawing.Size(121, 29);
            this.cmb_PartyCnt.TabIndex = 8;
            this.cmb_PartyCnt.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(49, 229);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "참여 인원 : ";
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(49, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(477, 254);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 337);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmb_PartyCnt);
            this.Controls.Add(this.cmb_Thema);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_level);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_roonName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_createRoom);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CreateRoomForm";
            this.Text = "방 만들기";
            this.Load += new System.EventHandler(this.CreateRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_createRoom;
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
    }
}