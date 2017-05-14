using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace Wanna_Creat0r
{
    public partial class Form2 : Form
    {
        public Form2(string p1p,string p2p)
        {
            InitializeComponent();
            if (p1p != "")
            {
                FileStream fileStream = new FileStream(p1p, FileMode.Open, FileAccess.Read);
                int byteLength = (int)fileStream.Length;
                byte[] fileBytes = new byte[byteLength];
                fileStream.Read(fileBytes, 0, byteLength);
                fileStream.Close();
                pictureBox1.Image = Image.FromStream(new MemoryStream(fileBytes));
            }
            if (p2p!="")
            {
                FileStream fileStream = new FileStream(p2p, FileMode.Open, FileAccess.Read);
                int byteLength = (int)fileStream.Length;
                byte[] fileBytes = new byte[byteLength];
                fileStream.Read(fileBytes, 0, byteLength);
                fileStream.Close();
                pictureBox2.Image = Image.FromStream(new MemoryStream(fileBytes));
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
