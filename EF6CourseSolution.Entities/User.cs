using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CourseSolution.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Email { get; set; }
        public string? Passwd { get; set; }

        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
        public virtual IEnumerable<Project> Projects { get; set; } = new List<Project>();
    }
}
