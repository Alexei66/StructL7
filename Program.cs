using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructL7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /// Разработать ежедневник.
            /// В ежедневнике реализовать возможность
            /// - создания
            /// - удаления
            /// - реактирования
            /// записей
            ///
            /// В отдельной записи должно быть не менее пяти полей
            ///
            /// Реализовать возможность
            /// - Загрузки даннах из файла
            /// - Выгрузки даннах в файл
            /// - Добавления данных в текущий ежедневник из выбранного файла
            /// - Импорт записей по выбранному диапазону дат
            /// - Упорядочивания записей ежедневника по выбранному полю

            string path = @"diary.txt";

            Possibilities rep = new Possibilities(path);

            Console.WriteLine("Введи 1 для просмотра записей, 2 - создание записи, 3 -  удаления, 4 - редактирования");
            string key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    rep.PrintDbToConsole();
                    break;

                case "2":

                    Console.WriteLine("Id, ToDoList, MainTask, AuthorsName, CurrentDateTime)");
                    int id = Convert.ToInt32(Console.ReadLine());
                    string toDo = Console.ReadLine();
                    string task = Console.ReadLine();
                    string name = Console.ReadLine();
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    rep.AddRecord(new Diary(id, toDo, task, name, date));
                    rep.Save(path);
                    break;

                case "3":

                    break;

                case "4":

                    break;

                default:
                    break;
            }
        }
    }
}