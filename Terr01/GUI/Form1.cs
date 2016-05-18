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
                ic.Top = d.location.y;
                ic.Left = d.location.x;
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
            // for each device straiten out
            this.ourModel.connect();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ourModel.saveNetFile();
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




    }
}
