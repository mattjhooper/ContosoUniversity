using System;
using System.Collections.Generic;
using System.Linq;

namespace ContosoUniversity.Models
{
    public class Student
    {
        private List<Enrollment> _enrollments;
        private string _LastName;

        public int ID { get; private set; }
        public string LastName
        {
            get { return _LastName; }
            private set
            {
                _LastName = value ?? throw new ArgumentException("LastName must not be null", nameof(value));
            }
        }

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

        public void UpdateName(string lastName, string firstMidName)
        {
            LastName = lastName;
            FirstMidName = firstMidName;
        }

        public void UpdateEnrollmentDate(DateTime enrollmentDate)
        {
            EnrollmentDate = enrollmentDate;
        }

    }
}