using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVP.src
{
    public partial class EditSlipUC : UserControl
    {
        string userType = "";
        string firstName = "";
        string lastName = "";
        string mobileNo = "";
        string panno = "";
        string email = "";
        string address = "";
        string amount = "";
        string paiddate = "";



        private object dataGridView1;
        DBConnection dBConnection = new DBConnection();
        DataTable dataTable;
        public EditSlipUC()
        {
            InitializeComponent();
            mobileNoBox.KeyPress += new KeyPressEventHandler(validateNumbers_KeyPress);
            firstNameBox.KeyPress += new KeyPressEventHandler(validateOnlyCharater_KeyPress);
            lastNameBox.KeyPress += new KeyPressEventHandler(validateOnlyCharater_KeyPress);
            amountBox.KeyPress += new KeyPressEventHandler(validateNumbers_KeyPress);
            verifyAmountBox.KeyPress += new KeyPressEventHandler(validateNumbers_KeyPress);

        }
        private void validateOnlyCharater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == (Char)Keys.Back || e.KeyChar == (Char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void validateNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void resetData()
        {
            this.userType =String.Empty;
            this.firstNameBox.Text = "";
            this.lastNameBox.Text = "";
            this.mobileNoBox.Text = "";
            this.panNoBox.Text = "";
            this.mailBox.Text = "";
            this.mobileNoBox.Text = "";
            this.addressBox.Text = "";
            this.amountBox.Text = "";
            this.verifyAmountBox.Text = "";
            this.paidDateBox.Text = "";
        }

        public void disableFields()
        {
            appIdBox.Text = String.Empty;
            firstNameBox.Enabled = false;
            lastNameBox.Enabled = false;
            mobileNoBox.Enabled = false;
            panNoBox.Enabled = false;
            mailBox.Enabled = false;
            addressBox.Enabled = false;
            amountBox.Enabled = false;
            verifyAmountBox.Enabled = false;
            paidDateBox.Enabled = false;
            editButton.Enabled = false;
            resetButton.Enabled = false;
            appIdBox.Enabled = true;
            button1.Enabled = true;
        }

        public void enableFields()
        {
            usertypeBox.Text = "";
            appIdBox.Enabled = false;
            button1.Enabled = false;
            firstNameBox.Enabled = true;
            lastNameBox.Enabled = true;
            mobileNoBox.Enabled = true;
            panNoBox.Enabled = true;
            mailBox.Enabled = true;
            addressBox.Enabled = true;
            amountBox.Enabled = true;
            verifyAmountBox.Enabled = true;
            paidDateBox.Enabled = true;
            editButton.Enabled = true;
            resetButton.Enabled = true;
        }

        private void EditSlipUC_Load(object sender, EventArgs e)
        {
            disableFields();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataTable = dBConnection.EditRecord(appIdBox.Text);
            if (dataTable!=null){
                if(dataTable.Rows.Count>0)
                {
                    editForm(dataTable);
                }
                else
                {
                    MessageBox.Show("Invalid Application number", "Message", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Invalid Application number", "Message", MessageBoxButtons.OK);
            }

        }

        private void editForm(DataTable dataTable)
        {
            enableFields();
            usertypeBox.SelectedText= dataTable.Rows[0][1].ToString();
            firstNameBox.Text = dataTable.Rows[0][2].ToString();
            lastNameBox.Text = dataTable.Rows[0][3].ToString();
            mobileNoBox.Text = dataTable.Rows[0][5].ToString();
            panNoBox.Text= dataTable.Rows[0][6].ToString();
            mailBox.Text= dataTable.Rows[0][4].ToString();
            addressBox.Text= dataTable.Rows[0][7].ToString();
            amountBox.Text= dataTable.Rows[0][8].ToString();
            verifyAmountBox.Text= dataTable.Rows[0][8].ToString(); 
            paidDateBox.Text= dataTable.Rows[0][9].ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(amountBox.Text==verifyAmountBox.Text)
            {
                userType = usertypeBox.Text;
                firstName = firstNameBox.Text;
                lastName = lastNameBox.Text;
                mobileNo = mobileNoBox.Text;
                panno = panNoBox.Text;
                email = mailBox.Text;
                address = addressBox.Text;
                amount = amountBox.Text;
                paiddate = paidDateBox.Text;

                User user1 = new User(userType, firstName, lastName, mobileNo, panno, email, address, Convert.ToDouble(amount), paiddate);
                Console.WriteLine(user1.toString());
                insertUserData(user1, appIdBox.Text, Int32.Parse(dataTable.Rows[0][0].ToString()));
            }
            else
            {
                MessageBox.Show("Amount mismatch", "Error", MessageBoxButtons.OK);
            }

        }

        private void insertUserData(User user1,string appid,int id)
        {
            string query1 = "UPDATE user_detail set user_type='" + user1.getPayeeType() + "',first_name='" + user1.getFirstName() + "',last_name='" + user1.getLastName() + "'";
            string query2 = ",email='"+user1.GetEmail()+"',contact_number='"+user1.getMobile()+"',pan_number='"+user1.getPan()+"',address='"+user1.getAddress()+"',amount_paid='"+user1.getAmount()+"',paid_date='"+user1.getPaidDate()+"'";
            string query3 = " WHERE application_no='"+appid+"')";
            string aa = "update user_detail set user_type='" + user1.getPayeeType() + "',first_name='" + user1.getFirstName() + "',last_name='" + user1.getLastName() + "',email='" + user1.GetEmail() + "',contact_number='" + user1.getMobile() + "',pan_number='" + user1.getPan() + "',address='" + user1.getAddress() + "',amount_paid='" + user1.getAmount() + "',paid_date='" + user1.getPaidDate() + "' where application_no='"+appid+"'";
            string finalQuery = query1 + query2+query3;
            DBConnection dBConnection = new DBConnection();
            Console.WriteLine(finalQuery);
            if (dBConnection.InsertUserData(aa))
            {
                MessageBox.Show("Data Updated Successfully..", "Message", MessageBoxButtons.OK);
                resetData();
                disableFields();
            }
            else
            {
                MessageBox.Show("Data not updated Successfully", "Message", MessageBoxButtons.OK);
                //unsuccessful insert
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            resetData();
            disableFields();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
