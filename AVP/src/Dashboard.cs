using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVP.src;
namespace AVP.src
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void GenerateSlipButton_Click(object sender, EventArgs e)
        {
            editSlipUC1.Hide();
            viewRecordsUC1.Hide();
            printSlip1.Hide();
            createRecordUC1.Show();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            createRecordUC1.Hide();
            editSlipUC1.Hide();
            printSlip1.Hide();
            viewRecordsUC1.Hide();
        }

        private void ViewRecordButton_Click(object sender, EventArgs e)
        {
            createRecordUC1.Hide();
            editSlipUC1.Hide();
            printSlip1.Hide();
            viewRecordsUC1.Show();
        }

        private void EditSlipButton_Click(object sender, EventArgs e)
        {
            createRecordUC1.Hide();
            viewRecordsUC1.Hide();
            printSlip1.Hide();
            editSlipUC1.Show();

        }

        private void PrintSlipButton_Click(object sender, EventArgs e)
        {
            createRecordUC1.Hide();
            viewRecordsUC1.Hide();
            editSlipUC1.Show();
            printSlip1.Show();

        }

        private void ReloadDatabase_Click(object sender, EventArgs e)
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
    }
}
