using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class LoadingForm : MetroFramework.Forms.MetroForm
    {
        public Action Func { get; set; }
        public LoadingForm()
        {
            InitializeComponent();
            this.Shown += new EventHandler(LoadingForm_Load);
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                if (this.InvokeRequired)
                {
                    Func.Invoke();
                    this.Invoke((Action)(() =>
                    {
                        Console.WriteLine("HI!");
                        this.Close();
                    }));
                }

            });
            thread.Start();
        }
    }
}
