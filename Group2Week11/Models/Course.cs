﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Group2Week11.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseStudents = new HashSet<CourseStudent>();
        }

        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseCredits { get; set; }
        public string InstructorId { get; set; }
        public string CourseRoom { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<CourseStudent> CourseStudents { get; set; }
    }
}