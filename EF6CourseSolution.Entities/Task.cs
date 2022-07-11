﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CourseSolution.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool Done { get; set; }
        public int ProjectId { get; set; }
        public int? UserId { get; set; }

        public int? ParentId { get; set; }
        public User? User { get; set; }
        public virtual IEnumerable<Task> Children { get; set; } = new List<Task>();
    }
}
