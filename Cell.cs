using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    // Класс, представляющий клетку на поле
    internal class Cell
    {
        private Human humanState; // Состояние человека в клетке
        private States state; // Текущее состояние клетки
        private int posW; // Позиция клетки по ширине
        private int posH; // Позиция клетки по высоте
        private int incubationDays; // Количество дней инкубационного периода
        private int diseaseDays; // Количество дней болезни
        private int deathProbability; // Вероятность смерти
        private int immune; // Уровень иммунитета

        // Конструктор класса Cell
        public Cell(int posW, int posH, Graphics graphics, int incubationDays, int diseaseDays, int deathProbability, int isolationProbability, Random rnd)
        {
            // Определение состояния клетки при создании
            if (rnd.Next(0, 100) <= isolationProbability)
            {
                humanState = new Isolated(); // Установка состояния "Изолированный"
                state = States.Isolated; // Установка состояния клетки
            }
            else
            {
                humanState = new Healthy(); // Установка состояния "Здоровый"
                state = States.Healthy; // Установка состояния клетки
            }

            // Инициализация параметров клетки
            this.posW = posW;
            this.posH = posH;
            this.incubationDays = incubationDays;
            this.diseaseDays = diseaseDays;
            this.deathProbability = deathProbability;
            this.immune = rnd.Next(1, 75); // Случайное значение иммунитета
        }

        // Метод для получения значения иммунитета
        public int getImmune()
        {
            return immune;
        }

        // Метод для подсчета состояния клетки и обновления доступных мест
        public int countState(int availablePlaces)
        {
            (Human newHumanState, States newState, int places) = humanState.countState(availablePlaces); // Получение нового состояния
            if (newState != state)
                changeState(newHumanState, newState); // Изменение состояния клетки, если оно изменилось
            return places; // Возврат обновленного количества доступных мест
        }

        // Метод для изменения состояния клетки
        public void changeState(Human cellState, States newState)
        {
            humanState = cellState; // Установка нового состояния человека
            humanState.setInfo(incubationDays, diseaseDays, deathProbability); // Установка информации о состоянии
            state = newState; // Установка нового состояния клетки
        }

        // Метод для изменения состояния клетки и его отрисовки
        public void changeAndPrintState(Human cellState, States newState, Graphics graphics)
        {
            this.changeState(cellState, newState); // Изменение состояния клетки
            this.printCell(graphics); // Отрисовка клетки
        }

        // Метод для получения текущего состояния клетки
        public States getState()
        {
            return state;
        }

        // Метод для отрисовки клетки
        public void printCell(Graphics graphics)
        {
            humanState.printState(posW, posH, graphics); // Вызов метода отрисовки состояния человека
        }
    }
}
