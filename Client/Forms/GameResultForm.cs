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

        Font mapleFont = new Font(FontManager.fontFamilys[0], 36, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

        Font mapleFont1 = new Font(FontManager.fontFamilys[0], 22, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont1_5 = new Font(FontManager.fontFamilys[0], 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont2 = new Font(FontManager.fontFamilys[0], 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont2_5 = new Font(FontManager.fontFamilys[0], 13, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

        Font mapleFont3 = new Font(FontManager.fontFamilys[0], 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont4 = new Font(FontManager.fontFamilys[0], 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));


        public GameResultForm()
        {
            InitializeComponent();
        }

        private void GameResultForm_Load(object sender, EventArgs e)
        {
            label1.Font = mapleFont;
            Program.records.Sort(new Comparison<Records>((n1, n2) => (n2.correctCount/n2.tryCount).CompareTo(n1.correctCount / n1.tryCount)));

            int y = 60;
            for (int i = 0; i < Program.records.Count; i++)
            {
                MetroTile _userTile = new MetroTile();
                _userTile.Width = 520;
                _userTile.Height = 70;
                _userTile.Location = new Point(150, y);
                _userTile.UseCustomBackColor = true;
                _userTile.UseTileImage = true;

                int borderRadius = 20;
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(_userTile.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(_userTile.Width - borderRadius, _userTile.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, _userTile.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                _userTile.Region = new Region(path);

                _userTile.BackColor = Color.Gold;
                y += 80;

                PictureBox _rank = new PictureBox();
                Label _userId = new Label();
                Label _tryLabel = new Label();
                Label _AnsLabel = new Label();
                Label _WrgLabel = new Label();
                Label _RateLabel = new Label();
                Label _tryCount = new Label();
                Label _AnsCount = new Label();
                Label _WrgCount = new Label();
                Label _Rate = new Label();

                List<Label> labels = new List<Label> { _userId, _tryLabel, _AnsLabel, _WrgLabel, _RateLabel, _tryCount, _AnsCount, _WrgCount, _Rate };

                _rank.SizeMode = PictureBoxSizeMode.Zoom;
                _rank.Size = new Size(95, 70);
                Color color;
                if (i == 0)
                {
                    color = Color.Cornsilk;

                    _userTile.BackColor = color;
                    _rank.Image = Properties.Resources._1teir_removebg_preview;
                    
                    
                }
                else if (i == 1)
                {
                    color = Color.Gainsboro;

                    _userTile.BackColor = color;
                    _rank.Image = Properties.Resources._2tier_removebg_preview;
                }
                else if (i == 2)
                {
                    color = Color.AntiqueWhite;

                    _userTile.BackColor = color;
                    _rank.Image = Properties.Resources._3tier_removebg_preview;
                }
                else
                {

                    color = Color.AntiqueWhite;

                    _userTile.BackColor = color;

                    _rank.Image = Properties.Resources._3tier_removebg_preview;
                }

                foreach(Label _label in labels)
                {
                    _label.BackColor = color;
                    _label.Font = mapleFont4;
                    _label.ForeColor = Color.MidnightBlue;
                }

                _userTile.Controls.Add(_rank);

                _userTile.Left = _rank.Right;

                
                _userId.Text = Program.records[i].userId;
                _userId.Location = new Point(100, 20);
                _userId.Size = new Size(54, 25);
                _userTile.Controls.Add(_userId);

                
                _tryLabel.Text = "시도 횟수 ";
                _tryLabel.Location = new Point(170, 3);
                _tryLabel.Size = new Size(80, 15);
                _userTile.Controls.Add(_tryLabel);

               
                _AnsLabel.Text = "정답 횟수 ";
                _AnsLabel.Location = new Point(170, 25);
                _AnsLabel.Size = new Size(80, 20);
                _userTile.Controls.Add(_AnsLabel);

                
                _WrgLabel.Text = "오답 횟수 ";
                _WrgLabel.Location = new Point(170, 47);
                _WrgLabel.Size = new Size(80, 20);
                _userTile.Controls.Add(_WrgLabel);

                _RateLabel.Text = "정답률 ";
                _RateLabel.Location = new Point(338, 27);
                _RateLabel.Size = new Size(80, 30);
                _userTile.Controls.Add(_RateLabel);

                
                _tryCount.Text = Program.records[i].tryCount.ToString();
                _tryCount.Location = new Point(264, 3);
                _tryCount.Size = new Size(31, 15);

                _userTile.Controls.Add(_tryCount);
               
                _AnsCount.Text = Program.records[i].correctCount.ToString();
                _AnsCount.Location = new Point(264, 25);
                _AnsCount.Size = new Size(31, 15);

                _userTile.Controls.Add(_AnsCount);
             
                _WrgCount.Text = (Program.records[i].tryCount - Program.records[i].correctCount).ToString();
                _WrgCount.Location = new Point(264, 47);
                _WrgCount.Size = new Size(31, 15);

                _userTile.Controls.Add(_WrgCount);
               
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
