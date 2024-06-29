using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    // Класс Incubation, наследующий от Human, представляет состояние "Инкубационный период"
    internal class Incubation : Human
    {
        // Метод для подсчета состояния клетки и обновления доступных мест
        public override (Human, States, int) countState(int availablePlaces)
        {
            if (incubationDays == 0)
            {
                Sick sick = new Sick(); // Создаем новый объект Sick (больной)
                if (availablePlaces == 0)
                {
                    sick.changeDeathProbability(); // Если нет доступных мест, увеличиваем вероятность смерти
                }
                else
                {
                    availablePlaces--; // Уменьшаем количество доступных мест
                }

                return (sick, States.Sick, availablePlaces); // Возвращаем новое состояние Sick
            }
            incubationDays--; // Уменьшаем количество дней инкубационного периода
            return (new Incubation(), States.Incubation, availablePlaces); // Возвращаем текущее состояние Incubation
        }

        // Метод для отрисовки состояния клетки
        public override void printState(int posW, int posH, Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Gold, posW * 10, posH * 10, 10, 10); // Рисуем клетку золотого цвета
            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, posW * 10, posH * 10, 10, 10); // Рисуем черную рамку вокруг клетки
        }
    }
}
