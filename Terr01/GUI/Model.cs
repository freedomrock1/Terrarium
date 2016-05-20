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
            MapLocation l = new MapLocation();
            l.x = x;
            l.y = y;

            NetworkInfo n = new NetworkInfo();

            Device d = new Device();
            d.did = 0;
            d.name = name;
            d.type = dt;

            d.loc = l;
            d.net = n;
            return d;
        }
        public Device makeDevice(string name, DeviceType dt, MapLocation loc, NetworkInfo net)
        {
            // name, type, location, 
            // network info

            Device d = new Device();
            d.did = 0;
            d.name = name;
            d.type = dt;

            d.loc = loc;
            d.net = net;
            return d;
        }

        public Device makeDevice(int did, string name, DeviceType dt, MapLocation loc, NetworkInfo net)
        {
            // name, type, location, 
            // network info

            Device d = new Device();
            d.did = did;
            d.name = name;
            d.type = dt;

            d.loc = loc;
            d.net = net;
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

        public DeviceType dvert(string d) {
            DeviceType dtype = DeviceType.WorkStation;

            switch (d)
            {
                case "WorkStation": dtype = DeviceType.WorkStation;
                    break;
                case "Printer": dtype = DeviceType.Printer;
                    break;
                case "Router": dtype = DeviceType.Router;
                    break;
                case "Switch": dtype = DeviceType.Switch;
                    break;
                case "FireWall": dtype = DeviceType.Firewall;
                    break;
                case "": dtype = DeviceType.WorkStation;
                    break;
                case "Other": dtype = DeviceType.WorkStation;
                    break;

            }


            return dtype;
        }

        public string filename = "..\\..\\devices0.csv";
        public void loadNetFile() {
            int counter = 0;
            string filepath = "";
            
            string line;
            string[] aline;
            int did;
            string name;
            MapLocation loc;
            int x, y, z, room;
            DeviceType dt;
            NetworkInfo net;

            try
            {
                filepath=System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                System.IO.StreamReader file =
                  new System.IO.StreamReader(filename);
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    aline=line.Split(',');
                    did = int.Parse(aline[0]);
                    name = aline[1];
                    dt = dvert(aline[2]); 
                    x = int.Parse(aline[3]);
                    y = int.Parse(aline[4]);
                    z = int.Parse(aline[5]);
                    room = int.Parse(aline[6]);
                    loc = new MapLocation(x,y,z,room);
                    net = new NetworkInfo();

                    network.Add(makeDevice(did,name,dt ,loc , net));
                    counter++;
                }

                file.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        
        
        
        
        
        }


        public void saveNetFile()
        {


        }
        public void saveNetFile(string n)
        {
            // declare
            int counter = 0;
            string line;
            string filepath = "";
            string[] aline;
            filename = "devices0.csv";
            // open

            System.IO.StreamWriter file =  new System.IO.StreamWriter(filename);

            // write

                // whille arreaylist
                foreach (Device d in network) {
                    // build line
                    line ="";
                    // id , type, name, x,y,z,room, netinfo
                    line = d.did + "," + d.name +"," + d.type +  "," + d.loc.x + "," + d.loc.y + "," + d.loc.z + "," + d.loc.room + "," + "0";    
                    // write line
                    file.WriteLine(line);
                    counter++;
                }
            // close

            file.Close();

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
