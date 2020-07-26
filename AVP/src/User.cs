using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVP.src
{
    class User
    {
        private string payeetype = "";
        private string fname = "";
        private string lname = "";
        private string mob = "";
        private string panno = "";
        private string emailid = "";
        private string address = "";
        private double amount = 0;
        private string paiddate = "01/01/2000";

        public User(string payeeType, string fname, string lname, string mob, string panno, string emailid, string address, double amount, string paiddate)
        {
            this.payeetype = payeeType;
            this.fname = fname;
            this.lname = lname;
            this.mob = mob;
            this.panno = panno;
            this.emailid = emailid;
            this.address = address;
            this.amount = amount;
            this.paiddate = paiddate;
        }

        public User()
        {
        }
        public string getPayeeType()
        {
            return payeetype;
        }
        public string getFirstName()
        {
            return fname;
        }
        public string getLastName()
        {
            return lname;
        }
        public string getMobile()
        {
            return mob;
        }
        public string getPan()
        {
            return panno;
        }
        public string getAddress()
        {
            return address;
        }
        public double getAmount()
        {
            return amount;
        }
        public string getPaidDate()
        {
            return paiddate;
        }

        public string GetEmail()
        {
            return this.emailid;
        }

        public string toString()
        {
            return (this.fname + "" + this.lname + "" + this.mob);
        }

    }
}
