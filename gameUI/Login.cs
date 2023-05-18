using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register_Form register_Form = new Register_Form();
            DialogResult Result = register_Form.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string pw = txt_PW.Text;

            /* 아이디, 비밀번호 입력 받아서 맞는지 확인

                if (id == 저장된 값)
                    {
                         if (pw == 저장된 값)
                                로그인 성공
                         else
                            {                                
                                MessageBox.Show("로그인에 성공하였습니다.")
                                메인 화면 실행
                    }
                  else
                     MessageBox.Show("입력된 값이 올바르지 않습니다.")
            */

        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            // 아이디, 비밀번호 찾는 버튼, 이후 폼 따로 추가 예정
        }




        // 이 아래는 UI 디자인 하는데 필요한 요소들!

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
       private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
       {
            txt_PW.UseSystemPasswordChar = false;
       }

       private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
       {
            txt_PW.UseSystemPasswordChar = true;
       }
       

    }
}
