using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class Incubation : Human
    {
        public override (Human, States, int) countState(int availablePlaces)
        {
            if (incubationDays == 0)
            {
                Sick sick = new Sick();
                if (availablePlaces == 0)
                {
                    sick.changeDeathProbability();
                }
                else
                {
                    availablePlaces--;
                }

                return (sick, States.Sick, availablePlaces);
            }
            incubationDays--;
            return (new Incubation(), States.Incubation, availablePlaces);
        }
        public override void printState(int posW, int posH, Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Gold, posW * 10, posH * 10, 10, 10);
            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, posW * 10, posH * 10, 10, 10);
        }
    }
}
