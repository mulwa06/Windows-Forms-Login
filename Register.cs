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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // this function handles clicking login button
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // close register form
            this.Hide();

            Login loginform = new Login();
            loginform.Show();
        }

        // this function handles clicking submit button
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            var email = textBoxEmail.Text;

            // add user
            if(Database.AddUser(username, password, email))
            {
                MessageBox.Show("Successfully registered! Proceed to Login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Couldn't register! Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
