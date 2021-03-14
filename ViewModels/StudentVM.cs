using System;
using ContosoUniversity.Models;

namespace ContosoUniversity.ViewModels
{
    #region snippet
    public class StudentVM
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public static StudentVM FromStudent(Student student)
        {
            var studentVM = new StudentVM
            {
                ID = student.ID,
                LastName = student.LastName,
                FirstMidName = student.FirstMidName,
                EnrollmentDate = student.EnrollmentDate
            };

            return studentVM;
        }
    }
    #endregion
}
