using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Terr01
{
    public class Controller
    {
        public static void Main()
        {
            Console.WriteLine("stuff starts");
            // load model
            //Program.Main();
            // start gui 
            
            Console.WriteLine("more stuff starts");
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();


        }

    }
}