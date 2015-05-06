namespace Steganography
{
    partial class Steganography
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.lblstegofile = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblloadimage = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblwritemessage = new System.Windows.Forms.Label();
            this.txtloadimage = new System.Windows.Forms.TextBox();
            this.btnbrowseimage = new System.Windows.Forms.Button();
            this.rtxtmessage = new System.Windows.Forms.RichTextBox();
            this.btnencrypt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInfoERes = new System.Windows.Forms.TextBox();
            this.txtInfoEWidth = new System.Windows.Forms.TextBox();
            this.txtinfoEHeight = new System.Windows.Forms.TextBox();
            this.txtinfoESize = new System.Windows.Forms.TextBox();
            this.lblresolution = new System.Windows.Forms.Label();
            this.lblwidth = new System.Windows.Forms.Label();
            this.lblheight = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblencryptmessage = new System.Windows.Forms.Label();
            this.rtxtencryptmessage = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtInfoDRes = new System.Windows.Forms.TextBox();
            this.txtInfoDWidth = new System.Windows.Forms.TextBox();
            this.txtInfoDHeight = new System.Windows.Forms.TextBox();
            this.txtInfoDSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbrowseD = new System.Windows.Forms.TextBox();
            this.btndecrypt = new System.Windows.Forms.Button();
            this.lblloadimgD = new System.Windows.Forms.Label();
            this.btnbrowseD = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Image Preview :";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt);
            this.groupBox2.Controls.Add(this.lblstegofile);
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Controls.Add(this.lblloadimage);
            this.groupBox2.Controls.Add(this.lblpassword);
            this.groupBox2.Controls.Add(this.lblwritemessage);
            this.groupBox2.Controls.Add(this.txtloadimage);
            this.groupBox2.Controls.Add(this.btnbrowseimage);
            this.groupBox2.Controls.Add(this.rtxtmessage);
            this.groupBox2.Controls.Add(this.btnencrypt);
            this.groupBox2.Location = new System.Drawing.Point(9, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 249);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(413, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(158, 151);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(232, 24);
            this.txt.TabIndex = 12;
            // 
            // lblstegofile
            // 
            this.lblstegofile.AutoSize = true;
            this.lblstegofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstegofile.Location = new System.Drawing.Point(30, 156);
            this.lblstegofile.Name = "lblstegofile";
            this.lblstegofile.Size = new System.Drawing.Size(65, 16);
            this.lblstegofile.TabIndex = 11;
            this.lblstegofile.Text = "Save As :";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.MintCream;
            this.txtpassword.Location = new System.Drawing.Point(158, 195);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(232, 24);
            this.txtpassword.TabIndex = 10;
            // 
            // lblloadimage
            // 
            this.lblloadimage.AutoSize = true;
            this.lblloadimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloadimage.Location = new System.Drawing.Point(21, 29);
            this.lblloadimage.Name = "lblloadimage";
            this.lblloadimage.Size = new System.Drawing.Size(86, 16);
            this.lblloadimage.TabIndex = 0;
            this.lblloadimage.Text = "Load Image :";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(30, 200);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(74, 16);
            this.lblpassword.TabIndex = 9;
            this.lblpassword.Text = "Password :";
            // 
            // lblwritemessage
            // 
            this.lblwritemessage.AutoSize = true;
            this.lblwritemessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwritemessage.Location = new System.Drawing.Point(6, 93);
            this.lblwritemessage.Name = "lblwritemessage";
            this.lblwritemessage.Size = new System.Drawing.Size(133, 16);
            this.lblwritemessage.TabIndex = 1;
            this.lblwritemessage.Text = "Message to Encrypt :";
            // 
            // txtloadimage
            // 
            this.txtloadimage.BackColor = System.Drawing.Color.MintCream;
            this.txtloadimage.Location = new System.Drawing.Point(158, 24);
            this.txtloadimage.Name = "txtloadimage";
            this.txtloadimage.Size = new System.Drawing.Size(232, 24);
            this.txtloadimage.TabIndex = 2;
            // 
            // btnbrowseimage
            // 
            this.btnbrowseimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowseimage.Location = new System.Drawing.Point(413, 22);
            this.btnbrowseimage.Name = "btnbrowseimage";
            this.btnbrowseimage.Size = new System.Drawing.Size(80, 30);
            this.btnbrowseimage.TabIndex = 4;
            this.btnbrowseimage.Text = "Browse";
            this.btnbrowseimage.UseVisualStyleBackColor = true;
            this.btnbrowseimage.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtxtmessage
            // 
            this.rtxtmessage.BackColor = System.Drawing.Color.MintCream;
            this.rtxtmessage.Location = new System.Drawing.Point(158, 73);
            this.rtxtmessage.Name = "rtxtmessage";
            this.rtxtmessage.Size = new System.Drawing.Size(335, 58);
            this.rtxtmessage.TabIndex = 7;
            this.rtxtmessage.Text = "";
            this.rtxtmessage.TextChanged += new System.EventHandler(this.rtxtmessage_TextChanged);
            // 
            // btnencrypt
            // 
            this.btnencrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencrypt.Location = new System.Drawing.Point(580, 108);
            this.btnencrypt.Name = "btnencrypt";
            this.btnencrypt.Size = new System.Drawing.Size(132, 64);
            this.btnencrypt.TabIndex = 6;
            this.btnencrypt.Text = "Encrypt";
            this.btnencrypt.UseVisualStyleBackColor = true;
            this.btnencrypt.Click += new System.EventHandler(this.btnencrypt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(167, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInfoERes);
            this.groupBox1.Controls.Add(this.txtInfoEWidth);
            this.groupBox1.Controls.Add(this.txtinfoEHeight);
            this.groupBox1.Controls.Add(this.txtinfoESize);
            this.groupBox1.Controls.Add(this.lblresolution);
            this.groupBox1.Controls.Add(this.lblwidth);
            this.groupBox1.Controls.Add(this.lblheight);
            this.groupBox1.Controls.Add(this.lblsize);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(513, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Information:";
            // 
            // txtInfoERes
            // 
            this.txtInfoERes.BackColor = System.Drawing.Color.MintCream;
            this.txtInfoERes.Location = new System.Drawing.Point(99, 139);
            this.txtInfoERes.Name = "txtInfoERes";
            this.txtInfoERes.Size = new System.Drawing.Size(109, 26);
            this.txtInfoERes.TabIndex = 12;
            // 
            // txtInfoEWidth
            // 
            this.txtInfoEWidth.BackColor = System.Drawing.Color.MintCream;
            this.txtInfoEWidth.Location = new System.Drawing.Point(99, 103);
            this.txtInfoEWidth.Name = "txtInfoEWidth";
            this.txtInfoEWidth.Size = new System.Drawing.Size(109, 26);
            this.txtInfoEWidth.TabIndex = 11;
            // 
            // txtinfoEHeight
            // 
            this.txtinfoEHeight.BackColor = System.Drawing.Color.MintCream;
            this.txtinfoEHeight.Location = new System.Drawing.Point(99, 64);
            this.txtinfoEHeight.Name = "txtinfoEHeight";
            this.txtinfoEHeight.Size = new System.Drawing.Size(109, 26);
            this.txtinfoEHeight.TabIndex = 10;
            // 
            // txtinfoESize
            // 
            this.txtinfoESize.BackColor = System.Drawing.Color.MintCream;
            this.txtinfoESize.Location = new System.Drawing.Point(99, 28);
            this.txtinfoESize.Name = "txtinfoESize";
            this.txtinfoESize.Size = new System.Drawing.Size(109, 26);
            this.txtinfoESize.TabIndex = 9;
            // 
            // lblresolution
            // 
            this.lblresolution.AutoSize = true;
            this.lblresolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresolution.Location = new System.Drawing.Point(6, 142);
            this.lblresolution.Name = "lblresolution";
            this.lblresolution.Size = new System.Drawing.Size(89, 20);
            this.lblresolution.TabIndex = 4;
            this.lblresolution.Text = "Resolution:";
            // 
            // lblwidth
            // 
            this.lblwidth.AutoSize = true;
            this.lblwidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwidth.Location = new System.Drawing.Point(16, 103);
            this.lblwidth.Name = "lblwidth";
            this.lblwidth.Size = new System.Drawing.Size(54, 20);
            this.lblwidth.TabIndex = 3;
            this.lblwidth.Text = "Width:";
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheight.Location = new System.Drawing.Point(16, 64);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(60, 20);
            this.lblheight.TabIndex = 2;
            this.lblheight.Text = "Height:";
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsize.Location = new System.Drawing.Point(16, 28);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(44, 20);
            this.lblsize.TabIndex = 1;
            this.lblsize.Text = "Size:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.lblencryptmessage);
            this.tabPage2.Controls.Add(this.rtxtencryptmessage);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            // 
            // lblencryptmessage
            // 
            this.lblencryptmessage.AutoSize = true;
            this.lblencryptmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblencryptmessage.Location = new System.Drawing.Point(25, 390);
            this.lblencryptmessage.Name = "lblencryptmessage";
            this.lblencryptmessage.Size = new System.Drawing.Size(158, 20);
            this.lblencryptmessage.TabIndex = 18;
            this.lblencryptmessage.Text = "Encrypted Message :";
            // 
            // rtxtencryptmessage
            // 
            this.rtxtencryptmessage.Location = new System.Drawing.Point(191, 352);
            this.rtxtencryptmessage.Name = "rtxtencryptmessage";
            this.rtxtencryptmessage.Size = new System.Drawing.Size(497, 94);
            this.rtxtencryptmessage.TabIndex = 17;
            this.rtxtencryptmessage.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Image Preview :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(191, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtInfoDRes);
            this.groupBox4.Controls.Add(this.txtInfoDWidth);
            this.groupBox4.Controls.Add(this.txtInfoDHeight);
            this.groupBox4.Controls.Add(this.txtInfoDSize);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(529, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 168);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image Information:";
            // 
            // txtInfoDRes
            // 
            this.txtInfoDRes.BackColor = System.Drawing.Color.MintCream;
            this.txtInfoDRes.Location = new System.Drawing.Point(99, 136);
            this.txtInfoDRes.Name = "txtInfoDRes";
            this.txtInfoDRes.Size = new System.Drawing.Size(103, 26);
            this.txtInfoDRes.TabIndex = 8;
            // 
            // txtInfoDWidth
            // 
            this.txtInfoDWidth.BackColor = System.Drawing.Color.MintCream;
            this.txtInfoDWidth.Location = new System.Drawing.Point(99, 100);
            this.txtInfoDWidth.Name = "txtInfoDWidth";
            this.txtInfoDWidth.Size = new System.Drawing.Size(103, 26);
            this.txtInfoDWidth.TabIndex = 7;
            // 
            // txtInfoDHeight
            // 
            this.txtInfoDHeight.BackColor = System.Drawing.Color.MintCream;
            this.txtInfoDHeight.Location = new System.Drawing.Point(99, 61);
            this.txtInfoDHeight.Name = "txtInfoDHeight";
            this.txtInfoDHeight.Size = new System.Drawing.Size(103, 26);
            this.txtInfoDHeight.TabIndex = 6;
            // 
            // txtInfoDSize
            // 
            this.txtInfoDSize.BackColor = System.Drawing.Color.MintCream;
            this.txtInfoDSize.Location = new System.Drawing.Point(99, 25);
            this.txtInfoDSize.Name = "txtInfoDSize";
            this.txtInfoDSize.Size = new System.Drawing.Size(103, 26);
            this.txtInfoDSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resolution:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Size:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDpass);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtbrowseD);
            this.groupBox3.Controls.Add(this.btndecrypt);
            this.groupBox3.Controls.Add(this.lblloadimgD);
            this.groupBox3.Controls.Add(this.btnbrowseD);
            this.groupBox3.Location = new System.Drawing.Point(6, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(731, 134);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // txtDpass
            // 
            this.txtDpass.BackColor = System.Drawing.Color.MintCream;
            this.txtDpass.Location = new System.Drawing.Point(126, 83);
            this.txtDpass.Name = "txtDpass";
            this.txtDpass.PasswordChar = '*';
            this.txtDpass.Size = new System.Drawing.Size(272, 24);
            this.txtDpass.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password :";
            // 
            // txtbrowseD
            // 
            this.txtbrowseD.BackColor = System.Drawing.Color.MintCream;
            this.txtbrowseD.Location = new System.Drawing.Point(126, 30);
            this.txtbrowseD.Name = "txtbrowseD";
            this.txtbrowseD.Size = new System.Drawing.Size(272, 24);
            this.txtbrowseD.TabIndex = 8;
            // 
            // btndecrypt
            // 
            this.btndecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndecrypt.Location = new System.Drawing.Point(442, 65);
            this.btndecrypt.Name = "btndecrypt";
            this.btndecrypt.Size = new System.Drawing.Size(117, 59);
            this.btndecrypt.TabIndex = 12;
            this.btndecrypt.Text = "Decrypt";
            this.btndecrypt.UseVisualStyleBackColor = true;
            this.btndecrypt.Click += new System.EventHandler(this.btndecrypt_Click);
            // 
            // lblloadimgD
            // 
            this.lblloadimgD.AutoSize = true;
            this.lblloadimgD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloadimgD.Location = new System.Drawing.Point(19, 35);
            this.lblloadimgD.Name = "lblloadimgD";
            this.lblloadimgD.Size = new System.Drawing.Size(83, 16);
            this.lblloadimgD.TabIndex = 6;
            this.lblloadimgD.Text = "Load Image:";
            // 
            // btnbrowseD
            // 
            this.btnbrowseD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowseD.Location = new System.Drawing.Point(442, 28);
            this.btnbrowseD.Name = "btnbrowseD";
            this.btnbrowseD.Size = new System.Drawing.Size(80, 30);
            this.btnbrowseD.TabIndex = 10;
            this.btnbrowseD.Text = "Browse";
            this.btnbrowseD.UseVisualStyleBackColor = true;
            this.btnbrowseD.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp|All files(*.*)|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Steganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Steganography";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnbrowseimage;
        private System.Windows.Forms.TextBox txtloadimage;
        private System.Windows.Forms.Label lblwritemessage;
        private System.Windows.Forms.Label lblloadimage;
        private System.Windows.Forms.Button btnbrowseD;
        private System.Windows.Forms.TextBox txtbrowseD;
        private System.Windows.Forms.Label lblloadimgD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblresolution;
        private System.Windows.Forms.Label lblwidth;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Button btnencrypt;
        private System.Windows.Forms.Button btndecrypt;
        private System.Windows.Forms.RichTextBox rtxtmessage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblencryptmessage;
        private System.Windows.Forms.RichTextBox rtxtencryptmessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInfoERes;
        private System.Windows.Forms.TextBox txtInfoEWidth;
        private System.Windows.Forms.TextBox txtinfoEHeight;
        private System.Windows.Forms.TextBox txtinfoESize;
        private System.Windows.Forms.TextBox txtInfoDRes;
        private System.Windows.Forms.TextBox txtInfoDWidth;
        private System.Windows.Forms.TextBox txtInfoDHeight;
        private System.Windows.Forms.TextBox txtInfoDSize;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lblstegofile;
        private System.Windows.Forms.Button button1;
    }
}