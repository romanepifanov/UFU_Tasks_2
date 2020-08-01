namespace Two.Models
{
    class FacultyComposition : Faculty
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return @$"
                    ФИО: {this.Name}
                    Должность: {this.Position}
                    Аудитория: {this.Room}
                    Факультет: {this.NameFaculty}
                    Корпус: {this.Corps}
                    Контактный телефон: {this.Telephone}
                    Фамилия декана: {this.NameDean}
                    ";
        }
    }
}
