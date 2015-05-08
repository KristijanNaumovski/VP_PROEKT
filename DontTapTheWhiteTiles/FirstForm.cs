using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontTapTheWhiteTiles
{
    public partial class FirstForm : Form
    {
        public bool music { get; set; }

        public FirstForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            music = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            SelectGame selectGame = new SelectGame();
            NewGame game;
            
            if (selectGame.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                game = selectGame.newGame;
                game.firstForm = this;
                game.music = music;
                game.Show();
                Hide();
            }
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            HighScores highScores = new HighScores(this);
            Hide();
            highScores.ShowDialog();
           
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About(this);
            Hide();
            about.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            music = !music;
            if (music)
            {
                btnMusic.Text = "Music ON";
            }
            else
            {
                btnMusic.Text = "Music OFF";
            }
        }
    }
}
