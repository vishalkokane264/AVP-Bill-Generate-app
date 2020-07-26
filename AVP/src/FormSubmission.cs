using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AVP.src
{
    public partial class FormSubmission : Form
    {
        public FormSubmission()
        {
            InitializeComponent();
        }

        private void FormSubmission_Load(object sender, EventArgs e)
        {
            appNoLbl.Text = "Hello";
            DBConnection dBConnection = new DBConnection();
            Int32 srNo = dBConnection.GetLastId();
            Int32 currYear = Int32.Parse(dBConnection.GetLastDate(srNo));
            string appId = "AVP/" + currYear + "-" + (currYear + 1) + "/" + srNo + "";
            Console.WriteLine(appId);
            if (dBConnection.UpdateApplicationNo(appId, srNo))
            {
                this.appNoLbl.Text = appId;
            }

        }

        private void PrintNowButton_Click(object sender, EventArgs e)
        {
            PageFormat pageFormat = new PageFormat();
            if (!string.IsNullOrEmpty(appNoLbl.Text))
            {
                DBConnection dBConnection = new DBConnection();
                DataTable dataTable = dBConnection.EditRecord(appNoLbl.Text);
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        string message = pageFormat.SavePage(appNoLbl.Text);
                        if (string.IsNullOrEmpty(message))
                        {
                            MessageBox.Show("File Saved Successfully", "Success", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Application number", "Message", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Application number", "Message", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void PrintLaterButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SaveDetails(string appid)
        {
            PageFormat pageFormat = new PageFormat();
            pageFormat.SavePage(appid);

        }
    }
}
