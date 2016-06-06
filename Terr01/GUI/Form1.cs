using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Terr01
{
    public partial class Form1 : Form
    {
        //this.Panel p1=this.
        Panel p1;


        /////// globals
        // map

        Model ourModel = new Model();

        
        public Form1()
        {
            InitializeComponent();
            
            /// init globals
            p1 = this.panel1;

            ourModel.network = new ArrayList();
            ourModel.loadNetFile();
            this.txtFilename.Text = ourModel.filename;

            g = this.panel1.CreateGraphics();
            //  create icons
            makeIcons();
        }



        private void makeIcons() { 
            
            // for each divice, create an icon
            // 

            foreach (Device d in ourModel.network) {
                Icon ic = new Icon();
                // add to page
                this.p1.Controls.Add(ic);
                ic.device = d;
                ic.Top = ic.loc.y = d.loc.y;
                ic.Left = ic.loc.x = d.loc.x;
                ic.loc.z = d.loc.z;
                ic.loc.room = d.loc.room;
                
                ic.dtype = d.type;
                ic.setColor();
                ic.Show();
            }

        }





        private void button1_Click(object sender, EventArgs e)
        {
            // Load it 

            // draw it 
            DrawIt();
        }



        System.Drawing.Graphics g;
        private void DrawGrid(){
            
            int i=0;
            for (i = 0; i < p1.Width;i+=20 ) {
                g.DrawLine(System.Drawing.Pens.Black, i, 0, i, p1.Height);
                g.DrawLine(System.Drawing.Pens.Black, 0, i, p1.Width, i);
            }        
        }

        private void DrawIt()
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(50, 50, 450, 450);
            g.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            g.DrawRectangle(System.Drawing.Pens.Red, rectangle);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            DrawGrid();
        }

        bool moving = false;



        private void btnSnap_Click(object sender, EventArgs e)
        {
            Terr01.MapLocation loc;
 
            foreach (Icon ic in this.p1.Controls)// ourModel.network)
            {
                //count++;
               // loc = ic.loc;
                ic.loc.y=ic.Top = (int) Math.Floor((ic.Top+5) / 10.0)*10;
                ic.loc.x=ic.Left = (int)Math.Floor((ic.Left+5) / 10.0) * 10;

                //ic.device.loc = ic.loc;
            }
            
        }
        private void updateLocs() {
            int count = 0;
            foreach (Icon ic in this.p1.Controls)// ourModel.network)
            {
                count++;
                ic.device.loc = ic.loc;
            }
        } 
        private void btnSave_Click(object sender, EventArgs e)
        {
            // update model with 
            updateLocs();
            ourModel.filename = this.txtFilename.Text;
            ourModel.saveNetFile("");
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int x = 0, y = 0;
                x = e.Location.X;
                y = e.Location.Y;

                this.contextMenuStrip1.Show(p1, x, y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // update filename  todo:validate filename
            ourModel.filename = txtFilename.Text;
            // load file into network
            ourModel.network = new ArrayList();
            ourModel.loadNetFile();

            // update icons 
            
                // delete old icons
            this.p1.Controls.Clear();
                // create new icons
            this.makeIcons();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDBConnect_Click(object sender, EventArgs e)
        {
            ourModel.connect();

        }





        private void btnCloseDB_Click(object sender, EventArgs e)
        {
            ourModel.close();
        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            ourModel.saveNetDB();
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            ourModel.UpdateDB();
        }




    }
}
