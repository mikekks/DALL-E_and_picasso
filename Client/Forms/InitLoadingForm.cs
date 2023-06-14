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
    public partial class InitLoadingForm : Form
    {
        Font mapleFont = new Font(FontManager.fontFamilys[0], 36, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

        Font mapleFont1 = new Font(FontManager.fontFamilys[0], 22, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont1_5 = new Font(FontManager.fontFamilys[0], 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont2 = new Font(FontManager.fontFamilys[0], 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont2_5 = new Font(FontManager.fontFamilys[0], 13, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

        Font mapleFont3 = new Font(FontManager.fontFamilys[0], 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont4 = new Font(FontManager.fontFamilys[0], 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));


        int time = 10;

        public InitLoadingForm()
        {
            InitializeComponent();
            button1.Font = mapleFont;
        }

        private void InitLoadingForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            button1.Text += ".";

            if(time == 1)
            {
                this.Close();
            }
        }
    }
}
