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

        int ix, iy, mx, my;
        public Icon() {
            this.Height = 20;
            this.Width = 25;
            this.BackColor = Color.Blue;
            this.BorderStyle = BorderStyle.FixedSingle;
            dtype = DeviceType.WorkStation;

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
            string text = "";

            this.Left = ix + nx - mx;
            this.Top = iy + ny - my;
            
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


    }
}
