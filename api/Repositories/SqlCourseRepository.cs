using api.DataModels;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class SqlCourseRepository :ICourseRepository
    {
        private readonly StudentManagementContext _context;

        public SqlCourseRepository(StudentManagementContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> GetAllCourseAsync()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course> GetCourseByIdAsync(Guid studentId)
        {
            return _context.Courses.FirstOrDefault(student => student.Id == studentId);
        }

        public async Task<List<Course>> AddCourseAsync(Guid studentId)
        {
            return   await _context.Courses.ToListAsync();
        }
        public async Task<List<Course>> UpdateCourseAsync(Guid studentId)
        {
            return await _context.Courses.ToListAsync();
        }
        public async Task<List<Course>> DeleteCourseAsync(Guid studentId)
        {
            return await _context.Courses.ToListAsync();
        }
    }
}
