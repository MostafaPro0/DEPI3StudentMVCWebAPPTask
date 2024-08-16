
using DEPI3StudentMVCWebAPPTask;
using DEPI3StudentMVCWebAPPTask.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DEPI3StudentMVCWebAPPTask.Controllers
{
    public class StudentController : Controller
    {

        //Student/Index
        public IActionResult Index()
        {
            StudentMock studentMock = new StudentMock();
            var students = studentMock.GetAllStudents();

            return View(students);
        }

        // [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // /Student/Details/1
        [HttpGet]
        public IActionResult Details(int? id, string ViewName = "Details")
        {
            //Defensive Code

            if (id is null)
                return BadRequest(); //400

            StudentMock studentMock = new StudentMock();
            var student = studentMock.GetStudentById(id.Value);

            if (student is null)
                return NotFound(); //404

            //Will Execute it if pass at all Validations 
            return View(ViewName, student);
        }
    }
}
