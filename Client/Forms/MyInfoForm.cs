using DalleLib;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client.Forms
{
    public partial class MyInfoForm : MetroFramework.Forms.MetroForm
    {
        public MyInfoForm()
        {
            InitializeComponent();
        }

        private void MyInfoForm_Load(object sender, EventArgs e)
        {
            // 아래 두 줄은 테스트 코드

            ID.Text = Program.user.userId.ToString();

            double _AnsRate;
            if (Program.user.TryCount == 0)
            {
                TryCount.Text = "0";
                Ans.Text = "0";
                _AnsRate = 0;
            }
            else
            {
                TryCount.Text = Program.user.TryCount.ToString();
                Ans.Text = Program.user.AnsCount.ToString();
                _AnsRate = Program.user.AnsCount / Program.user.TryCount;
            }
            
            AnsRate.Text = _AnsRate.ToString();
            AnsRate.Text += " %";

            string tier = Program.user.Tier;
            if(tier == "Bronze")
            {
                Tier.Image = Properties.Resources.Tier_Bronze;
            }
            else if (tier == "Sliver")
            {
                Tier.Image = Properties.Resources.Tier_Silver;
            }
            else if (tier == "Gold")
            {
                Tier.Image = Properties.Resources.Tier_Gold;
            }

           
        }

        
    }
}
