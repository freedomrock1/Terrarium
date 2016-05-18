using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terr01
{
    class Model
    {
        // device list
        public ArrayList network;

        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;
   


        public Device makeDevice()
        {
            Device d = new Device();

            return d;
        }

        public Device makeDevice(string name, DeviceType dt, int x, int y)
        {
            // name, type, location, 
            // network info
            Location l = new Location();
            l.x = x;
            l.y = y;

            NetworkInfo n = new NetworkInfo();

            Device d = new Device();
            d.name = name;
            d.type = dt;

            d.location = l;
            d.net = n;
            return d;
        }

        public void loadNet()
        {
            // add devices

            // room 1
            network.Add(makeDevice("bob", DeviceType.WorkStation, 10, 10));
            network.Add(makeDevice("bob1", DeviceType.WorkStation, 10, 50));
            network.Add(makeDevice("bob2", DeviceType.WorkStation, 10, 90));
            network.Add(makeDevice("bob2", DeviceType.WorkStation, 10, 130));
            network.Add(makeDevice("bob3", DeviceType.WorkStation, 50, 10));
            network.Add(makeDevice("bob4", DeviceType.WorkStation, 50, 50));
            network.Add(makeDevice("bob5", DeviceType.WorkStation, 50, 90));
            network.Add(makeDevice("bob5", DeviceType.WorkStation, 50, 130));

            // room 2
            network.Add(makeDevice("bob", DeviceType.WorkStation, 200, 10));
            network.Add(makeDevice("bob1", DeviceType.WorkStation, 230, 10));
            network.Add(makeDevice("bob2", DeviceType.WorkStation, 260, 10));
            network.Add(makeDevice("bob2", DeviceType.WorkStation, 290, 10));
            network.Add(makeDevice("bob3", DeviceType.WorkStation, 200, 50));
            network.Add(makeDevice("bob4", DeviceType.WorkStation, 230, 50));
            network.Add(makeDevice("bob5", DeviceType.WorkStation, 260, 50));
            network.Add(makeDevice("bob5", DeviceType.WorkStation, 290, 50));






            //  wireing closet
            network.Add(makeDevice("ralf", DeviceType.Router, 100, 250));
            network.Add(makeDevice("ralf", DeviceType.Router, 100, 280));
            network.Add(makeDevice("ralf", DeviceType.Router, 100, 310));

            network.Add(makeDevice("alfs", DeviceType.Switch, 100, 150));
            network.Add(makeDevice("alfs", DeviceType.Switch, 100, 180));
            network.Add(makeDevice("alfs", DeviceType.Switch, 100, 210));




            // add connections 



            // add map

        }

        

        string filename = "..\\..\\devices0.csv";
        public void loadNetFile() {
            int counter = 0;
            string line;
            string filepath = "";
            try
            {
                filepath=System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                System.IO.StreamReader file =
                  new System.IO.StreamReader(filename);
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }

                file.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        
        
        
        
        
        }
        public void connect() {
            myConnectionString = "server=127.0.0.1;uid=root;" +
        "pwd=;database=test;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        
        
        }


    }
}
