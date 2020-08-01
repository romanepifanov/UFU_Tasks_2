namespace One.Models
{
    class Deanery
    {
        public string NameFaculty { get; set; }
        public string Room { get; set; }
        public string Corps { get; set; }
        public string Telephone { get; set; }
        public string NameDean { get; set; }

        public Deanery(string _NameFaculty, string _Room, string _Corps, string _Telephone, string _NameDean)
        {
            this.NameFaculty = _NameFaculty;
            this.Room = _Room;
            this.Corps = _Corps;
            this.Telephone = _Telephone;
            this.NameDean = _NameDean;
        }

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
