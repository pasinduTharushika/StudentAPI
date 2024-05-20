using System;
using Microsoft.EntityFrameworkCore;

namespace api.DataModels
{
	public class StudentManagementContext : DbContext
	{
		public StudentManagementContext(DbContextOptions<StudentManagementContext> options): base(options)
		{
		}
		public DbSet<Student> Student { get; set; }
		public DbSet<Gender> Gender { get; set; }
		public DbSet<Address> Address { get; set; }

		public DbSet<Course> Courses { get; set; }
	}
}

