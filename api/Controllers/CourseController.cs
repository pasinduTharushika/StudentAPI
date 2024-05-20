//using api.DataModels;
//using api.Repositories;
//using AutoMapper;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CourseController : ControllerBase
//    {
//        private readonly ICourseRepository _courseRepository;
//        private readonly IMapper _mapper;

//        public CourseController(ICourseRepository courseRepository, IMapper mapper)
//        {
//            _courseRepository = courseRepository;
//            _mapper = mapper;
//        }

//        [HttpGet]

//        public async Task<IActionResult> GetAllCourseAsync()
//        {
//            var courses = await _courseRepository.GetAllCourseAsync();

//            return Ok(_mapper.Map<List<Student>>(courses));
//        }
//        [HttpGet("{studentId}")]

//        public async Task<IActionResult> GetCourseByIdAsync(Guid studentId)
//        {
//            var courses = await _courseRepository.GetCourseByIdAsync(studentId);

//            return Ok(_mapper.Map<Student>(courses));
//        }
//        [HttpPost]

//        public async Task<IActionResult> AddStudentsAsync(Guid studentId)
//        {
//            var courses = await _courseRepository.AddCourseAsync(studentId);

//            return Ok(_mapper.Map<List<Student>>(courses));
//        }
//        [HttpPut]

//        public async Task<IActionResult> UpdateStudentsAsync(Guid studentId)
//        {
//            var courses = await _courseRepository.UpdateCourseAsync(studentId);

//            return Ok(_mapper.Map<List<Student>>(courses));
//        }
//        [HttpDelete]

//        public async Task<IActionResult> DeleteStudentsAsync(Guid studentId)
//        {
//            var courses = await _courseRepository.DeleteCourseAsync(studentId);

//            return Ok(_mapper.Map<List<Student>>(courses));
//        }
//    }
//}
