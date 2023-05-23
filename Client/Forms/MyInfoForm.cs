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
            Program.user = new User("123","123");
            Program.user.Tier = "Gold";
            ID.Text = Program.user.userId.ToString();
            TryCount.Text = Program.user.TryCount.ToString();
            Ans.Text = Program.user.AnsCount.ToString();
            AnsRate.Text = Program.user.AnsRate.ToString();

            string tier = Program.user.Tier;
            if(tier == "Bronze")
            {

            }
            else if (tier == "Sliver")
            {

            }
            else if (tier == "Gold")
            {
                Tier.Image = global::Client.Properties.Resources.Tier_Gold;
            }

           
        }

        
    }
}
