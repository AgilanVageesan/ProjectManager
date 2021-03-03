using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjectManager.Models;

namespace ProjectManager

{
    public class ApiDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public ApiDbContext(DbContextOptions options) : base(options)
        {
            AddUsers();
            AddProjects();
            AddTasks();
        }

        public void AddUsers()
        {
            User user = new User() { Id = 1, Email = "User1@gmail.com", FirstName = "User", LastName = "One", Password = "User123" };
            Users.Add(user);
            User userTwo = new User() { Id = 2, Email = "User2@gmail.com", FirstName = "User", LastName = "Two", Password = "User234" };
            Users.Add(userTwo);
        }

        public void AddProjects()
        {
            Project project1 = new Project()
            {
                Id = 1,
                Name = "Project 1",
                Detail = "To be Added",
                CreatedOn = DateTime.Now
            };
            Projects.Add(project1);
        }
        public void AddTasks()
        {
            Task task1 = new Task()
            {
                Id = 1,
                Status = 1,
                AssignedToUserId = 1,
                ProjectId = 1,
                Detail = "To be Added",
                CreatedOn = DateTime.Now
            };
            Tasks.Add(task1);
        }


        public List<User> GetUsers()
        {
            return Users.Local.ToList();
        }
        public List<Project> GetProjects()
        {
            return Projects.Local.ToList();
        }

        public List<Task> GetTasks()
        {
            return Tasks.Local.ToList();
        }

    }
}
