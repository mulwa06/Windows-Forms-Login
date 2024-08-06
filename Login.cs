namespace PART2_TASK1_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        // this function handles clicking submit button
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;

            // checking if our user exists
            if (Database.ValidateUser(username, password))
            {
                this.Hide();
                User user = new User();
                // find the user's profile details
                foreach (User A in Database.Users)
                {
                    if (A.Name == username && A.Password == password)
                    {
                        user = A;
                    }
                }

                // pass the verified user to welcome form
                Welcome welcome = new Welcome(user);
                welcome.Show();
            }
            else
            {
                MessageBox.Show("Incorrect login! Please try again or register as a new user.");
            }
        }

        // this function handles clicking register button
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // close login form
            this.Hide();

            // open the register form
            Register registerform = new Register();
            registerform.Show();
        }
    }
}
