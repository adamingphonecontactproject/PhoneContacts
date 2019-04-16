using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestContact
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BT_Ajout_Click(object sender, EventArgs e)
        {
            NewContact newContact = new NewContact();
            newContact.MdiParent = this;
            newContact.Show();
        }
    }
}
