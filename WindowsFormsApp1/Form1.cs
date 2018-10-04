using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserReference.Service1Client client = new UserReference.Service1Client();
            errorLbl.Text = "loading";

            string email = emailTxtBox.Text;
            string password = passwordTxtBox.Text;

            if(client.RegisterUser(email, password))
            {
                errorLbl.Text = "Logged in";
            }
            else
            {
                errorLbl.Text = "Error Logging in";

            }
        }
        
    }
}
