﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class Incubation : Human
    {

        public override (Human, States) countState()
        {
            if (incubationDays == 0)
                return (new Sick(), States.Sick);
            incubationDays--;
            return (new Incubation(), States.Incubation);
        }
        public override void printState(int posW, int posH, Graphics graphics)
        {
            graphics.FillRectangle(Brushes.MediumBlue, posW * 10, posH * 10, 10, 10);
            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, posW * 10, posH * 10, 10, 10);
        }
    }
}
