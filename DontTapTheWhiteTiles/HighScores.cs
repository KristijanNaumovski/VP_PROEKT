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
    public partial class HighScores : Form
    {
        private Leaderboard leaderboard;
        private FirstForm form;

        public HighScores(FirstForm form)
        {
            InitializeComponent();
            leaderboard = new Leaderboard();
            this.form = form;
        }

        private void loadList(object sender, EventArgs e)
        {
            if (rb100Tiles.Checked)
            {
                listBox.DataSource = leaderboard.ListFor100Tiles;
            }
            else if (rb300Tiles.Checked)
            {
                listBox.DataSource = leaderboard.ListFor300Tiles;
            }
            else if (rb30Sec.Checked)
            {
                listBox.DataSource = leaderboard.ListFor30SecGame;
            }
            else if (rb1Min.Checked)
            {
                listBox.DataSource = leaderboard.ListFor1MinGame;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            form.Show();
        }
    }
}
