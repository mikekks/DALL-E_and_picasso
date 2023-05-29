using DalleLib.InGame;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client.Forms
{
    public partial class GameResultForm : MetroFramework.Forms.MetroForm
    {
        public MetroTile[] Result = new MetroTile[7];

        public GameResultForm()
        {
            InitializeComponent();
        }

        private void GameResultForm_Load(object sender, EventArgs e)
        {

            Program.records.Sort(new Comparison<Records>((n1, n2) => n2.correctCount.CompareTo(n1.correctCount)));

            int y = 60;
            for (int i = 0; i < Program.records.Count; i++)
            {
                MetroTile _userTile = new MetroTile();
                _userTile.Width = 520;
                _userTile.Height = 70;
                _userTile.Location = new Point(150, y);
                //_roomTile.Enabled = false;
                //_roomTile.TileImage = Properties.Resources.Van;
                //_roomTile.TileImageAlign = ContentAlignment.MiddleLeft;
                _userTile.UseCustomBackColor = true;
                _userTile.UseTileImage = true;
                _userTile.BackColor = Color.Gold;
                y += 80;

                PictureBox _rank = new PictureBox();
                _rank.SizeMode = PictureBoxSizeMode.Zoom;
                _rank.Size = new Size(95, 70);
                if (i == 0)
                {
                    _userTile.BackColor = Color.Gold;
                    _rank.Image = Properties.Resources.Tier_Gold;
                    
                }
                else if (i == 1)
                {
                    _userTile.BackColor = Color.SlateGray;
                    _rank.Image = Properties.Resources.Tier_Silver;
                }
                else if (i == 2)
                {
                    _userTile.BackColor = Color.Brown;
                    _rank.Image = Properties.Resources.Tier_Bronze;
                }
                else
                {
                    _userTile.BackColor = Color.Black;
                    //_rank.Image = Properties.Resources.;
                }
                _userTile.Controls.Add(_rank);


                MetroLabel _userId = new MetroLabel();
                _userId.Text = Program.records[i].userId;
                _userId.UseCustomBackColor = true;
                _userId.Location = new Point(100, 20);
                _userId.Size = new Size(54, 25);
                _userId.BackColor = _userTile.BackColor;
                _userTile.Controls.Add(_userId);

                MetroLabel _tryLabel = new MetroLabel();
                _tryLabel.Text = "시도 횟수 : ";
                _tryLabel.Location = new Point(170, 3);
                _tryLabel.UseCustomBackColor = true;
                _tryLabel.BackColor = _userTile.BackColor;
                _tryLabel.Size = new Size(80, 15);
                _userTile.Controls.Add(_tryLabel);

                MetroLabel _AnsLabel = new MetroLabel();
                _AnsLabel.Text = "정답 횟수 : ";
                _AnsLabel.Location = new Point(170, 25);
                _AnsLabel.Size = new Size(80, 20);
                _AnsLabel.UseCustomBackColor = true;
                _AnsLabel.BackColor = _userTile.BackColor;

                _userTile.Controls.Add(_AnsLabel);

                MetroLabel _WrgLabel = new MetroLabel();
                _WrgLabel.Text = "오답 횟수 : ";
                _WrgLabel.Location = new Point(170, 47);
                _WrgLabel.Size = new Size(80, 20);
                _WrgLabel.UseCustomBackColor = true;
                _WrgLabel.BackColor = _userTile.BackColor;

                _userTile.Controls.Add(_WrgLabel);

                MetroLabel _RateLabel = new MetroLabel();
                _RateLabel.Text = "정답률 : ";
                _RateLabel.Location = new Point(338, 27);
                _RateLabel.Size = new Size(80, 30);
                _RateLabel.UseCustomBackColor = true;
                _RateLabel.BackColor = _userTile.BackColor;

                _userTile.Controls.Add(_RateLabel);


                MetroLabel _tryCount = new MetroLabel();
                _tryCount.Text = Program.records[i].tryCount.ToString();
                _tryCount.Location = new Point(264, 3);
                _tryCount.Size = new Size(31, 15);
                _tryCount.UseCustomBackColor = true;
                _tryCount.BackColor = _userTile.BackColor;

                _userTile.Controls.Add(_tryCount);

                MetroLabel _AnsCount = new MetroLabel();
                _AnsCount.Text = Program.records[i].correctCount.ToString();
                _AnsCount.Location = new Point(264, 25);
                _AnsCount.Size = new Size(31, 15);
                _AnsCount.UseCustomBackColor = true;
                _AnsCount.BackColor = _userTile.BackColor;

                _userTile.Controls.Add(_AnsCount);

                MetroLabel _WrgCount = new MetroLabel();
                _WrgCount.Text = (Program.records[i].tryCount - Program.records[i].correctCount).ToString();
                _WrgCount.Location = new Point(264, 47);
                _WrgCount.Size = new Size(31, 15);
                _WrgCount.UseCustomBackColor = true;
                _WrgCount.BackColor = _userTile.BackColor;
                _userTile.Controls.Add(_WrgCount);

                MetroLabel _Rate = new MetroLabel();
                double _try = Program.records[i].tryCount;
                double _cor = Program.records[i].correctCount;
                if (_try == 0)
                {
                    _Rate.Text = "0 %";
                }
                else
                {
                    double _rate = Math.Round(_cor / _try * 100);
                    _Rate.Text = _rate.ToString() + " %";
                }
                _Rate.Location = new Point(420, 27);
                _Rate.Size = new Size(100, 70);
                _Rate.UseCustomBackColor = true;
                _Rate.BackColor = _userTile.BackColor;
                _userTile.Controls.Add(_Rate);

                Result[i] = _userTile;
                Controls.Add(Result[i]);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
