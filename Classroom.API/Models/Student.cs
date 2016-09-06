using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classroom.API.Models
{
    public class Student
    {
        public int StudentId { set; get; }
        public String FirstName { set; get; }
        public String LastName { set; get; }
        public String EmailAddress { set; get; }
        public String Telephone { set; get; }

        public virtual ICollection<Assignment> Assignments { set; get; }
    }
}