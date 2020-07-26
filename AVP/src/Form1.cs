using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVP.src;
namespace AVP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string rootPath = ConfigurationManager.AppSettings["rootPath"];
            string imagePath = ConfigurationManager.AppSettings["logoLocation"];
            try
            {
                pictureBox1.Image = new Bitmap(rootPath + imagePath);
            }
            catch(Exception)
            {

            }
            finally
            {

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string serverName = ConfigurationManager.AppSettings["server"]+"";
            string port = ConfigurationManager.AppSettings["port"] + "";
            string database = ConfigurationManager.AppSettings["database"]+"";
            string user = ConfigurationManager.AppSettings["user"]+"";
            string password = ConfigurationManager.AppSettings["password"]+"";
            DBConnection dBConnection = new DBConnection();

            string usernameText = "";
            string userpassText = "";
            usernameText = usernamebox.Text;
            userpassText = passwordbox.Text;
            if (!String.IsNullOrEmpty(usernameText) && !(String.IsNullOrEmpty(userpassText)))
            {
                if (dBConnection.ValidateUser(usernameText, userpassText))
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect UserId or Password. Check again", "Invalid Login", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Username or password cannot be Null", "Invalid Login", MessageBoxButtons.OK);
            }
        }

        private void ReloadDB_Click(object sender, EventArgs e)
        {
            DBConnection dBConnection = new DBConnection();
            if (dBConnection.OpenConnection() == true)
            {
                if (dBConnection.CloseConnection() == true)
                {
                    MessageBox.Show("Database loaded Successfully", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Database not loaded Successfully", "Failure", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Database not loaded Successfully", "Failure", MessageBoxButtons.OK);
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
