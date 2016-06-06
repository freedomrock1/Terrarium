namespace Terr01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnSnap = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDBConnect = new System.Windows.Forms.Button();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.btnCloseDB = new System.Windows.Forms.Button();
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw It";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 562);
            this.panel1.TabIndex = 1;
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(12, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Grid";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 6);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(174, 20);
            this.txt1.TabIndex = 3;
            // 
            // btnSnap
            // 
            this.btnSnap.Location = new System.Drawing.Point(174, 600);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(75, 23);
            this.btnSnap.TabIndex = 4;
            this.btnSnap.Text = "Snap";
            this.btnSnap.UseVisualStyleBackColor = true;
            this.btnSnap.Click += new System.EventHandler(this.btnSnap_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(255, 600);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 48);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(130, 22);
            this.mnuAdd.Text = "Add Thing";
            // 
            // mnu
            // 
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(130, 22);
            this.mnu.Text = "Edit";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(346, 601);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(438, 602);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(446, 20);
            this.txtFilename.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateDB);
            this.groupBox1.Controls.Add(this.btnCloseDB);
            this.groupBox1.Controls.Add(this.btnSaveDB);
            this.groupBox1.Controls.Add(this.btnDBConnect);
            this.groupBox1.Location = new System.Drawing.Point(891, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 341);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDBConnect
            // 
            this.btnDBConnect.Location = new System.Drawing.Point(5, 19);
            this.btnDBConnect.Name = "btnDBConnect";
            this.btnDBConnect.Size = new System.Drawing.Size(75, 23);
            this.btnDBConnect.TabIndex = 0;
            this.btnDBConnect.Text = "Connect";
            this.btnDBConnect.UseVisualStyleBackColor = true;
            this.btnDBConnect.Click += new System.EventHandler(this.btnDBConnect_Click);
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Location = new System.Drawing.Point(5, 48);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDB.TabIndex = 1;
            this.btnSaveDB.Text = "Insert0";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.btnSaveDB_Click);
            // 
            // btnCloseDB
            // 
            this.btnCloseDB.Location = new System.Drawing.Point(7, 197);
            this.btnCloseDB.Name = "btnCloseDB";
            this.btnCloseDB.Size = new System.Drawing.Size(75, 23);
            this.btnCloseDB.TabIndex = 2;
            this.btnCloseDB.Text = "Close";
            this.btnCloseDB.UseVisualStyleBackColor = true;
            this.btnCloseDB.Click += new System.EventHandler(this.btnCloseDB_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(5, 86);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDB.TabIndex = 3;
            this.btnUpdateDB.Text = "Update";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(989, 730);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSnap);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terrarium";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnSnap;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnu;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDBConnect;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.Button btnCloseDB;
        private System.Windows.Forms.Button btnUpdateDB;
    }
}

