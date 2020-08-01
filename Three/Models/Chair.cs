namespace Three.Models
{
    class Chair : Faculty
    {
        public string Name { get; set; }
        public string TrainingDirection { get; set; }

        public override string ToString()
        {
            return @$"
                    ФИО: {this.Name}
                    Направление подготовки: {this.TrainingDirection}
                    Факультет: {this.NameFaculty}
                    Аудитория: {this.Room}
                    Корпус: {this.Corps}
                    Контактный телефон: {this.Telephone}
                    Фамилия декана: {this.NameDean}
                    ";
        }
    }
}

