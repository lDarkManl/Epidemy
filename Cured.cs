using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class Cured : Human
    {
        public override void printState(int posW, int posH, Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Gray, posW * 10, posH * 10, 10, 10);
            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, posW * 10, posH * 10, 10, 10);
        }
        public override (Human, States, int) countState(int availablePlaces)
        {
            return (new Cured(), States.Cured, availablePlaces);
        }
    }
}
