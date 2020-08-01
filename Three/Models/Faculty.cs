namespace Three.Models
{
    class Faculty
    {
        public string NameFaculty { get; set; }
        public string Room { get; set; }
        public string Corps { get; set; }
        public string Telephone { get; set; }
        public string NameDean { get; set; }

        public override string ToString()
        {
            return @$"
                    Факультет: {this.NameFaculty}
                    Аудитория: {this.Room}
                    Корпус: {this.Corps}
                    Контактный телефон: {this.Telephone}
                    Фамилия декана: {this.NameDean}
                    ";
        }
    }
}

