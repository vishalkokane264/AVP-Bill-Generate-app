using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AVP.src
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        public DBConnection()
        {
            initialize();
        }

        public void initialize()
        {
            server = "localhost";
            database = "userinfoDB";
            port = "3306";
            uid = "root";
            password = "Vishal@12";
            string connectionString;
            connectionString = "SERVER=" + server + ";" +"PORT="+port +";"+ "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            Console.WriteLine("Connection Successful");
        }

        public BindingSource getLastNRecords(int n)
        {
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from(select id,application_no,concat(first_name,' ',last_name) as fullName,contact_number,email,amount_paid,paid_date from userinfoDB.user_detail where deleted!=1 order by id desc limit @numberOfRec) userdetail order by userdetail.id asc", connection);
            cmdDataBase.Parameters.AddWithValue("@numberOfRec", n);
            BindingSource bSource = new BindingSource();
            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                bSource.DataSource = dbdataset;
                return bSource;
            }
            catch (Exception ex)
            {
            }
            finally { }
            return bSource;
        }

        public BindingSource findByIdOrName(string appid,string firstname)
        {
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from(select id,application_no,concat(first_name,' ',last_name) as fullName,contact_number,email,amount_paid,paid_date from user_detail  where (application_no=@appid OR first_name=@firstname) AND deleted!=1 order by id desc ) userdetail order by userdetail.id asc", connection);
            cmdDataBase.Parameters.AddWithValue("@appid", appid);
            cmdDataBase.Parameters.AddWithValue("@firstname", firstname);
            BindingSource bSource = new BindingSource();
            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                bSource.DataSource = dbdataset;
                return bSource;
            }
            catch (Exception ex)
            {
            }
            finally { }
            return bSource;
        }

        public DataTable EditRecord(string appid)
        {
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from user_detail  where application_no=@appid and deleted!=1", connection);
            cmdDataBase.Parameters.AddWithValue("@appid", appid);
            DataTable dbdataset = new DataTable();
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                sda.Fill(dbdataset);
                return dbdataset;
            }
            catch (Exception ex)
            {
            }
            return dbdataset;
        }


        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot Connect to server..","Message",MessageBoxButtons.OK);
                        break;

                    case 1045:
                        MessageBox.Show("Invalid Username or Password", "Message", MessageBoxButtons.OK);
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        public bool ValidateUser(string usernameText, string userpassText)
        {
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from user where username=@user and password=@pass";
                cmd.Parameters.AddWithValue("@user", usernameText);
                cmd.Parameters.AddWithValue("@pass", userpassText);
                cmd.Connection = connection;
                MySqlDataReader login = cmd.ExecuteReader();
                if (login.Read())
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public bool UpdateRecord(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool InsertUserData(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                catch (MySqlException e)
                {
                    this.CloseConnection();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public int GetLastId()
        {
            string query = "SELECT Max(id) FROM user_detail where deleted!=1";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
                return Count;
            }
            else
            {
                return Count;
            }

        }
        public string GetLastDate(int id)
        {
            string query = "SELECT Year(creation_date) FROM user_detail where id=" + id+" and deleted!=1";
            string Count = " ";

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = cmd.ExecuteScalar() + "";

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }

        }
        public bool UpdateApplicationNo(string appId, int id)
        {
            string query = "UPDATE user_detail SET application_no='" + appId + "' WHERE id=" + id + "";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                try
                {
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    //close connection
                    return true;
                }
                catch (MySqlException)
                {
                    this.CloseConnection();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public string[] getNewData(string v)
        {
            string[] str = new string[5];
            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT first_name,last_name,address,amount_paid,paid_date FROM user_detail where application_no=@codice and deleted!=1";
                cmd.Parameters.AddWithValue("@codice", v);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // here could be problems if database value is null
                    str[0] = reader["first_name"] + "";
                    str[1] = reader["last_name"] + "";
                    str[2] = reader["address"] + "";
                    str[3] = reader["amount_paid"] + "";
                    str[4] = reader["paid_date"] + "";
                }
                this.CloseConnection();
                return str;
            }
            else
            {
                MessageBox.Show("Database Connection error", "Message", MessageBoxButtons.OK);
                return str;
            }
        }


    }
}
