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
        string message, password = "pass";
        float width, height;
        float widthD, heightD;

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
            

            string stegofile = txt.Text;
            string message = rtxtmessage.Text;
            string newmessage = "";

            IStegoFile stego = new BMPStegoFile(loadedimagepath, password);
            string encodedmessage = stego.HiddenMessage;


            if (loadedimagepath == "")
            {
                MessageBox.Show("Select the file to encode");
                return;
            }

            else if(encodedmessage == "")
            {
                ICoverFile cover = new BMPCoverFile(loadedimagepath);
                cover.CreateStegoFile(stegofile, message, password);

                MessageBox.Show("Message hidden successfully"); 
            }
            else

            newmessage = encodedmessage + Environment.NewLine + message;

            ICoverFile cover1 = new BMPCoverFile(loadedimagepath);
            cover1.CreateStegoFile(stegofile, newmessage, password);

            MessageBox.Show("Message hidden successfully"); 

        }

        private void btndecrypt_Click(object sender, EventArgs e)
        {

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
            ofd.CheckFileExists = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt.Text = ofd.FileName;
            }
        }


    }
}
