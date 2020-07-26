using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVP.src
{
    public partial class verifyData : Form
    {
        private string userType="";
        private string firstName="";
        private string lastName="";
        private string mobileNo="";
        private string panno="";
        private string email="";
        private string address="";
        private string amount="";
        private string paiddate="";


        public verifyData(string userType, string firstName, string lastName, string mobileNo, string panno, string email, string address, string amount, string paiddate)
        {


            InitializeComponent();
            this.userType = userType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNo = mobileNo;
            this.panno = panno;
            this.email = email;
            this.address = address;
            this.amount = amount;
            this.paiddate = paiddate;

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void VerifyData_Load(object sender, EventArgs e)
        {
            userTypeLbl.Text = userType;
            firstNameLbl.Text = firstName;
            lastNameLbl.Text = lastName;
            mobileNoLbl.Text = mobileNo;
            panNoLbl.Text = panno;
            emailLbl.Text = email;
            addressLbl.Text = address;
            amountLbl.Text = amount;
            paidDateLbl.Text = paiddate;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
            User user1 = new User(userTypeLbl.Text, firstNameLbl.Text, lastNameLbl.Text, mobileNoLbl.Text, panNoLbl.Text, emailLbl.Text, addressLbl.Text, Convert.ToDouble(amountLbl.Text), paidDateLbl.Text);
            insertUserData(user1);
        }

        private void insertUserData(User user1)
        {
            string query1 = "INSERT INTO user_detail(user_type,first_name,last_name,email,contact_number,pan_number,address,amount_paid,paid_date) VALUES ";
            string query2 = "('AVP','" + user1.getFirstName() + "','" + user1.getLastName() + "','" + user1.GetEmail() + "','" + user1.getMobile() + "','" + user1.getPan() + "','" + user1.getAddress() + "','" + user1.getAmount() + "','" + user1.getPaidDate() + "')";
            string finalQuery = query1 + query2;
            DBConnection dBConnection = new DBConnection();
            Console.WriteLine(finalQuery);
            if (dBConnection.InsertUserData(finalQuery))
            {
                FormSubmission formSubmission = new FormSubmission();
                formSubmission.Show();
                this.Close();
            }
            else
            {
                //unsuccessful insert
                System.Windows.Forms.MessageBox.Show("Data not inserted", "Failure", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            SaveButton_Click(sender,e);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
