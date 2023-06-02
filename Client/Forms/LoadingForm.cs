using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DalleLib.Networks;
using MetroFramework;

namespace Client.Forms
{
    public partial class LoadingForm : MetroFramework.Forms.MetroForm
    {
        public int TotalTime;
        public int status;

        delegate void LoadingEnd();
        public LoadingForm(int status)
        {
            InitializeComponent();
            TotalTime = status;
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            if(TotalTime == 10)
            {
                loadingTime.Text = "이미지 생성중.. 잠시 후 게임이 시작됩니다";
            }


                
            if (TotalTime > 0)
            {
                loadingTime.Text = TotalTime.ToString();
                TotalTime--;
            }
            else if (TotalTime == 0)
            {
                loadingTime.Text = "게임 시작!";
                TotalTime--;
            }
            else
            {
                loadingTimer.Enabled = false;
                this.Invoke(new LoadingEnd(formClose));
            }
           
        }

        public void formClose()
        {
            this.Close();
        }
    }
}
