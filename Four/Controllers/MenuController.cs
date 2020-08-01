using Four.Models;
using System;
using System.Text;

namespace Four.Controllers
{
    public class MenuController
    {
        private string command = String.Empty;
        private FacultyController facultyController = new FacultyController();

        public MenuController() { }

        public void Init()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Clear();
            this.ShowMenu();
        }

        #region MENU METHODS
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Главное Меню");
            Console.WriteLine("->> Добавить факультет");
            Console.WriteLine("->> Добавить кафедру");
            Console.WriteLine("->> Добавить состав факультета");
            Console.WriteLine("->> Добавить преподавателя кафедры");

            Console.WriteLine("->> Распечатать список факультетов");
            Console.WriteLine("->> Отсортировать по корпусам А-Я");
            Console.WriteLine("->> Отсортировать по корпусам Я-А");
            Console.WriteLine("->> Отсортировать по наименованию факультетов А-Я");
            Console.WriteLine("->> Отсортировать по наименованию факультетов Я-А");
            Console.ForegroundColor = ConsoleColor.White;
            CheckCommand();
        }
        private void PrintFaculties()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            facultyController.PrintFaculties();
            this.ShowMenu();
        }
        private void PrintCorpsOrderByAscending()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            facultyController.CorpsOrderByAscending();
            this.ShowMenu();
        }
        private void PrintCorpsOrderByDescending()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            facultyController.CorpsOrderByDescending();
            this.ShowMenu();
        }
        private void PrintNameFacultyOrderByAscending()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            facultyController.NameFacultyOrderByAscending();
            this.ShowMenu();
        }
        private void PrintNameFacultyOrderByDescending()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            facultyController.NameFacultyOrderByDescending();
            this.ShowMenu();
        }

        private void AddFaculty()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Введите данные через запятую пример: Факультет, Аудитория, Корпус, Контактный телефон, Фамилия декана");
            Console.ForegroundColor = ConsoleColor.White;
            this.command = this.ReadLineUTF();
            Console.ForegroundColor = ConsoleColor.Blue;

            try
            {
                string[] items = this.command.Split(",");
                Faculty faculty = new Faculty()
                {
                    NameFaculty = items[0],
                    Room = items[1],
                    Corps = items[2],
                    Telephone = items[3],
                    NameDean = items[4],
                };

                facultyController.AddFaculty(faculty);
                Console.WriteLine("Факультет добавлен успешно");
            }
            catch
            {
                Console.WriteLine("У вас ошибка, повторите попытку");
            }

            Console.ForegroundColor = ConsoleColor.White;
            this.ShowMenu();
        }
        private void AddChair()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Введите данные через запятую пример: Название, Направление подготовки, Факультет, Аудитория, Корпус, Контактный телефон, Фамилия декана");
            Console.ForegroundColor = ConsoleColor.White;
            this.command = this.ReadLineUTF();
            Console.ForegroundColor = ConsoleColor.Blue;

            try
            {
                string[] items = this.command.Split(",");
                Chair faculty = new Chair()
                {
                    Name = items[0],
                    TrainingDirection = items[1],
                    NameFaculty = items[2],
                    Room = items[3],
                    Corps = items[4],
                    Telephone = items[5],
                    NameDean = items[6],
                };

                facultyController.AddFaculty(faculty);
                Console.WriteLine("Кафедра добавлена успешно");
            }
            catch
            {
                Console.WriteLine("У вас ошибка, повторите попытку");
            }

            Console.ForegroundColor = ConsoleColor.White;
            this.ShowMenu();
        }
        private void AddFacultyComposition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Введите данные через запятую пример: ФИО, Должность, Факультет, Аудитория, Корпус, Контактный телефон, Фамилия декана");
            Console.ForegroundColor = ConsoleColor.White;
            this.command = this.ReadLineUTF();
            Console.ForegroundColor = ConsoleColor.Blue;

            try
            {
                string[] items = this.command.Split(",");
                FacultyComposition faculty = new FacultyComposition()
                {
                    Name = items[0],
                    Position = items[1],
                    NameFaculty = items[2],
                    Room = items[3],
                    Corps = items[4],
                    Telephone = items[5],
                    NameDean = items[6],
                };

                facultyController.AddFaculty(faculty);
                Console.WriteLine("Запись о составе факультета добавлен успешно");
            }
            catch
            {
                Console.WriteLine("У вас ошибка, повторите попытку");
            }

            Console.ForegroundColor = ConsoleColor.White;
            this.ShowMenu();
        }
        private void AddDepartmentTeacher()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Введите данные через запятую пример: ФИО, Кафедра, Должность, Стаж работы, Читаемые дисциплины, Факультет, Аудитория, Корпус, Контактный телефон, Фамилия декана");
            Console.ForegroundColor = ConsoleColor.White;
            this.command = this.ReadLineUTF();
            Console.ForegroundColor = ConsoleColor.Blue;

            try
            {
                string[] items = this.command.Split(",");
                DepartmentTeacher faculty = new DepartmentTeacher()
                {
                    Name = items[0],
                    Chair = items[1],
                    Position = items[2],
                    Experience = items[3],
                    Disciplines = items[4],
                    NameFaculty = items[5],
                    Room = items[6],
                    Corps = items[7],
                    Telephone = items[8],
                    NameDean = items[9],
                };

                facultyController.AddFaculty(faculty);
                Console.WriteLine("Запись о преподавателе кафедры добавлена успешно");
            }
            catch
            {
                Console.WriteLine("У вас ошибка, повторите попытку");
            }

            Console.ForegroundColor = ConsoleColor.White;
            this.ShowMenu();
        }
        #endregion COMMON METHODS
        #region COMMON METHODS
        public void CheckCommand()
        {
            this.command = this.ReadLineUTF();

            switch (this.command)
            {
                case "Добавить факультет": this.AddFaculty(); break;
                case "Добавить кафедру": this.AddChair(); break;
                case "Добавить состав факультета": this.AddFacultyComposition(); break;
                case "Добавить преподавателя кафедры": this.AddDepartmentTeacher(); break;

                case "Распечатать список факультетов": this.PrintFaculties(); break;
                case "Отсортировать по корпусам А-Я": this.PrintCorpsOrderByAscending(); break;
                case "Отсортировать по корпусам Я-А": this.PrintCorpsOrderByDescending(); break;
                case "Отсортировать по наименованию факультетов А-Я": this.PrintNameFacultyOrderByAscending(); break;
                case "Отсортировать по наименованию факультетов Я-А": this.PrintNameFacultyOrderByDescending(); break;
                default: Console.WriteLine("Не верная команда"); break;
            }

            this.ShowMenu();
        }
        private string ReadLineUTF()
        {
            ConsoleKeyInfo currentKey;

            var sBuilder = new StringBuilder();
            do
            {
                currentKey = Console.ReadKey();
                // avoid capturing newline
                if (currentKey.Key != ConsoleKey.Enter)
                    sBuilder.Append(currentKey.KeyChar);

            }
            // check if Enter was pressed
            while (currentKey.Key != ConsoleKey.Enter);

            // move on the next line
            Console.WriteLine();

            return sBuilder.ToString();
        }
        #endregion COMMON METHODS
    }
}

