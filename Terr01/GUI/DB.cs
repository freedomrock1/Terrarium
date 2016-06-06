using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terr01
{
    class DB
    {

        //MySql.Data.MySqlClient.MySqlConnection conn;
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string myConnectionString;

        public DB() {
            init();
        }
         ~DB() {
            this.CloseConnection();
        }


        public void init()
        {
            myConnectionString = "server=127.0.0.1;uid=root;" +
        "pwd=;database=test;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);  
            }


        }


        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }


            return true;
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO devices0 (did, name, dtype, x,y,z, room, netid) VALUES(01, 'bob01', 1,  50, 50, 1, 101, 001)";


            // todo catch

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE devices0 SET x=100, y=100 WHERE name='bob01'";

            // todo catch

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = conn;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public List<string>[] Select()
        {

            return null;
        }

        //Count statement
        public int Count()
        {

            return 0;
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }



    }
}
