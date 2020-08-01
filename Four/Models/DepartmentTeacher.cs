namespace Four.Models
{
    class DepartmentTeacher : Faculty
    {
        public string Name { get; set; }
        public string Chair { get; set; }
        public string Position { get; set; }
        public string Experience { get; set; }
        public string Disciplines { get; set; }

        public override string ToString()
        {
            return @$"
                    ФИО: {this.Name}
                    Кафедра: {this.Chair}
                    Должность: {this.Position}
                    Стаж работы: {this.Experience}
                    Читаемые дисциплины: {this.Disciplines}
                    Факультет: {this.NameFaculty}
                    Аудитория: {this.Room}
                    Корпус: {this.Corps}
                    Контактный телефон: {this.Telephone}
                    Фамилия декана: {this.NameDean}
                    ";
        }
    }
}
