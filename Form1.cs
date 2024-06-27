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
    enum States { Healthy, Sick, Cured, Incubation };
    public partial class Form1 : Form
    {
        
        private Graphics graphics;
        private int amountW;
        private int amountH;
        private Cell[,] cells;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            amountW = (int)numAmountW.Value;
            amountH = (int)numAmountH.Value;
            int midW = amountW / 2;
            int midH = amountH / 2;
            cells = new Cell[amountW, amountH];
            graphics = Graphics.FromImage(pictureBox1.Image);
            for (int i = 0; i < amountW; i++)
            {
                for (int j = 0; j < amountH; j++)
                {
                    cells[i, j] = new Cell(i, j, graphics);
                    if (i == midW && j == midH)
                        cells[i, j].changeState(new Incubation((int)incubationDays.Value, (int)daysForCuring.Value), States.Incubation);
                    cells[i, j].countState();
                    cells[i, j].printCell(graphics);

                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            List<(int x, int y)> sickCells = new List<(int x, int y)>();

            // First pass: identify all sick cells
            for (int i = 0; i < amountW; i++)
            {
                for (int j = 0; j < amountH; j++)
                {
                    if (cells[i, j].getState() == States.Incubation)
                    {
                        sickCells.Add((i, j));
                    }
                }
            }
            double num;
            int rad = (int)radius.Value;
            int contactsPerDay = (int)contacts.Value;
            // Second pass: change all surrounding healthy cells to sick
            foreach (var (x, y) in sickCells)
            {
                for (int i = x - rad; i <= x + rad; i++)
                {
                    for (int j = y - rad; j <= y + rad; j++)
                    {
                        num = rnd.NextDouble();
                        if (i >= 0 && i < amountW && j >= 0 && j < amountH)
                        {
                            if (cells[i, j].getState() == States.Healthy && num < (double)variety.Value)
                            {
                                cells[i, j].changeAndPrintState(new Incubation((int)incubationDays.Value, (int)daysForCuring.Value), States.Incubation, graphics);
                            }
                        }
                    }
                }
            }
            
            // Print all cells again to update the image
            for (int i = 0; i < amountW; i++)
            {
                for (int j = 0; j < amountH; j++)
                {
                    cells[i, j].countState();
                    cells[i, j].printCell(graphics);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
    }
}
