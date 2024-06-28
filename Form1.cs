using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    enum States { Healthy, Sick, Cured, Incubation, Dead, Isolated };
    public partial class Form1 : Form
    {
        
        private Graphics graphics;
        private int amountW;
        private int amountH;
        private Cell[,] cells;
        private int availablePlaces;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextBtn.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            amountW = (int)numAmountW.Value;
            amountH = (int)numAmountH.Value;
            int midW = amountW / 2;
            int midH = amountH / 2;
            availablePlaces = (int)places.Value;
            cells = new Cell[amountW, amountH];
            graphics = Graphics.FromImage(pictureBox1.Image);
            Random rnd = new Random();
            for (int i = 0; i < amountW; i++)
            {
                for (int j = 0; j < amountH; j++)
                {
                    cells[i, j] = new Cell(i, j, graphics, (int)incubationDays.Value, (int)daysForCuring.Value, (int)dead.Value, (int)isolationProbability.Value, rnd);
                    if (i == midW && j == midH)
                        cells[i, j].changeState(new Incubation(), States.Incubation);
                    availablePlaces = cells[i, j].countState(availablePlaces);
                    availablePlaces = availablePlaces > (int)places.Value ? (int)places.Value : availablePlaces;
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
                    if (cells[i, j].getState() == States.Incubation || cells[i, j].getState() == States.Sick)
                    {
                        sickCells.Add((i, j));
                    }
                }
            }
            double num;
            int rad = (int)radius.Value;
            int contactsPerDay = (int)contacts.Value;
            int countContacts = 0;
            // Second pass: change all surrounding healthy cells to sick
            foreach (var (x, y) in sickCells)
            {
                // Collect all coordinate pairs within the radius
                List<(int i, int j)> coordinates = new List<(int i, int j)>();
                for (int i = x - rad; i <= x + rad; i++)
                {
                    for (int j = y - rad; j <= y + rad; j++)
                    {
                        if (i >= 0 && i < amountW && j >= 0 && j < amountH)
                        {
                            coordinates.Add((i, j));
                        }
                    }
                }


                // Iterate over the shuffled coordinates
                foreach (var (i, j) in coordinates.OrderBy(_ => rnd.Next()))
                {
                    num = rnd.Next(0, 100);
                    if ((cells[i, j].getState() == States.Healthy && num <= (int)variety.Value) || (cells[i, j].getState() == States.Isolated && num <= (int)variety.Value / 2))
                    {
                        if (cells[i, j].getImmune() < (int)variety.Value)
                        {
                            cells[i, j].changeAndPrintState(new Incubation(), States.Incubation, graphics);
                            countContacts++;
                            if (countContacts == contactsPerDay)
                                goto endLoops;
                        }
                        
                    }
                    
                }
            }
        endLoops:
            // Print all cells again to update the image
            for (int i = 0; i < amountW; i++)
            {
                for (int j = 0; j < amountH; j++)
                {
                    availablePlaces = cells[i, j].countState(availablePlaces);
                    availablePlaces = availablePlaces > (int)places.Value ? (int)places.Value : availablePlaces;
                    cells[i, j].printCell(graphics);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nextBtn.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
    }
}
