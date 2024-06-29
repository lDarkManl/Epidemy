using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    // Класс Sick, наследующий от Human, представляет состояние "Больной"
    internal class Sick : Human
    {
        private bool inHospital = true; // Флаг, указывающий, находится ли человек в больнице

        // Метод для отрисовки состояния клетки
        public override void printState(int posW, int posH, Graphics graphics)
        {
            if (inHospital)
            {
                // Если в больнице, рисуем клетку фиолетового цвета
                graphics.FillRectangle(Brushes.Purple, posW * 10, posH * 10, 10, 10);
            }
            else
            {
                // Если не в больнице, рисуем клетку красного цвета
                graphics.FillRectangle(Brushes.Red, posW * 10, posH * 10, 10, 10);
            }
            Pen pen = new Pen(Color.Black);
            // Рисуем черную рамку вокруг клетки
            graphics.DrawRectangle(pen, posW * 10, posH * 10, 10, 10);
        }

        // Метод для подсчета состояния клетки и обновления доступных мест
        public override (Human, States, int) countState(int availablePlaces)
        {
            if (diseaseDays == 0)
            {
                Random rnd = new Random();
                if (inHospital == true)
                    availablePlaces++;
                if (rnd.Next(0, 100) <= deathProbability)
                {
                    // Если человек умирает, возвращаем новое состояние Dead
                    return (new Dead(), States.Dead, availablePlaces);
                }
                // Если человек выздоравливает, возвращаем новое состояние Cured
                return (new Cured(), States.Cured, availablePlaces);
            }

            diseaseDays--; // Уменьшаем количество дней болезни
            // Возвращаем текущее состояние Sick
            return (new Sick(), States.Sick, availablePlaces);
        }

        // Метод для изменения вероятности смерти
        public void changeDeathProbability()
        {
            this.deathProbability = this.deathProbability > 50 ? 100 : this.deathProbability * 2;
            inHospital = false; // Человек больше не находится в больнице
        }
    }
}
