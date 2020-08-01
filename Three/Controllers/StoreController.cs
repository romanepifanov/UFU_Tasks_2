using System;
using System.Collections.Generic;
using System.Linq;
using Three.Models;

namespace Three.Controllers
{
    class FacultyController
    {
        private List<Faculty> faculties = new List<Faculty>();
        public FacultyController() { }

        public void AddFaculty(Faculty faculty)
        {
            this.faculties.Add(faculty);
        }

        public void PrintFaculties()
        {
            foreach (Faculty f in this.faculties)
            {
                Console.WriteLine(f.ToString());
            }
        }

        #region TASK 3
        public void CorpsOrderByDescending()
        {
            faculties = faculties.OrderByDescending(f => f.Corps).ToList();
        }

        public void CorpsOrderByAscending()
        {
            faculties = faculties.OrderBy(f => f.Corps).ToList();
        }

        public void NameFacultyOrderByDescending()
        {
            faculties = faculties.OrderByDescending(c => c.NameFaculty).ToList();
        }

        public void NameFacultyOrderByAscending()
        {
            faculties = faculties.OrderBy(c => c.NameFaculty).ToList();
        }
        #endregion TASK 3
    }
}
