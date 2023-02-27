using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructL7
{
    internal class Diary
    {
        /// <summary>
        /// Номер записи
        /// </summary>
        private int id;

        /// <summary>
        /// Время записи
        /// </summary>
        private DateTime currentDateTime;

        /// <summary>
        /// Заметка/Список дел/План
        /// </summary>
        private string toDoList;

        /// <summary>
        /// Имя авотра записи
        /// </summary>
        private string authorsName;

        /// <summary>
        /// Главный пункт для выолнения
        /// </summary>
        private string mainTask;

        public int Id
        { get { return this.id; } set { this.id = value; } }

        public string ToDoList
        { get { return this.toDoList; } set { this.toDoList = value; } }

        public string AuthorsName
        { get { return this.authorsName; } set { this.authorsName = value; } }

        public string MainTask
        { get { return this.mainTask; } set { this.mainTask = value; } }

        public DateTime CurrentDateTime
        { get { return this.currentDateTime; } set { this.currentDateTime = value; } }

        /// <summary>
        /// Конструктор создания записи в ежедневник
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="CurrentDateTime"></param>
        /// <param name="ToDoList"></param>
        /// <param name="MainTask"></param>
        /// <param name="AuthorsName"></param>
        public Diary(int Id, string ToDoList, string MainTask, string AuthorsName, DateTime CurrentDateTime)
        {
            this.id = Id;
            this.toDoList = ToDoList;
            this.authorsName = AuthorsName;
            this.mainTask = MainTask;
            this.currentDateTime = CurrentDateTime;
        }

        /// <summary>
        /// Вывод на экран
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{this.id,10}  {this.toDoList,10} {this.mainTask,10}  {this.authorsName,10} {this.currentDateTime,10}";
        }
    }
}