using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PART2_TASK1_
{
    public partial class Welcome : Form
    {
        public Welcome(User user)
        {
            InitializeComponent();

            label3.Text = user.Name;
            label4.Text = user.Email;
            label5.Text = user.Password;
        }

        // LOGOUT
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login loginform = new Login();
            loginform.Show();
        }
    }
}
