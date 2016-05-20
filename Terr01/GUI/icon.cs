using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terr01
{
    class Icon:PictureBox
    {
        public DeviceType dtype;
        public Device device;
        public string name;
        public MapLocation loc;

        int ix, iy, mx, my;
        private ContextMenuStrip mnuNetwork;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private System.ComponentModel.IContainer components;
    
        public Icon() {
            this.Height = 20;
            this.Width = 25;
            this.BackColor = Color.Blue;
            this.BorderStyle = BorderStyle.FixedSingle;
            dtype = DeviceType.WorkStation;
            loc = new MapLocation();

            InitializeComponent();

            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myMouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myMouseUp);
        }
        private void myMouseDown(object sender, MouseEventArgs e)
        {
            // GET start x,y
            String text = "";
            ix = this.Left;
            iy = this.Top;
            mx = e.Location.X;
            my = e.Location.Y;
            if (this.device == null) name = "me"; else name = this.device.name;
            text = "Mouse Down" + ix + " " + iy + " " + mx + " " + my+ " "+this.name;
            Console.WriteLine(text);
        }
        private void myMouseUp(object sender, MouseEventArgs e)
        {
            int nx = e.Location.X;
            int ny = e.Location.Y;
            if(e.Button==MouseButtons.Right){
                this.mnuNetwork.Show(this,nx, ny);
            }

            string text = "";

            this.loc.x= this.Left = ix + nx - mx;
            this.loc.y= this.Top = iy + ny - my;
            this.loc.z = this.device.loc.z;
            // todo set new room


            // GET start x,y
           
            if (this.device == null) name = "me"; else name = this.device.name;
            text = "Mouse Down" + ix + " " + iy + " " + mx + " " + my + " " + this.name;
            Console.WriteLine(text);
        }
       
        public void setColor() {
            switch (dtype) {
                case DeviceType.WorkStation:
                    this.BackColor = Color.LightGreen;
                    break;

                case DeviceType.Printer:
                    this.BackColor = Color.LightGreen;
                    break;
                case DeviceType.Router:
                    this.BackColor = Color.MediumBlue;
                    break;
                case DeviceType.Switch:
                    this.BackColor = Color.Turquoise;
                    break;
                case DeviceType.Bridge:
                    this.BackColor = Color.Yellow;
                    break;
                case DeviceType.Firewall:
                    this.BackColor = Color.Red;
                    break;

            
            }
        
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuNetwork = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuNetwork
            // 
            this.mnuNetwork.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.mnuNetwork.Name = "mnuNetwork";
            this.mnuNetwork.Size = new System.Drawing.Size(129, 48);
            this.mnuNetwork.Text = "Network";
            this.mnuNetwork.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem1.Text = "Net Name";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem2.Text = "Net ID";
            this.mnuNetwork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


    }
}
