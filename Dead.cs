using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class Dead : Human
    {
        public override void printState(int posW, int posH, Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Black, posW * 10, posH * 10, 10, 10);
            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, posW * 10, posH * 10, 10, 10);
        }

        public override (Human, States) countState()
        {
            return (new Dead(), States.Dead);
        }
    }
}
