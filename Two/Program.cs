using System;
using System.Text;
using Two.Controllers;
using Two.Models;

namespace Two
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            FacultyController facultyController = new FacultyController();

            facultyController.AddFaculty(new DepartmentTeacher()
            {
                Name = "Снеговой Иван Иванович",
                Chair = "Математики",
                Position = "Преподаватель",
                Experience = "10 лет",
                Disciplines = "Мат анализ",
                NameFaculty = "Программирования и создания ИС",
                Room = "23",
                Corps = "1",
                Telephone = "89002552233",
                NameDean = "Ветров Петр Петрович",
            });
            facultyController.AddFaculty(new FacultyComposition()
            {
                Name = "Снеговой Иван Иванович",
                Position = "Преподаватель",
                NameFaculty = "Программирования и создания ИС",
                Room = "23",
                Corps = "5",
                Telephone = "89002552233",
                NameDean = "Ветров Петр Петрович",
            });
            facultyController.AddFaculty(new Faculty()
            {
                NameFaculty = "Программирования и создания ИС",
                Room = "23",
                Corps = "3",
                Telephone = "89002552233",
                NameDean = "Ветров Петр Петрович",
            });
            facultyController.AddFaculty(new Chair()
            {
                Name = "Снеговой Иван Иванович",
                TrainingDirection = "Математика",
                NameFaculty = "Программирования и создания ИС",
                Room = "23",
                Corps = "2",
                Telephone = "89002552233",
                NameDean = "Ветров Петр Петрович",
            });

            facultyController.PrintFaculties();
        }
    }
}
