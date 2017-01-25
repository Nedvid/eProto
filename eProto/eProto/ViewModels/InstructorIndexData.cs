using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eProto.Models;

namespace eProto.ViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}