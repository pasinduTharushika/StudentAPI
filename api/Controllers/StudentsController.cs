using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DataModels;
using api.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentsController(IStudentRepository studentRepository,IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var students = await _studentRepository.GetStudentsAsync();

            return Ok(_mapper.Map<List<Student>>(students));
        }
        [HttpGet("{studentId}")]
        //[Route("[controller]")]
        public async Task<IActionResult> GetStudentsByIdAsync(Guid studentId)
        {
            var students = await _studentRepository.GetStudentsByIdAsync(studentId);

            return Ok(_mapper.Map<Student>(students));
        }
        [HttpPost]
        [Route("[controller]")]
        public async Task<IActionResult> AddStudentsAsync([FromBody] Student student)
        {
            var students = await _studentRepository.AddStudentsAsync(student);

            return Ok(_mapper.Map<List<Student>>(students));
        }

        [HttpPut("{studentId}")]        
        public async Task<IActionResult> UpdateStudentsAsync(Guid studentId)
        {
            var students = await _studentRepository.UpdateStudentsAsync(studentId);

            return Ok(_mapper.Map<List<Student>>(students));
        }
        [HttpDelete("{studentId}")]
        //[Route("[controller]")]
        public async Task<IActionResult> DeleteStudentsAsync(Guid studentId)
        {
            var students = await _studentRepository.DeleteStudentsAsync(studentId);

            return Ok(_mapper.Map<List<Student>>(students));
        }
    }
}

