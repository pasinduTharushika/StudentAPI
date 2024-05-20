using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DomainModels;
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
        //[HttpGet]
        //[Route("[controller]")]
        //public async Task<IActionResult> GetStudentsByIdAsync(int studentId)
        //{
        //    var students = await _studentRepository.GetStudentsByIdAsync(studentId);

        //    return Ok(_mapper.Map<List<Student>>(students));
        //}
    }
}

