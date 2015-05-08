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
    public partial class About : Form
    {
        private FirstForm form;

        public About(FirstForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
            form.Show();
        }
    }
}
