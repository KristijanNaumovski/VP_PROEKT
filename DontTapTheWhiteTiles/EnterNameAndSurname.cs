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
    public partial class EnterNameAndSurname : Form
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public EnterNameAndSurname()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            Surname = txtSurname.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName,"Please enter your name!");
            }
            else
            {
                errorProvider1.SetError(txtName, null);
            }
        }

        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSurname.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSurname, "Please enter your surname!");
            }
            else
            {
                errorProvider1.SetError(txtSurname, null);
            }
        }
    }
}
