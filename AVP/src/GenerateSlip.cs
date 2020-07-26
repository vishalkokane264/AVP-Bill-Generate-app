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
    public partial class GenerateSlip : Form
    {
        public string userType = "";
        string firstName = "";
        string lastName = "";
        string mobileNo = "";
        string panno = "";
        string email = "";
        string address = "";
        string amount = "";
        string paiddate = "";

        public GenerateSlip()
        {
            this.userType = "";
            this.firstName = "";
            this.lastName = "";
            this.mobileNo = "";
            this.panno = "";
            this.email = "";
            this.address = "";
            this.amount = "";
            this.paiddate = "";

            InitializeComponent();
            mobileNoBox.KeyPress += new KeyPressEventHandler(validateNumbers_KeyPress);
            firstNameBox.KeyPress += new KeyPressEventHandler(validateOnlyCharater_KeyPress);
            lastNameBox.KeyPress += new KeyPressEventHandler(validateOnlyCharater_KeyPress);
            amountBox.KeyPress += new KeyPressEventHandler(validateNumbers_KeyPress);
            verifyAmountBox.KeyPress += new KeyPressEventHandler(validateNumbers_KeyPress);
        }

        private void resetData()
        {
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

    private void validateOnlyCharater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z')|| (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == (Char)Keys.Back||e.KeyChar==(Char)Keys.Space)
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

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
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
            Console.WriteLine(firstName+" "+ lastName);
            verifyData verifyData = new verifyData(userType,firstName,lastName,mobileNo,panno,email,address,amount,paiddate);
            verifyData.Show();

        }

        private void GenerateSlip_Load(object sender, EventArgs e)
        {
            resetData();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
