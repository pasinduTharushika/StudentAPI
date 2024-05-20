using System;
using api.DataModels;
using api.DomainModels;
using Microsoft.EntityFrameworkCore;
using Student = api.DataModels.Student;

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
            return await _context.Student.ToListAsync();
        }

        public async Task<Student> GetStudentsByIdAsync(Guid studentId)
        {
            return await _context.Student.FindAsync(studentId);
        }

        public async Task<List<Student>> AddStudentsAsync(Student student)
        {
            _context.Student.Add(student);
            await _context.SaveChangesAsync();
            return await _context.Student.ToListAsync();
        }
        public async Task<List<Student>> UpdateStudentsAsync(Guid studentId)
        {
            //_context.Student.Update(student);
            //await _context.SaveChangesAsync();
            return await _context.Student.ToListAsync();
        }
        public async Task<List<Student>> DeleteStudentsAsync(Guid studentId)
        {
            var student = await _context.Student.FindAsync(studentId);
            if (student != null)
            {
                _context.Student.Remove(student);
                await _context.SaveChangesAsync();
            }
            return await _context.Student.ToListAsync();
        }
    }
}

