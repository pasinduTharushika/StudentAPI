using api.DataModels;

namespace api.Repositories
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllCourseAsync();
        Task<Course> GetCourseByIdAsync(Guid studentId);
        Task<List<Course>> AddCourseAsync(Guid studentId);
        Task<List<Course>> UpdateCourseAsync(Guid studentId);
        Task<List<Course>> DeleteCourseAsync(Guid studentId);
    }
}
