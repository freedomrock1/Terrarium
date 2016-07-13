using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Svg_Preprocessor {
    public partial class SvgPreprocessor : Form {
        const int MODE_NONE = 0;
        const int MODE_KEY = 1;
        const int MODE_CORROSION = 2;
        const int MODE_BNW = 3;
        Boolean previewed = false;
        float offsetX = 0, offsetY = 0, scale = 1;
        float prevX = -1, prevY = -1;
        Bitmap bufferedImage;
        MouseButtons mouseButton = System.Windows.Forms.MouseButtons.None;
        Bitmap original, preview;
        SolidBrush background = new SolidBrush(Color.Black);
        int mode = MODE_NONE;

        public SvgPreprocessor() {
            InitializeComponent();
            bufferedImage = new Bitmap(panel4.Width, panel4.Height);
        }

        private void button4_Click(object sender, EventArgs e) {
            cancelMode();
            mode = MODE_KEY;
            changeMode();
        }

        private void button5_Click(object sender, EventArgs e) {
            cancelMode();
            mode = MODE_CORROSION;
            changeMode();
        }

        private void button8_Click(object sender, EventArgs e) {
            cancelMode();
            mode = MODE_BNW;
            changeMode();
        }

        private void button6_Click(object sender, EventArgs e) {
            cancelMode();
        }

        private void button2_Click(object sender, EventArgs e) {
            cancelMode();
        }

        private void button10_Click(object sender, EventArgs e) {
            cancelMode();
        }

        private void cancelMode() {
            mode = MODE_NONE;
            preview = (Bitmap) original.Clone();
            redraw();
            changeMode();
        }

        private void applyChanges() {
            if (!previewed) previewEffect();
            mode = MODE_NONE;
            original = (Bitmap)preview.Clone();
            redraw();
            changeMode();
            previewed = false;
        }

        private void changeMode() {
            pnlBlank.Enabled = false;
            pnlCorrosion.Enabled = false;
            pnlKey.Enabled = false;
            pnlBNW.Enabled = false;
            Panel panel;
            switch (mode) {
                case MODE_KEY:
                    panel = pnlKey;
                    break;
                case MODE_CORROSION:
                    panel = pnlCorrosion;
                    break;
                case MODE_BNW:
                    panel = pnlBNW;
                    break;
                default:
                    panel = pnlBlank;
                    break;
            }
            panel.Enabled = true;
            panel.BringToFront();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e) {
            previewEffect();
        }

        private void button12_Click(object sender, EventArgs e) {
            previewEffect();
        }

        private void button11_Click(object sender, EventArgs e) {
            previewEffect();
        }

        private void previewEffect() {
            previewed = true;
            switch (mode) {
                case MODE_KEY:
                    break;
                case MODE_CORROSION:
                    break;
                case MODE_BNW:
                    int i = 0, j = 0;
                    //Color originalColor;
                    float averageColor = 0;
                    float threshold = (float) trkBNWThreshold.Value;
                    for (i = 0; i < original.Height; i++) {
                        for (j = 0; j < original.Width; j++) {
                            Color originalColor = original.GetPixel(j, i);
                            averageColor = (((int)originalColor.R & 0xFF) + ((int) originalColor.G & 0xFF) + ((int) originalColor.B & 0xFF)) / 3;
                            //System.Diagnostics.Debug.WriteLine(averageColor + "");
                            if (averageColor < threshold) {
                                preview.SetPixel(j, i, Color.Black);
                            } else {
                                preview.SetPixel(j, i, Color.White);
                            }
                        }
                    }
                    break;
            }
            redraw();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                original = (Bitmap) Image.FromFile(openFileDialog1.FileName);
                preview = (Bitmap)original.Clone();
                redraw();
            }
        }

        private void redraw() {
            if (preview != null) {
                Graphics g = Graphics.FromImage(bufferedImage);
                g.FillRectangle(background, 0, 0, panel4.Width, panel4.Height);
                float x = (float)panel4.Width / 2 - ((float)preview.Width / 2 - offsetX) * scale;
                float y = (float)panel4.Height / 2 - ((float)preview.Height / 2 - offsetY) * scale;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(preview, x, y, preview.Width * scale, preview.Height * scale);
                this.Text = x + ", " + y;
                g = panel4.CreateGraphics();
                g.DrawImage(bufferedImage, 0, 0);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e) {
            redraw();
        }

        private void panel4_Resize(object sender, EventArgs e) {
            bufferedImage = new Bitmap(panel4.Width, panel4.Height);
            redraw();
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e) {
            if (mouseButton != System.Windows.Forms.MouseButtons.None) {
                if (mouseButton == System.Windows.Forms.MouseButtons.Middle) {
                    if (prevX == -1) prevX = e.X;
                    if (prevY == -1) prevY = e.Y;
                    offsetX += (e.X - prevX) / scale;
                    offsetY += (e.Y - prevY) / scale;
                    redraw();
                    prevX = e.X;
                    prevY = e.Y;
                }
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e) {
            mouseButton = e.Button;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e) {
            mouseButton = System.Windows.Forms.MouseButtons.None;
            prevX = -1;
            prevY = -1;
        }

        private void panel4_MouseWheel(object sender, MouseEventArgs e) {
            scale *= (1 + (float) e.Delta / 1000);
            scale = clamp(scale, .25f, 200f);
            redraw();
        }

        private float clamp(float original, float min, float max) {
            return original < min ? min : original > max ? max : original;
        }

        private void button9_Click(object sender, EventArgs e) {
            applyChanges();
        }

        private void trkBNWThreshold_Scroll(object sender, EventArgs e) {
            previewed = false;
        }

        private void button14_Click(object sender, EventArgs e) {
            cancelMode();

        }
    }
}
