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
        private bool inHospital = true;
        public override void printState(int posW, int posH, Graphics graphics)
        {
            if (inHospital)
            {
                graphics.FillRectangle(Brushes.Purple, posW * 10, posH * 10, 10, 10);
            }
            else
            {
                graphics.FillRectangle(Brushes.Red, posW * 10, posH * 10, 10, 10);
            }
            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, posW * 10, posH * 10, 10, 10);
        }
        public override (Human, States, int) countState(int availablePlaces)
        {
            if (diseaseDays == 0)
            {
                Random rnd = new Random();
                if (inHospital == true)
                    availablePlaces++;
                if (rnd.Next(0, 100) <= deathProbability) 
                {
                    return (new Dead(), States.Dead, availablePlaces);
                }
                return (new Cured(), States.Cured, availablePlaces);
            }

            diseaseDays--;
            return (new Sick(), States.Sick, availablePlaces);
        }
        public void changeDeathProbability() 
        {
            this.deathProbability = this.deathProbability > 50 ? 100 : this.deathProbability * 2;
            inHospital = false;
    }
    }
}
