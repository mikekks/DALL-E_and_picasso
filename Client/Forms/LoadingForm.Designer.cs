namespace Client.Forms
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.loadingTime = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.loadingTime);
            this.metroPanel1.Controls.Add(this.metroProgressSpinner1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(362, 195);
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(121, 12);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(117, 94);
            this.metroProgressSpinner1.Speed = 3F;
            this.metroProgressSpinner1.TabIndex = 16;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // loadingTimer
            // 
            this.loadingTimer.Enabled = true;
            this.loadingTimer.Interval = 1000;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // loadingTime
            // 
            this.loadingTime.AutoSize = true;
            this.loadingTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loadingTime.Location = new System.Drawing.Point(13, 150);
            this.loadingTime.Name = "loadingTime";
            this.loadingTime.Size = new System.Drawing.Size(333, 28);
            this.loadingTime.TabIndex = 17;
            this.loadingTime.Text = "다음 게임이 시작 됩니다.";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(402, 275);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Movable = false;
            this.Name = "LoadingForm";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadingForm_FormClosing);
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.Label loadingTime;
        private System.Windows.Forms.Timer loadingTimer;
    }
}