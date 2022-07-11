namespace EF6CourseSolution.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DeadLine { get; set; }
        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}