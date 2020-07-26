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
    public partial class PrintSlip : UserControl
    {
        public PrintSlip()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PageFormat pageFormat = new PageFormat();
            if(!string.IsNullOrEmpty(application_noBox.Text))
            {
                DBConnection dBConnection = new DBConnection();
                DataTable dataTable = dBConnection.EditRecord(application_noBox.Text);
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        string message=pageFormat.SavePage(application_noBox.Text);
                        if(string.IsNullOrEmpty(message))
                        {
                            MessageBox.Show("File Saved Successfully", "Success", MessageBoxButtons.OK);
                            application_noBox.Text = String.Empty;
                        }
                        else
                        {
                            MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                        }
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
            else
            {
                MessageBox.Show("Application number cannot be empty");
            }
        }
    }
}
