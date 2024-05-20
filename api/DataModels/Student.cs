using System;
using System.Net;
using System.Reflection;

namespace api.DataModels
{
	public class Student
	{
        public Guid Id { get; set; }
        public string? FullNmae { get; set; }
        //public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public long Mobile { get; set; }
        public string? Address { get; set; }
        public string Gender { get; set; }
        public Guid CourseId { get; set; }
        // Navigation Properties
        public Course? Course { get; set; }
    }
}

