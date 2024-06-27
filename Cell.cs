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

        public Cell(int posW, int posH, Graphics graphics)
        {
            humanState = new Healthy();
            state = States.Healthy;
            this.posW = posW;
            this.posH = posH;
        }

        public void countState()
        {
            (Human newHumanState, States newState) = humanState.countState();
            if (newState != state)
                changeState(newHumanState, newState);

        }
        public void changeState(Human cellState, States newState)
        {
            humanState = cellState;
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
