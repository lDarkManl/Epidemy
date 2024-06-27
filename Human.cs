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
        public abstract (Human, States) countState();
        public abstract void printState(int posW,  int posH, Graphics graphics);
    }
}
