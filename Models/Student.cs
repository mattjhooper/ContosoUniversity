using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        private string _LastName;
        public int ID { get; set; }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value ?? throw new ArgumentException("LastName must not be null", nameof(value));
            }
        }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}