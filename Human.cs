using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal abstract class Human
    {
        protected int incubationDays;
        protected int diseaseDays;
        protected int deathProbability;
        public void setInfo(int incubationDays, int diseaseDays, int deathProbability)
        {
            this.incubationDays = incubationDays;
            this.diseaseDays = diseaseDays;
            this.deathProbability = deathProbability;
        }
        public abstract (Human, States, int) countState(int availablePlaces);
        public abstract void printState(int posW,  int posH, Graphics graphics);
    }
}
