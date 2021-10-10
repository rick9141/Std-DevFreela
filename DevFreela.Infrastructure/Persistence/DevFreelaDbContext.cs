using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("My POC project ASPNET Core 1", "My description project 1", 1, 1, 10000),
                new Project("My POC project ASPNET Core 2", "My description project 2", 1, 1, 20000),
                new Project("My POC project ASPNET Core 3", "My description project 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Luis Henrique", "gavirate.henrique@gmail.com", new DateTime(1995, 5, 5)),
                new User("Donald Muley", "donald@geu.com", new DateTime(1990, 1, 1)),
                new User("Elliot Cambridge", "elliot@eu.com", new DateTime(1980, 5, 3))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }


    }
}
