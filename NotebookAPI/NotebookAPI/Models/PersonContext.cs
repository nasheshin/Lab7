﻿using System.Data.Entity;

namespace NotebookAPI.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}
