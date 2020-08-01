using System;
using System.Text;
using Three.Controllers;
using Three.Models;

namespace Three
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
                NameFaculty = "Программирование",
                Room = "23",
                Corps = "1",
                Telephone = "89002552233",
                NameDean = "Ветров Петр Петрович",
            });
            facultyController.AddFaculty(new FacultyComposition()
            {
                Name = "Снеговой Иван Иванович",
                Position = "Преподаватель",
                NameFaculty = "Программирование",
                Room = "23",
                Corps = "5",
                Telephone = "89002552233",
                NameDean = "Ветров Петр Петрович",
            });
            facultyController.AddFaculty(new Faculty()
            {
                NameFaculty = "Создания ИС",
                Room = "23",
                Corps = "3",
                Telephone = "89002552233",
                NameDean = "Ветров Петр Петрович",
            });
            facultyController.AddFaculty(new Chair()
            {
                Name = "Снеговой Иван Иванович",
                TrainingDirection = "Математика",
                NameFaculty = "Создания ИС",
                Room = "23",
                Corps = "2",
                Telephone = "89002552233",
                NameDean = "Ветров Петр Петрович",
            });

            facultyController.PrintFaculties();
            Console.WriteLine("-/-/-/-/-/-/-/-/-/-/-/-/");
            facultyController.CorpsOrderByAscending();
            facultyController.PrintFaculties();
            Console.WriteLine("-/-/-/-/-/-/-/-/-/-/-/-/");
            facultyController.CorpsOrderByDescending();
            facultyController.PrintFaculties();
            Console.WriteLine("-/-/-/-/-/-/-/-/-/-/-/-/");
            facultyController.NameFacultyOrderByAscending();
            facultyController.PrintFaculties();
            Console.WriteLine("-/-/-/-/-/-/-/-/-/-/-/-/");
            facultyController.NameFacultyOrderByDescending();
            facultyController.PrintFaculties();
        }
    }
}
