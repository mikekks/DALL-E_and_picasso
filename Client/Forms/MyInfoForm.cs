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
        public bool unRegister;

        Font mapleFont = new Font(FontManager.fontFamilys[0], 36, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont1 = new Font(FontManager.fontFamilys[0], 22, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont2 = new Font(FontManager.fontFamilys[0], 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont3 = new Font(FontManager.fontFamilys[0], 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));



        public MyInfoForm()
        {
            InitializeComponent();
        }

        private void MyInfoForm_Load(object sender, EventArgs e)
        {
            lbl_ans.Font = mapleFont3;
            lbl_ID.Font = mapleFont3;
            lbl_Pans.Font = mapleFont3;
            lbl_total.Font = mapleFont3;
            btn_unregister.Font = mapleFont3;

            ID.Font = mapleFont3;
            TryCount.Font = mapleFont3;
            Ans.Font = mapleFont3;
            AnsRate.Font = mapleFont3;

            ID.Text = Program.user.userId.ToString();

            double _try = Program.user.TryCount;
            double _cor = Program.user.AnsCount;
            double _AnsRate;

            if (_try == 0)
            {
                TryCount.Text = "0";
                Ans.Text = "0";
                AnsRate.Text = "0 %";
            }
            else
            {
                TryCount.Text = Program.user.TryCount.ToString();
                double _rate = Math.Round(_cor / _try * 100);

                Ans.Text = Program.user.AnsCount.ToString();
                AnsRate.Text = _rate.ToString();
                AnsRate.Text += " %";
            }

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

        private void btn_unRegister_Click(object sender, EventArgs e)
        {
            UnRegister unRegister_Form = new UnRegister(ID.Text);
            Console.WriteLine("뒤로 전달할 userId {0}", ID.Text);
            unRegister_Form.FormClosing += UnRegisterForm_FormClosing;
            DialogResult Result = unRegister_Form.ShowDialog();
        }

        public void UnRegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btn_unregister_Click_1(object sender, EventArgs e)
        {
            UnRegister unRegister_Form = new UnRegister(ID.Text);
            Console.WriteLine("뒤로 전달할 userId {0}", ID.Text);
            unRegister_Form.FormClosing += UnRegisterForm_FormClosing;
            DialogResult Result = unRegister_Form.ShowDialog();
        }
    }
}
