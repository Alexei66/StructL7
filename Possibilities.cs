using Example_751;
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

        public Possibilities(string Path)
        {
            this.path = Path; // Сохранение пути к файлу с данными
            this.index = 0; // текущая позиция для добавления сотрудника в workers
            this.titles = new string[0]; // инициализаия массива заголовков
            this.diary = new Diary[1]; // инициализаия массива сотрудников.    | изначально предпологаем, что данных нет

            this.Load(); // Загрузка данных
        }

        private void Load()
        {
            using (StreamReader sr = new StreamReader(this.path))
            {
                titles = sr.ReadLine().Split(',');

                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split(',');

                    AddRecord(new Diary(Convert.ToInt32(args[0]), DateTime.Parse(args[1]), args[2], args[3], args[4]));
                }
            }
        }

        public void AddRecord()
        { }

        private static void DeleteRecord()
        { }

        public void EditRecord()
        { }

        private static void Save()
        { }

        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.diary, this.diary.Length * 2);
            }
        }
    }
}