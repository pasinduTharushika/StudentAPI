using System;
using api.DataModels;

namespace api.Repositories
{
	public interface IStudentRepository
	{
		Task<List<Student>> GetStudentsAsync();
       // Task<List<Student>> GetStudentsByIdAsync(int studentId);
    }
}

