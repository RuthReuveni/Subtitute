using Microsoft.AspNetCore.Mvc;
using Subtitute.Controllers;
using SubtituteBL;
using SubtituteDTO.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subtitute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubTtsController : ControllerBase
    {
        ITeacherBL _teacherBL;
public SubTtsController(ITeacherBL teacherBL)
{
    _teacherBL = teacherBL;
}
        // GET: api/<SubTtsController>
        [HttpGet]
public async Task<List<TeacherDTO>> GetAllTeachers()
{
    List<TeacherDTO> result = await _teacherBL.GetAllTeachers();
    return result;
}


        // GET api/<SubTtsController>/5
        [HttpGet("{id}")]
        public async Task<TeacherDTO> GetTeacherById(int id)
{
    try
    {
        TeacherDTO teacherDTO = await _teacherBL.GetTeacherById(id);
        return teacherDTO;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while conversion to TeacherDTO: {ex.Message}");
        throw;
    }
}

        // POST api/<SubTtsController>
        [HttpPost]

public async Task<TeacherDTO> AddTeacher(TeacherDTO teacher)
{
    try
    {
        TeacherDTO _teacher = await _teacherBL.AddTeacher(teacher);

        return _teacher;
    }
    catch (Exception ex)
    {

        Console.WriteLine($"An error occurred while adding techers: {ex.Message}");

        throw;
    }
}

        // PUT api/<SubTtsController>/5
        [HttpPut("{id}")]

public async Task<TeacherDTO> UpdateTeacher(TeacherDTO teacher, int id)
{
    try
    {
        TeacherDTO _teacher = await _teacherBL.UpdateTeacher(teacher, id);
        return _teacher;

    }
    catch (Exception ex)
    {
        throw new Exception("teacher not found");
    }
}

        // DELETE api/<SubTtsController>/5
        [HttpDelete("{id}")]
public async Task<TeacherDTO> DeleteTeacher(TeacherDTO teacher, int id)
{

    try
    {
        TeacherDTO _teacher = await _teacherBL.DeleteTeacher(teacher, id);
        return _teacher;
    }
    catch (Exception ex)
    {

        Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

        throw;
    }
}
    }
}





