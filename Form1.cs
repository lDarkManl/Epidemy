using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    // Определение перечисления для состояний клеток
    enum States { Healthy, Sick, Cured, Incubation, Dead, Isolated };

    public partial class Form1 : Form
    {
        private Graphics graphics; // Графический объект для рисования
        private int amountW; // Количество клеток по ширине
        private int amountH; // Количество клеток по высоте
        private Cell[,] cells; // Массив клеток
        private int availablePlaces; // Доступные места

        public Form1()
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Активация и деактивация кнопок
            nextBtn.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;

            // Создание нового изображения для pictureBox
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Установка количества клеток по ширине и высоте
            amountW = (int)numAmountW.Value;
            amountH = (int)numAmountH.Value;

            // Определение середины поля
            int midW = amountW / 2;
            int midH = amountH / 2;

            // Инициализация доступных мест
            availablePlaces = (int)places.Value;

            // Создание массива клеток
            cells = new Cell[amountW, amountH];

            // Получение графического объекта из изображения
            graphics = Graphics.FromImage(pictureBox1.Image);

            // Создание генератора случайных чисел
            Random rnd = new Random();

            // Инициализация клеток
            for (int i = 0; i < amountW; i++)
            {
                for (int j = 0; j < amountH; j++)
                {
                    cells[i, j] = new Cell(i, j, graphics, (int)incubationDays.Value, (int)daysForCuring.Value, (int)dead.Value, (int)isolationProbability.Value, rnd);

                    // Установка состояния "Инкубация" для средней клетки
                    if (i == midW && j == midH)
                        cells[i, j].changeState(new Incubation(), States.Incubation);

                    // Обновление доступных мест
                    availablePlaces = cells[i, j].countState(availablePlaces);
                    availablePlaces = availablePlaces > (int)places.Value ? (int)places.Value : availablePlaces;

                    // Отрисовка клетки
                    cells[i, j].printCell(graphics);
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            // Создание генератора случайных чисел
            Random rnd = new Random();

            // Создание нового изображения для pictureBox
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Получение графического объекта из изображения
            graphics = Graphics.FromImage(pictureBox1.Image);

            // Создание списка для хранения координат больных клеток
            List<(int x, int y)> sickCells = new List<(int x, int y)>();

            // Первый проход: идентификация всех больных клеток
            for (int i = 0; i < amountW; i++)
            {
                for (int j = 0; j < amountH; j++)
                {
                    if (cells[i, j].getState() == States.Incubation || cells[i, j].getState() == States.Sick)
                    {
                        sickCells.Add((i, j));
                    }
                }
            }

            double num; // Переменная для случайного числа
            int rad = (int)radius.Value; // Радиус воздействия
            int contactsPerDay = (int)contacts.Value; // Количество контактов в день
            int countContacts = 0; // Счетчик контактов

            // Второй проход: изменение состояния здоровых клеток вокруг больных
            foreach (var (x, y) in sickCells)
            {
                // Сбор всех координат в пределах радиуса
                List<(int i, int j)> coordinates = new List<(int i, int j)>();
                for (int i = x - rad; i <= x + rad; i++)
                {
                    for (int j = y - rad; j <= y + rad; j++)
                    {
                        if (i >= 0 && i < amountW && j >= 0 && j < amountH)
                        {
                            coordinates.Add((i, j));
                        }
                    }
                }

                // Итерация по случайным координатам
                foreach (var (i, j) in coordinates.OrderBy(_ => rnd.Next()))
                {
                    num = rnd.Next(0, 100); // Случайное число
                    if ((cells[i, j].getState() == States.Healthy && num <= (int)variety.Value) || (cells[i, j].getState() == States.Isolated && num <= (int)variety.Value / 2))
                    {
                        if (cells[i, j].getImmune() < (int)variety.Value)
                        {
                            cells[i, j].changeAndPrintState(new Incubation(), States.Incubation, graphics); // Изменение состояния клетки на "Инкубация"
                            countContacts++;
                            if (countContacts == contactsPerDay)
                                goto endLoops; // Прерывание цикла, если достигнуто максимальное количество контактов
                        }
                    }
                }
            }

        endLoops:
            // Отрисовка всех клеток для обновления изображения
            for (int i = 0; i < amountW; i++)
            {
                for (int j = 0; j < amountH; j++)
                {
                    availablePlaces = cells[i, j].countState(availablePlaces);
                    availablePlaces = availablePlaces > (int)places.Value ? (int)places.Value : availablePlaces;
                    cells[i, j].printCell(graphics);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Сброс интерфейса и деактивация кнопок
            nextBtn.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;

            // Создание нового изображения для pictureBox
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
    }
}
