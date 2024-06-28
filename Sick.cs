using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class Sick : Human
    {
        public override void printState(int posW, int posH, Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Red, posW * 10, posH * 10, 10, 10);
            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, posW * 10, posH * 10, 10, 10);
        }
        public override (Human, States) countState()
        {
            if (diseaseDays == 0)
            {
                Random rnd = new Random();
                if (rnd.Next(0, 100) <= deathProbability) 
                {
                    return (new Dead(), States.Dead);
                }
                return (new Cured(), States.Cured);
            }

            diseaseDays--;
            return (new Sick(), States.Sick);
        }
    }
}
