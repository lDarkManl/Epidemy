using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int amountW;
        private int amountH;
        private int[,] cells;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            amountW = (int)numAmountW.Value;
            amountH = (int)numAmountH.Value;
            cells = new int[amountW, amountH];
            graphics = Graphics.FromImage(pictureBox1.Image);
            for (int i = 0; i < amountW; i++)
            {
                for (int j = 0; j < amountH; j++) 
                {
                    graphics.FillRectangle(Brushes.White, i * 10, j * 10, 10, 10);
                    Pen pen = new Pen(Color.Black);
                    graphics.DrawRectangle(pen, i * 10, j * 10, 10, 10);
                }
            }
            

        }
    }
}
