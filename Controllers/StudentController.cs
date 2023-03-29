using StudentApi.Models;
using StudentApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace StudentApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    public StudentController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Student>> GetAll() =>
        StudentService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Student> Get(int id)
    {
        var student = StudentService.Get(id);

        if (student == null)
            return NotFound();

        return student;
    }

    // POST action
    [HttpPost]
    public IActionResult Create(Student student)
    {
        StudentService.Add(student);
        return CreatedAtAction(nameof(Get), new { id = student.Id }, student);
    }

    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Student student)
    {
        if (id != student.Id)
            return BadRequest();

        var existingPizza = StudentService.Get(id);
        if (existingPizza is null)
            return NotFound();

        StudentService.Update(student);

        return Ok();
    }

    // DELETE action
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Delete(int id)
    {
        var student = StudentService.Get(id);

        if (student is null)
            return NotFound();

        StudentService.Delete(id);

        return Ok();
    }
}