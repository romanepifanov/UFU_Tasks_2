using System;
using System.Collections.Generic;
using Two.Models;

namespace Two.Controllers
{
    class FacultyController
    {
        private readonly List<Faculty> faculties = new List<Faculty>();
        public FacultyController() {}

        public void AddFaculty(Faculty faculty)
        {
            this.faculties.Add(faculty);
        }

        public void PrintFaculties()
        {
            foreach(Faculty f in this.faculties)
            {
                Console.WriteLine(f.ToString());
            }
        }
    }
}
