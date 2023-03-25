namespace Bank_Blood
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelOpositive = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOpositiveCount = new System.Windows.Forms.Label();
            this.picOpositive = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnegativeCount = new System.Windows.Forms.Label();
            this.picOnegative = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAnegativeCount = new System.Windows.Forms.Label();
            this.picAnegative = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblApositiveCount = new System.Windows.Forms.Label();
            this.picApositive = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblABnegativeCount = new System.Windows.Forms.Label();
            this.picABnegative = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblABpositiveCount = new System.Windows.Forms.Label();
            this.picABpositive = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBnegativeCount = new System.Windows.Forms.Label();
            this.picBnegative = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBpositiveCount = new System.Windows.Forms.Label();
            this.picBpositive = new System.Windows.Forms.PictureBox();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripTop.SuspendLayout();
            this.panelOpositive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpositive)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOnegative)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnegative)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApositive)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picABnegative)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picABpositive)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBnegative)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBpositive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.BackColor = System.Drawing.Color.Crimson;
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.donorsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStripTop.Size = new System.Drawing.Size(1123, 45);
            this.menuStripTop.TabIndex = 0;
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.donorsToolStripMenuItem.Text = "Donors";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
            // 
            // panelOpositive
            // 
            this.panelOpositive.BackColor = System.Drawing.Color.White;
            this.panelOpositive.Controls.Add(this.lblName);
            this.panelOpositive.Controls.Add(this.lblOpositiveCount);
            this.panelOpositive.Controls.Add(this.picOpositive);
            this.panelOpositive.Location = new System.Drawing.Point(54, 52);
            this.panelOpositive.Name = "panelOpositive";
            this.panelOpositive.Size = new System.Drawing.Size(168, 102);
            this.panelOpositive.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(107, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Donors";
            // 
            // lblOpositiveCount
            // 
            this.lblOpositiveCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpositiveCount.AutoSize = true;
            this.lblOpositiveCount.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpositiveCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblOpositiveCount.Location = new System.Drawing.Point(103, 10);
            this.lblOpositiveCount.Name = "lblOpositiveCount";
            this.lblOpositiveCount.Size = new System.Drawing.Size(62, 37);
            this.lblOpositiveCount.TabIndex = 1;
            this.lblOpositiveCount.Text = "100";
            // 
            // picOpositive
            // 
            this.picOpositive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picOpositive.BackgroundImage")));
            this.picOpositive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOpositive.Location = new System.Drawing.Point(0, 0);
            this.picOpositive.Name = "picOpositive";
            this.picOpositive.Size = new System.Drawing.Size(91, 99);
            this.picOpositive.TabIndex = 0;
            this.picOpositive.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblOnegativeCount);
            this.panel1.Controls.Add(this.picOnegative);
            this.panel1.Location = new System.Drawing.Point(262, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 102);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(107, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Donors";
            // 
            // lblOnegativeCount
            // 
            this.lblOnegativeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOnegativeCount.AutoSize = true;
            this.lblOnegativeCount.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegativeCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblOnegativeCount.Location = new System.Drawing.Point(103, 10);
            this.lblOnegativeCount.Name = "lblOnegativeCount";
            this.lblOnegativeCount.Size = new System.Drawing.Size(62, 37);
            this.lblOnegativeCount.TabIndex = 1;
            this.lblOnegativeCount.Text = "100";
            // 
            // picOnegative
            // 
            this.picOnegative.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picOnegative.BackgroundImage")));
            this.picOnegative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOnegative.Location = new System.Drawing.Point(3, 3);
            this.picOnegative.Name = "picOnegative";
            this.picOnegative.Size = new System.Drawing.Size(91, 99);
            this.picOnegative.TabIndex = 0;
            this.picOnegative.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblAnegativeCount);
            this.panel2.Controls.Add(this.picAnegative);
            this.panel2.Location = new System.Drawing.Point(262, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 102);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(107, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Donors";
            // 
            // lblAnegativeCount
            // 
            this.lblAnegativeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnegativeCount.AutoSize = true;
            this.lblAnegativeCount.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegativeCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblAnegativeCount.Location = new System.Drawing.Point(103, 3);
            this.lblAnegativeCount.Name = "lblAnegativeCount";
            this.lblAnegativeCount.Size = new System.Drawing.Size(62, 37);
            this.lblAnegativeCount.TabIndex = 1;
            this.lblAnegativeCount.Text = "100";
            // 
            // picAnegative
            // 
            this.picAnegative.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAnegative.BackgroundImage")));
            this.picAnegative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAnegative.Location = new System.Drawing.Point(3, 3);
            this.picAnegative.Name = "picAnegative";
            this.picAnegative.Size = new System.Drawing.Size(94, 99);
            this.picAnegative.TabIndex = 0;
            this.picAnegative.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblApositiveCount);
            this.panel3.Controls.Add(this.picApositive);
            this.panel3.Location = new System.Drawing.Point(54, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 102);
            this.panel3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(107, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Donors";
            // 
            // lblApositiveCount
            // 
            this.lblApositiveCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApositiveCount.AutoSize = true;
            this.lblApositiveCount.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositiveCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblApositiveCount.Location = new System.Drawing.Point(106, 3);
            this.lblApositiveCount.Name = "lblApositiveCount";
            this.lblApositiveCount.Size = new System.Drawing.Size(62, 37);
            this.lblApositiveCount.TabIndex = 1;
            this.lblApositiveCount.Text = "100";
            // 
            // picApositive
            // 
            this.picApositive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picApositive.BackgroundImage")));
            this.picApositive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picApositive.Location = new System.Drawing.Point(3, 3);
            this.picApositive.Name = "picApositive";
            this.picApositive.Size = new System.Drawing.Size(91, 99);
            this.picApositive.TabIndex = 0;
            this.picApositive.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblABnegativeCount);
            this.panel4.Controls.Add(this.picABnegative);
            this.panel4.Location = new System.Drawing.Point(262, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 102);
            this.panel4.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(97, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Donors";
            // 
            // lblABnegativeCount
            // 
            this.lblABnegativeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblABnegativeCount.AutoSize = true;
            this.lblABnegativeCount.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegativeCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblABnegativeCount.Location = new System.Drawing.Point(93, 3);
            this.lblABnegativeCount.Name = "lblABnegativeCount";
            this.lblABnegativeCount.Size = new System.Drawing.Size(62, 37);
            this.lblABnegativeCount.TabIndex = 1;
            this.lblABnegativeCount.Text = "100";
            // 
            // picABnegative
            // 
            this.picABnegative.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picABnegative.BackgroundImage")));
            this.picABnegative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picABnegative.Location = new System.Drawing.Point(3, 3);
            this.picABnegative.Name = "picABnegative";
            this.picABnegative.Size = new System.Drawing.Size(91, 99);
            this.picABnegative.TabIndex = 0;
            this.picABnegative.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.lblABpositiveCount);
            this.panel5.Controls.Add(this.picABpositive);
            this.panel5.Location = new System.Drawing.Point(60, 381);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(168, 102);
            this.panel5.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(107, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Donors";
            // 
            // lblABpositiveCount
            // 
            this.lblABpositiveCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblABpositiveCount.AutoSize = true;
            this.lblABpositiveCount.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpositiveCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblABpositiveCount.Location = new System.Drawing.Point(103, 3);
            this.lblABpositiveCount.Name = "lblABpositiveCount";
            this.lblABpositiveCount.Size = new System.Drawing.Size(62, 37);
            this.lblABpositiveCount.TabIndex = 1;
            this.lblABpositiveCount.Text = "100";
            // 
            // picABpositive
            // 
            this.picABpositive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picABpositive.BackgroundImage")));
            this.picABpositive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picABpositive.Location = new System.Drawing.Point(3, 3);
            this.picABpositive.Name = "picABpositive";
            this.picABpositive.Size = new System.Drawing.Size(91, 99);
            this.picABpositive.TabIndex = 0;
            this.picABpositive.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.lblBnegativeCount);
            this.panel6.Controls.Add(this.picBnegative);
            this.panel6.Location = new System.Drawing.Point(262, 268);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(168, 102);
            this.panel6.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(103, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Donors";
            // 
            // lblBnegativeCount
            // 
            this.lblBnegativeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBnegativeCount.AutoSize = true;
            this.lblBnegativeCount.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegativeCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblBnegativeCount.Location = new System.Drawing.Point(99, 0);
            this.lblBnegativeCount.Name = "lblBnegativeCount";
            this.lblBnegativeCount.Size = new System.Drawing.Size(62, 37);
            this.lblBnegativeCount.TabIndex = 1;
            this.lblBnegativeCount.Text = "100";
            // 
            // picBnegative
            // 
            this.picBnegative.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBnegative.BackgroundImage")));
            this.picBnegative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBnegative.Location = new System.Drawing.Point(3, 3);
            this.picBnegative.Name = "picBnegative";
            this.picBnegative.Size = new System.Drawing.Size(91, 99);
            this.picBnegative.TabIndex = 0;
            this.picBnegative.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.lblBpositiveCount);
            this.panel7.Controls.Add(this.picBpositive);
            this.panel7.Location = new System.Drawing.Point(57, 268);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(168, 102);
            this.panel7.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(110, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Donors";
            // 
            // lblBpositiveCount
            // 
            this.lblBpositiveCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBpositiveCount.AutoSize = true;
            this.lblBpositiveCount.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpositiveCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblBpositiveCount.Location = new System.Drawing.Point(106, 0);
            this.lblBpositiveCount.Name = "lblBpositiveCount";
            this.lblBpositiveCount.Size = new System.Drawing.Size(62, 37);
            this.lblBpositiveCount.TabIndex = 1;
            this.lblBpositiveCount.Text = "100";
            // 
            // picBpositive
            // 
            this.picBpositive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBpositive.BackgroundImage")));
            this.picBpositive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBpositive.Location = new System.Drawing.Point(3, 3);
            this.picBpositive.Name = "picBpositive";
            this.picBpositive.Size = new System.Drawing.Size(91, 99);
            this.picBpositive.TabIndex = 0;
            this.picBpositive.TabStop = false;
            // 
            // dgvDonors
            // 
            this.dgvDonors.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDonors.Location = new System.Drawing.Point(504, 106);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.Size = new System.Drawing.Size(555, 338);
            this.dgvDonors.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(531, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(528, 25);
            this.txtSearch.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1069, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 45);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "X";
            this.btnExit.UseCompatibleTextRendering = true;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(459, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Blood Bank Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDonors);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOpositive);
            this.Controls.Add(this.menuStripTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripTop;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelOpositive.ResumeLayout(false);
            this.panelOpositive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpositive)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOnegative)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnegative)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApositive)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picABnegative)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picABpositive)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBnegative)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBpositive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.Panel panelOpositive;
        private System.Windows.Forms.PictureBox picOpositive;
        private System.Windows.Forms.Label lblOpositiveCount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnegativeCount;
        private System.Windows.Forms.PictureBox picOnegative;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnegativeCount;
        private System.Windows.Forms.PictureBox picAnegative;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApositiveCount;
        private System.Windows.Forms.PictureBox picApositive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblABnegativeCount;
        private System.Windows.Forms.PictureBox picABnegative;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblABpositiveCount;
        private System.Windows.Forms.PictureBox picABpositive;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBnegativeCount;
        private System.Windows.Forms.PictureBox picBnegative;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBpositiveCount;
        private System.Windows.Forms.PictureBox picBpositive;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

