using ElectorApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectorApp.Forms.Admin
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void logout(object sender, EventArgs e)
        {
            Utils.SessionManager.Logout();
            Form login = new Forms.Login();
            login.Show();
            this.Hide();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            int UserID = Utils.SessionManager.userId;
            Models.User user = userRepository.findUserById(UserID);

            FullName.Text = user.FullName;
        }


        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
