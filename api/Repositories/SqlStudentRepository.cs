using System;
using api.DataModels;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
	public class SqlStudentRepository : IStudentRepository
	{
        private readonly StudentManagementContext _context;

        public SqlStudentRepository(StudentManagementContext context)
		{
            _context = context;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

        //public async Task<List<Student>> GetStudentsByIdAsync(int studentId)
        //{
        //    return await _context.Student.Where(a => a.Id == studentId).ToListAsync();
        //}
    }
}

