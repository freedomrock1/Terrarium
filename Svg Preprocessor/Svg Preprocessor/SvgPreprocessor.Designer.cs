namespace Svg_Preprocessor {
    partial class SvgPreprocessor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnModePatch = new System.Windows.Forms.Button();
            this.btnModeBNW = new System.Windows.Forms.Button();
            this.btnModeCorrosion = new System.Windows.Forms.Button();
            this.btnModeKey = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBlank = new System.Windows.Forms.Panel();
            this.pnlBNW = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trkBNWThreshold = new System.Windows.Forms.TrackBar();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.pnlPatch = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.pnlCorrosion = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pnlKey = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lstKeyColor = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlBNW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBNWThreshold)).BeginInit();
            this.pnlPatch.SuspendLayout();
            this.pnlCorrosion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.btnModePatch);
            this.panel1.Controls.Add(this.btnModeBNW);
            this.panel1.Controls.Add(this.btnModeCorrosion);
            this.panel1.Controls.Add(this.btnModeKey);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 142);
            this.panel1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(121, 8);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(133, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // btnModePatch
            // 
            this.btnModePatch.Location = new System.Drawing.Point(3, 109);
            this.btnModePatch.Name = "btnModePatch";
            this.btnModePatch.Size = new System.Drawing.Size(99, 23);
            this.btnModePatch.TabIndex = 4;
            this.btnModePatch.Text = "Patch";
            this.btnModePatch.UseVisualStyleBackColor = true;
            this.btnModePatch.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnModeBNW
            // 
            this.btnModeBNW.Location = new System.Drawing.Point(108, 82);
            this.btnModeBNW.Name = "btnModeBNW";
            this.btnModeBNW.Size = new System.Drawing.Size(146, 23);
            this.btnModeBNW.TabIndex = 3;
            this.btnModeBNW.Text = "Black and White";
            this.btnModeBNW.UseVisualStyleBackColor = true;
            this.btnModeBNW.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnModeCorrosion
            // 
            this.btnModeCorrosion.Location = new System.Drawing.Point(108, 109);
            this.btnModeCorrosion.Name = "btnModeCorrosion";
            this.btnModeCorrosion.Size = new System.Drawing.Size(146, 23);
            this.btnModeCorrosion.TabIndex = 2;
            this.btnModeCorrosion.Text = "Remove small patches";
            this.btnModeCorrosion.UseVisualStyleBackColor = true;
            this.btnModeCorrosion.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnModeKey
            // 
            this.btnModeKey.Location = new System.Drawing.Point(3, 81);
            this.btnModeKey.Name = "btnModeKey";
            this.btnModeKey.Size = new System.Drawing.Size(99, 23);
            this.btnModeKey.TabIndex = 1;
            this.btnModeKey.Text = "Key color";
            this.btnModeKey.UseVisualStyleBackColor = true;
            this.btnModeKey.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pnlKey);
            this.panel2.Controls.Add(this.pnlBlank);
            this.panel2.Controls.Add(this.pnlBNW);
            this.panel2.Controls.Add(this.pnlPatch);
            this.panel2.Controls.Add(this.pnlCorrosion);
            this.panel2.Location = new System.Drawing.Point(260, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 139);
            this.panel2.TabIndex = 0;
            // 
            // pnlBlank
            // 
            this.pnlBlank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBlank.Location = new System.Drawing.Point(0, 0);
            this.pnlBlank.Name = "pnlBlank";
            this.pnlBlank.Size = new System.Drawing.Size(379, 138);
            this.pnlBlank.TabIndex = 0;
            // 
            // pnlBNW
            // 
            this.pnlBNW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBNW.Controls.Add(this.button11);
            this.pnlBNW.Controls.Add(this.label3);
            this.pnlBNW.Controls.Add(this.trkBNWThreshold);
            this.pnlBNW.Controls.Add(this.button9);
            this.pnlBNW.Controls.Add(this.button10);
            this.pnlBNW.Location = new System.Drawing.Point(0, 0);
            this.pnlBNW.Name = "pnlBNW";
            this.pnlBNW.Size = new System.Drawing.Size(379, 138);
            this.pnlBNW.TabIndex = 4;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button11.Location = new System.Drawing.Point(6, 109);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 4;
            this.button11.Text = "Preview";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Threshold";
            // 
            // trkBNWThreshold
            // 
            this.trkBNWThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkBNWThreshold.Location = new System.Drawing.Point(6, 29);
            this.trkBNWThreshold.Maximum = 254;
            this.trkBNWThreshold.Minimum = 1;
            this.trkBNWThreshold.Name = "trkBNWThreshold";
            this.trkBNWThreshold.Size = new System.Drawing.Size(367, 45);
            this.trkBNWThreshold.TabIndex = 2;
            this.trkBNWThreshold.Value = 128;
            this.trkBNWThreshold.Scroll += new System.EventHandler(this.trkBNWThreshold_Scroll);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(219, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "Apply";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Location = new System.Drawing.Point(300, 109);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "Cancel";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pnlPatch
            // 
            this.pnlPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPatch.Controls.Add(this.button16);
            this.pnlPatch.Controls.Add(this.button17);
            this.pnlPatch.Location = new System.Drawing.Point(0, 0);
            this.pnlPatch.Name = "pnlPatch";
            this.pnlPatch.Size = new System.Drawing.Size(379, 138);
            this.pnlPatch.TabIndex = 5;
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Location = new System.Drawing.Point(219, 109);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "Apply";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.Location = new System.Drawing.Point(300, 109);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 0;
            this.button17.Text = "Cancel";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // pnlCorrosion
            // 
            this.pnlCorrosion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCorrosion.Controls.Add(this.button12);
            this.pnlCorrosion.Controls.Add(this.label2);
            this.pnlCorrosion.Controls.Add(this.trackBar2);
            this.pnlCorrosion.Controls.Add(this.button7);
            this.pnlCorrosion.Controls.Add(this.button6);
            this.pnlCorrosion.Location = new System.Drawing.Point(0, 0);
            this.pnlCorrosion.Name = "pnlCorrosion";
            this.pnlCorrosion.Size = new System.Drawing.Size(379, 138);
            this.pnlCorrosion.TabIndex = 2;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Location = new System.Drawing.Point(6, 109);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 5;
            this.button12.Text = "Preview";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pixels";
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.Location = new System.Drawing.Point(43, 9);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(334, 45);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Value = 1;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(300, 80);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Apply";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(300, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pnlKey
            // 
            this.pnlKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKey.Controls.Add(this.button4);
            this.pnlKey.Controls.Add(this.panel3);
            this.pnlKey.Controls.Add(this.lstKeyColor);
            this.pnlKey.Controls.Add(this.button13);
            this.pnlKey.Controls.Add(this.button3);
            this.pnlKey.Controls.Add(this.button2);
            this.pnlKey.Controls.Add(this.button1);
            this.pnlKey.Controls.Add(this.label1);
            this.pnlKey.Controls.Add(this.trackBar1);
            this.pnlKey.Location = new System.Drawing.Point(0, 0);
            this.pnlKey.Name = "pnlKey";
            this.pnlKey.Size = new System.Drawing.Size(379, 138);
            this.pnlKey.TabIndex = 1;
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Location = new System.Drawing.Point(313, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 66);
            this.button13.TabIndex = 5;
            this.button13.Text = "Preview";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(313, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(313, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pick Color";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Threshold";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(3, 88);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(302, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image files|*.png;*.jpg;*.bmp";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(12, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 295);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            this.panel4.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseWheel);
            this.panel4.Resize += new System.EventHandler(this.panel4_Resize);
            // 
            // lstKeyColor
            // 
            this.lstKeyColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKeyColor.FormattingEnabled = true;
            this.lstKeyColor.Location = new System.Drawing.Point(79, 5);
            this.lstKeyColor.Name = "lstKeyColor";
            this.lstKeyColor.Size = new System.Drawing.Size(182, 69);
            this.lstKeyColor.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(267, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 45);
            this.panel3.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(267, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 27);
            this.button4.TabIndex = 8;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SvgPreprocessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 482);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SvgPreprocessor";
            this.Text = "SVG Preprocessor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlBNW.ResumeLayout(false);
            this.pnlBNW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBNWThreshold)).EndInit();
            this.pnlPatch.ResumeLayout(false);
            this.pnlCorrosion.ResumeLayout(false);
            this.pnlCorrosion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBlank;
        private System.Windows.Forms.Panel pnlKey;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel pnlCorrosion;
        private System.Windows.Forms.Button btnModeCorrosion;
        private System.Windows.Forms.Button btnModeKey;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button btnModeBNW;
        private System.Windows.Forms.Panel pnlBNW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkBNWThreshold;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnModePatch;
        private System.Windows.Forms.Panel pnlPatch;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ListBox lstKeyColor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
    }
}

