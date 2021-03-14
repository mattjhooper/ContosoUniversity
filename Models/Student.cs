using System;
using System.Collections.Generic;
using System.Linq;

namespace ContosoUniversity.Models
{
    public class Student
    {
        private List<Enrollment> _enrollments;

        public int ID { get; private set; }
        public string LastName { get; private set; }
        public string FirstMidName { get; private set; }
        public DateTime EnrollmentDate { get; private set; }

        public IEnumerable<Enrollment> Enrollments => _enrollments.ToList();

        private Student() { }

        public Student(string lastName, string firstMidName, DateTime enrollmentDate)
        {
            LastName = lastName;
            FirstMidName = firstMidName;
            EnrollmentDate = enrollmentDate;
        }
    }
}