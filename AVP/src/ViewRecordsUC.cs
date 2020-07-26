using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AVP.src
{
    public partial class ViewRecordsUC : UserControl
    {
        public ViewRecordsUC()
        {
            InitializeComponent();
        }

        private void ViewRecordsUC_Load(object sender, EventArgs e)
        {
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Last10RecRadio_CheckedChanged(object sender, EventArgs e)
        {
            applicationId.Text = "";
            firstName.Text = "";
            last25RecRadio.Checked = false;
            searchById.Checked = false;
            searchByName.Checked = false;
            applicationId.Enabled = false;
            firstName.Enabled = false;
        }

        private void SearchById_CheckedChanged(object sender, EventArgs e)
        {
            applicationId.Text = "";
            firstName.Text = "";
            last10RecRadio.Checked = false;
            last25RecRadio.Checked = false;
            searchByName.Checked = false;
            firstName.Enabled = false;
            applicationId.Enabled = true;

        }

        private void Last25RecRadio_CheckedChanged(object sender, EventArgs e)
        {
            applicationId.Text = "";
            firstName.Text = "";
            last10RecRadio.Checked = false;
            searchById.Checked = false;
            searchByName.Checked = false;
            applicationId.Enabled = false;
            firstName.Enabled = false;

        }

        private void SearchByName_CheckedChanged(object sender, EventArgs e)
        {
            applicationId.Text = "";
            firstName.Text = "";
            last10RecRadio.Checked = false;
            last25RecRadio.Checked = false;
            applicationId.Enabled = false;
            searchById.Checked = false;
            firstName.Enabled = true;

        }

        private void Button1_Click(object sender, EventArgs e)
        {



        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DBConnection dBConnection = new DBConnection();
            if (last10RecRadio.Checked == true)
            {
                dataGridView1.DataSource = dBConnection.getLastNRecords(10);
                dataGridView1.ReadOnly = true;
            }
            if (last25RecRadio.Checked == true)
            {
                dataGridView1.DataSource = dBConnection.getLastNRecords(25);
                dataGridView1.ReadOnly = true;
            }
            if (searchById.Checked == true)
            {
                if(!string.IsNullOrEmpty(applicationId.Text))
                {
                    dataGridView1.DataSource = dBConnection.findByIdOrName(applicationId.Text, "");
                    dataGridView1.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Application id cannot be empty", "Failure", MessageBoxButtons.OK);
                }
            }
            if (searchByName.Checked == true)
            {
                if (!string.IsNullOrEmpty(firstName.Text))
                {
                    dataGridView1.DataSource = dBConnection.findByIdOrName("", firstName.Text);
                    dataGridView1.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Name cannot be empty", "Failure", MessageBoxButtons.OK);
                }
            }

        }

        private void Last10RecRadio_CheckedChanged_1(object sender, EventArgs e)
        {
            Last10RecRadio_CheckedChanged(sender,e);
        }

        private void Last25RecRadio_CheckedChanged_1(object sender, EventArgs e)
        {
            Last25RecRadio_CheckedChanged(sender,e);
        }

        private void SearchById_CheckedChanged_1(object sender, EventArgs e)
        {
            SearchById_CheckedChanged(sender, e);
        }

        private void SearchByName_CheckedChanged_1(object sender, EventArgs e)
        {
            SearchByName_CheckedChanged(sender,e);
        }
    }
}
