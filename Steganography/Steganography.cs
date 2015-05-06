using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Steganography : Form
    {

        string loadedimagepath, loadedimagepathD;
        string message, password;
        float size, width, height, resolution;
        float sizeD, widthD, heightD, resolutionD;

        public Steganography()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadedimagepath = openFileDialog1.FileName;
                txtloadimage.Text = loadedimagepath;
            }

            Image picture = new Bitmap(loadedimagepath);
           
            pictureBox1.Image = new Bitmap(picture);


            Image img = Image.FromFile(loadedimagepath);

            height = img.Height;
            width = img.Width;
            

            txtinfoEHeight.Text = height.ToString();
            txtInfoEWidth.Text = width.ToString();
            txtInfoERes.Text = width.ToString() + " x " + height.ToString();
            //txtinfoESize.Text = size;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadedimagepathD = openFileDialog1.FileName;
                txtbrowseD.Text = loadedimagepathD;
            }


            Image picture1 = new Bitmap(loadedimagepathD);

            pictureBox2.Image = new Bitmap(picture1);


            Image img = Image.FromFile(loadedimagepathD);

            heightD = img.Height;
            widthD = img.Width;


            txtInfoDHeight.Text = heightD.ToString();
            txtInfoDWidth.Text = widthD.ToString();
            txtInfoDRes.Text = widthD.ToString() + " x " + heightD.ToString();
            //txtinfoESize.Text = size;

        }
        private void rtxtmessage_TextChanged(object sender, EventArgs e)
        {
            message = rtxtmessage.Text;
        }

        private void btnencrypt_Click(object sender, EventArgs e)
        {
            password = txtpassword.Text;

            ICoverFile cover = new BMPCoverFile(loadedimagepath);

            string stegofile = txt.Text;

            cover.CreateStegoFile(stegofile, message, password);

            MessageBox.Show("Message hidden successfully");

        }

        private void btndecrypt_Click(object sender, EventArgs e)
        {

            password = txtDpass.Text;

            if (loadedimagepathD == "")
            {
                MessageBox.Show("Select the stego file to decode");
                return;
            }
                IStegoFile stego = new BMPStegoFile(loadedimagepathD, password);

                rtxtencryptmessage.Text = stego.HiddenMessage;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Windows Bitmap (*.bmp)|*.bmp";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt.Text = ofd.FileName;
            }
        }

    }
}
