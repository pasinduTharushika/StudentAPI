using System;
using api.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace api.Repositories
{
	public interface IStudentRepository
	{
		Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentsByIdAsync(Guid studentId);
        Task<List<Student>> AddStudentsAsync(Student student);
        Task<List<Student>> UpdateStudentsAsync(Guid studentId);
        Task<List<Student>> DeleteStudentsAsync(Guid studentId);
    }
}

