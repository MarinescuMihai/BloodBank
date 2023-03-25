namespace Bank_Blood.UI
{
    partial class FormDonors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonors));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelDonors = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tnSearchDonor = new System.Windows.Forms.TextBox();
            this.dbvDonors = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddDonor = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbBloodId = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.lbDonorId = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lbFName = new System.Windows.Forms.Label();
            this.btnChangePicture = new System.Windows.Forms.Button();
            this.picProfilePicture = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbLName = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbvDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.Crimson;
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.labelDonors);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1124, 44);
            this.panelTop.TabIndex = 24;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(21, 18);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1070, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 45);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelDonors
            // 
            this.labelDonors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDonors.AutoSize = true;
            this.labelDonors.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonors.ForeColor = System.Drawing.Color.White;
            this.labelDonors.Location = new System.Drawing.Point(527, 9);
            this.labelDonors.Name = "labelDonors";
            this.labelDonors.Size = new System.Drawing.Size(74, 25);
            this.labelDonors.TabIndex = 0;
            this.labelDonors.Text = "Donors";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(532, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // tnSearchDonor
            // 
            this.tnSearchDonor.Location = new System.Drawing.Point(559, 61);
            this.tnSearchDonor.Name = "tnSearchDonor";
            this.tnSearchDonor.Size = new System.Drawing.Size(528, 20);
            this.tnSearchDonor.TabIndex = 71;
            // 
            // dbvDonors
            // 
            this.dbvDonors.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dbvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbvDonors.Location = new System.Drawing.Point(532, 94);
            this.dbvDonors.Name = "dbvDonors";
            this.dbvDonors.Size = new System.Drawing.Size(555, 338);
            this.dbvDonors.TabIndex = 70;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(28, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 25);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(324, 453);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 25);
            this.btnClear.TabIndex = 68;
            this.btnClear.Text = "Clear Text";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(28, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 27);
            this.btnUpdate.TabIndex = 67;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAddDonor
            // 
            this.btnAddDonor.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDonor.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDonor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddDonor.Location = new System.Drawing.Point(28, 453);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(118, 25);
            this.btnAddDonor.TabIndex = 66;
            this.btnAddDonor.Text = "Add Donor";
            this.btnAddDonor.UseVisualStyleBackColor = false;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(285, 362);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(195, 70);
            this.tbAddress.TabIndex = 65;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(206, 362);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 17);
            this.lblAddress.TabIndex = 64;
            this.lblAddress.Text = "Address";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(285, 236);
            this.tbTelephone.MaxLength = 10;
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(195, 20);
            this.tbTelephone.TabIndex = 63;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(206, 239);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(68, 17);
            this.lblTelephone.TabIndex = 62;
            this.lblTelephone.Text = "Telephone";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(285, 317);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(195, 20);
            this.tbPassword.TabIndex = 61;
            // 
            // lbBloodId
            // 
            this.lbBloodId.AutoSize = true;
            this.lbBloodId.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBloodId.Location = new System.Drawing.Point(206, 320);
            this.lbBloodId.Name = "lbBloodId";
            this.lbBloodId.Size = new System.Drawing.Size(58, 17);
            this.lbBloodId.TabIndex = 60;
            this.lbBloodId.Text = "Blood ID";
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(285, 275);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(195, 20);
            this.tbGender.TabIndex = 59;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(206, 278);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(51, 17);
            this.lblGender.TabIndex = 58;
            this.lblGender.Text = "Gender";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(285, 193);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(195, 20);
            this.tbEmail.TabIndex = 57;
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(285, 79);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.ReadOnly = true;
            this.tbUserId.Size = new System.Drawing.Size(195, 20);
            this.tbUserId.TabIndex = 55;
            // 
            // lbDonorId
            // 
            this.lbDonorId.AutoSize = true;
            this.lbDonorId.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonorId.Location = new System.Drawing.Point(206, 79);
            this.lbDonorId.Name = "lbDonorId";
            this.lbDonorId.Size = new System.Drawing.Size(61, 17);
            this.lbDonorId.TabIndex = 54;
            this.lbDonorId.Text = "Donor ID";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(285, 115);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(195, 20);
            this.tbFullName.TabIndex = 53;
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFName.Location = new System.Drawing.Point(206, 118);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(71, 17);
            this.lbFName.TabIndex = 52;
            this.lbFName.Text = "First Name";
            // 
            // btnChangePicture
            // 
            this.btnChangePicture.BackColor = System.Drawing.Color.HotPink;
            this.btnChangePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePicture.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePicture.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChangePicture.Location = new System.Drawing.Point(28, 219);
            this.btnChangePicture.Name = "btnChangePicture";
            this.btnChangePicture.Size = new System.Drawing.Size(118, 27);
            this.btnChangePicture.TabIndex = 51;
            this.btnChangePicture.Text = "Change Picture";
            this.btnChangePicture.UseVisualStyleBackColor = false;
            // 
            // picProfilePicture
            // 
            this.picProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("picProfilePicture.Image")));
            this.picProfilePicture.InitialImage = null;
            this.picProfilePicture.Location = new System.Drawing.Point(28, 94);
            this.picProfilePicture.Name = "picProfilePicture";
            this.picProfilePicture.Size = new System.Drawing.Size(118, 119);
            this.picProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfilePicture.TabIndex = 50;
            this.picProfilePicture.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(206, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 56;
            this.lblEmail.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 74;
            // 
            // lbLName
            // 
            this.lbLName.AutoSize = true;
            this.lbLName.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLName.Location = new System.Drawing.Point(206, 157);
            this.lbLName.Name = "lbLName";
            this.lbLName.Size = new System.Drawing.Size(70, 17);
            this.lbLName.TabIndex = 73;
            this.lbLName.Text = "Last Name";
            // 
            // FormDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 495);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbLName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tnSearchDonor);
            this.Controls.Add(this.dbvDonors);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddDonor);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbBloodId);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbUserId);
            this.Controls.Add(this.lbDonorId);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lbFName);
            this.Controls.Add(this.btnChangePicture);
            this.Controls.Add(this.picProfilePicture);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donors";
            this.Load += new System.EventHandler(this.FormDonors_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbvDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelDonors;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tnSearchDonor;
        private System.Windows.Forms.DataGridView dbvDonors;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddDonor;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbBloodId;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label lbDonorId;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.Button btnChangePicture;
        private System.Windows.Forms.PictureBox picProfilePicture;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbLName;
    }
}