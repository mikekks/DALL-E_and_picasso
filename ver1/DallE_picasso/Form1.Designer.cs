namespace DallE_picasso
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.client_log = new System.Windows.Forms.RichTextBox();
            this.client_list = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdyPeople = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // client_log
            // 
            this.client_log.Location = new System.Drawing.Point(38, 217);
            this.client_log.Name = "client_log";
            this.client_log.Size = new System.Drawing.Size(290, 99);
            this.client_log.TabIndex = 0;
            this.client_log.Text = "";
            this.client_log.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // client_list
            // 
            this.client_list.HideSelection = false;
            this.client_list.Location = new System.Drawing.Point(38, 31);
            this.client_list.Name = "client_list";
            this.client_list.Size = new System.Drawing.Size(290, 150);
            this.client_list.TabIndex = 1;
            this.client_list.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client Log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11F);
            this.label3.Location = new System.Drawing.Point(398, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ready : ";
            // 
            // rdyPeople
            // 
            this.rdyPeople.AutoSize = true;
            this.rdyPeople.Font = new System.Drawing.Font("굴림", 11F);
            this.rdyPeople.Location = new System.Drawing.Point(465, 31);
            this.rdyPeople.Name = "rdyPeople";
            this.rdyPeople.Size = new System.Drawing.Size(15, 15);
            this.rdyPeople.TabIndex = 5;
            this.rdyPeople.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 351);
            this.Controls.Add(this.rdyPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.client_list);
            this.Controls.Add(this.client_log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox client_log;
        private System.Windows.Forms.ListView client_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rdyPeople;
    }
}

