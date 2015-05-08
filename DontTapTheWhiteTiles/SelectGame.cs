using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontTapTheWhiteTiles
{
    public partial class SelectGame : Form
    {
        public NewGame newGame { get; set; }

        public SelectGame()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rb100Tiles.Checked)
            {
                newGame = new NewGame(0, 100, NewGame.GAME_TYPE.TILES_GAME);
            }
            else if (rb300Tiles.Checked)
            {
                newGame = new NewGame(0, 300, NewGame.GAME_TYPE.TILES_GAME);
            }
            else if (rb1Min.Checked)
            {
                newGame = new NewGame(60, 0, NewGame.GAME_TYPE.TIMER_GAME);
            }
            else if (rb30Sek.Checked)
            {
                newGame = new NewGame(30, 0, NewGame.GAME_TYPE.TIMER_GAME);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
