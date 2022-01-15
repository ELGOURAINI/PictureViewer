using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //show the open file dialogs ,if the user clicks ok load
            //the picture that the user choose
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear button
            pictureBox1.Image = null;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //Show the color diolog box .if te user clicks ok ,
            //change the pictureBox control's background to the color the user chose.
/*            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
*/            

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Close the form 
            this.Close();
        }
    }
}
