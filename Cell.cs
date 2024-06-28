using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class Cell
    {
        private Human humanState;
        private States state;
        private int posW;
        private int posH;
        private int incubationDays;
        private int diseaseDays;
        private int deathProbability;
        private int immune;
        public Cell(int posW, int posH, Graphics graphics, int incubationDays, int diseaseDays, int deathProbability, int isolationProbability, Random rnd)
        {
            if (rnd.Next(0, 100) <= isolationProbability)
            {
                humanState = new Isolated();
                state = States.Isolated;
            }
            else
            {
                humanState = new Healthy();
                state = States.Healthy;
            }
            
            
            this.posW = posW;
            this.posH = posH;
            this.incubationDays = incubationDays;
            this.diseaseDays = diseaseDays;
            this.deathProbability = deathProbability;
            this.immune = rnd.Next(1, 75);

        }

        public int getImmune()
        {
            return immune;
        }

        public int countState(int availablePlaces)
        {
            (Human newHumanState, States newState, int places) = humanState.countState(availablePlaces);
            if (newState != state)
                changeState(newHumanState, newState);
            return places;


        }
        public void changeState(Human cellState, States newState)
        {
            humanState = cellState;
            humanState.setInfo(incubationDays, diseaseDays, deathProbability);
            state = newState;
        }

        public void changeAndPrintState(Human cellState, States newState, Graphics graphics)
        {
            this.changeState(cellState, newState);
            this.printCell(graphics);
        }

        public States getState()
        {
            return state;
        }
        public void printCell(Graphics graphics)
        {
            humanState.printState(posW, posH, graphics);
        }
    }
}
