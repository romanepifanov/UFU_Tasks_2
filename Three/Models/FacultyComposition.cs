namespace Three.Models
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
                    Факультет: {this.NameFaculty}
                    Аудитория: {this.Room}
                    Корпус: {this.Corps}
                    Контактный телефон: {this.Telephone}
                    Фамилия декана: {this.NameDean}
                    ";
        }
    }
}