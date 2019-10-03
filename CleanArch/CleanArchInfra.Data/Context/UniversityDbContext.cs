using ClearArchDomain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchInfra.Data.Context
{
	public class UniversityDbContext : DbContext
	{
		public UniversityDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Course> Courses { get; set; }
	}
}
