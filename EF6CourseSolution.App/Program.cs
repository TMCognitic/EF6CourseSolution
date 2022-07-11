using EF6CourseSolution.Context;
using EF6CourseSolution.Entities;
using E = EF6CourseSolution.Entities;

namespace EF6CourseSolution.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectContext projectContext = new ProjectContext();

            Project project = new Project() { Name = "Demo Ef Core 6", DeadLine = DateTime.Now.AddDays(1) };
            project.Tasks.Add(new E.Task() { Name = "Create Project", Description = "Create The project using EF Core 6" });
            project.Tasks.Add(new E.Task() { Name = "Deploy Project", Description = "Deploy the database" });

            projectContext.Add(project);
            projectContext.SaveChanges();

            User user = new User() { LastName = "Doe", FirstName = "Jane", Email = "doe.jane@gmail.com", Passwd = "Test1234=" };
            project.Users.Add(user);

            projectContext.SaveChanges();
            foreach(E.Task task in project.Tasks)
            {
                task.User = user;
            }

            projectContext.SaveChanges();
        }
    }
}