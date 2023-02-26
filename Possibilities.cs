using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructL7
{
    internal class Possibilities
    {
        private Diary[] diary;  // Основной массив для хранения данных

        private string path; // путь к файлу с данными

        private int index; // текущий элемент для добавления в workers

        private string[] titles; // массив, храняий заголовки полей. используется в PrintDbToConsole

        /// <summary>
        /// Констрктор
        /// </summary>
        /// <param name="Path">Путь в файлу с данными</param>
        public Possibilities(string Path)
        {
            this.path = Path; // Сохранение пути к файлу с данными
            this.index = 0; // текущая позиция для добавления сотрудника в workers
            this.titles = new string[0]; // инициализаия массива заголовков
            this.diary = new Diary[1]; // инициализаия массива сотрудников.    | изначально предпологаем, что данных нет

            this.Load(); // Загрузка данных
        }

        /// <summary>
        /// Метод загрузки данных
        /// </summary>
        private void Load()
        {
            using StreamReader sr = new(this.path);
            titles = sr.ReadLine().Split(',');

            while (!sr.EndOfStream)
            {
                string[] args = sr.ReadLine().Split(',');

                AddRecord(new Diary(Convert.ToInt32(args[0]), args[2], args[3], args[4], DateTime.Parse(args[1])));
            }
        }

        /// <summary>
        /// Метод увеличения текущего хранилища
        /// </summary>
        /// <param name="Flag">Условие увеличения</param>
        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.diary, this.diary.Length * 2);
            }
        }

        public void AddRecord(Diary ConcreteDiary)
        {
            this.Resize(index >= this.diary.Length);
            this.diary[index] = ConcreteDiary;
            this.index++;
        }

        private static void DeleteRecord(int id)
        { }

        public void EditRecord(int id)
        { }

        /// <summary>
        /// Метод сохранения данных
        /// </summary>
        /// <param name="Path">Путь к файлу сохранения</param>
        public void Save(string Path)
        {
            using StreamWriter stream = new(Path);
            foreach (Diary e in diary)
            {
                stream.WriteLine(diary.ToString());
            }
        }

        /// <summary>
        /// Вывод данных в консоль
        /// </summary>
        public void PrintDbToConsole()
        {
            Console.WriteLine($"{this.titles[0],5} {this.titles[1],15} {this.titles[2],15} {this.titles[3],15} {this.titles[4],10}");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(this.diary[i].Print());
            }
        }

        /// <summary>
        /// Количество сотрудников в хранилище
        /// </summary>
        public int Count
        { get { return this.index; } }
    }
}