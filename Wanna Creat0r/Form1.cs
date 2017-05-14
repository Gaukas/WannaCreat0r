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
    public partial class Form1 : Form
    {
        string picture2path = "";
        string picture1path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            picture2path = "";
            picture1path = "";
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture2path = openFileDialog1.FileName;
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                int byteLength = (int)fileStream.Length;
                byte[] fileBytes = new byte[byteLength];
                fileStream.Read(fileBytes, 0, byteLength);
                fileStream.Close();
                pictureBox2.Image = Image.FromStream(new MemoryStream(fileBytes));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the text\"" + linkLabel3.Text + "\"", "Input the text", linkLabel3.Text, -1, -1);
            }
            linkLabel3.Text = str;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the text\"" + linkLabel2.Text + "\"", "Input the text", linkLabel2.Text, -1, -1);
            }
            linkLabel2.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the text\"" + linkLabel1.Text + "\"", "Input the text", linkLabel1.Text, -1, -1);
            }
            linkLabel1.Text = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(picture1path,picture2path);
            //Set
            ((Form2)(form2)).label3.Text = this.label3.Text;
            //Finish
            this.Hide();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the \"" + button2.Text + "\"", "Input the content", button2.Text, -1, -1);
            }
            button2.Text = str;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto://gaukaswang@gmail.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("For text and picture: Just click on any elements you want to modify and then edit it. And for BG color: Doubleclick the background to set. I recommend you set a dark color as background color.  After all the settings are complete, just click \"Run\" button to run it!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string str ="";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the \"" + label1.Text + "\"", "Input the content", label1.Text, -1, -1);
            }
            label1.Text = str;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the \"" + comboBox1.Text + "\"", "Input the content", comboBox1.Text, -1, -1);
            }
            comboBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the \"" + button1.Text + "\"", "Input the content", button1.Text, -1, -1);
            }
            button1.Text = str;
        }


        private void label11_Click(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the \"" + label2.Text + "\"", "Input the content", label2.Text, -1, -1);
            }
            label2.Text = str;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture1path = openFileDialog1.FileName;
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                int byteLength = (int)fileStream.Length;
                byte[] fileBytes = new byte[byteLength];
                fileStream.Read(fileBytes, 0, byteLength);
                fileStream.Close();
                pictureBox1.Image = Image.FromStream(new MemoryStream(fileBytes));
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the \"" + button8.Text + "\"", "Input the content", button8.Text, -1, -1);
            }
            button8.Text = str;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the \"" + textBox1.Text + "\"", "Input the content", textBox1.Text, -1, -1);
            }
            textBox1.Text = str;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the \"" + label3.Text + "\"", "Input the content", label3.Text, -1, -1);
            }
            label3.Text = str;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the \"" + label7.Text + "\"", "Input the content", label7.Text, -1, -1);
            }
            label7.Text = str;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the \"" + label4.Text + "\"", "Input the content", label4.Text, -1, -1);
            }
            label4.Text = str;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string str = "";
            while (str == "")
            {
                str = Interaction.InputBox("Please input the content to replace the \"" + label8.Text + "\"", "Input the content", label8.Text, -1, -1);
            }
            label8.Text = str;
        }
    }
}
