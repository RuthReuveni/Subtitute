using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SubtituteBL;
using SubtituteDL.Models;
using SubtituteDL;
using SubtituteDTO.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subtitute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        ITeacherBL _teacherBL;
        public TeachersController(ITeacherBL teacherBL)
        {
            _teacherBL = teacherBL;
        }
        // GET: api/<TeachersController>
        [HttpGet("getAllTeachers")]
        public async Task<List<TeacherDTO>> GetAllTeachers()
        {
            List<TeacherDTO> result= await _teacherBL.GetAllTeachers();
            return result;
        }

        // GET api/<TeachersController>/5
        [HttpGet("getTeacherById{id}")]

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
        // POST api/<TeachersController>
        [HttpPost("addTeacher")]
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

        // PUT api/<TeachersController>/5
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

        // DELETE api/<TeachersController>/5
        [HttpDelete("{id}")]


        public async Task<bool> DeleteTeacher( int id)
        {

            try
            {
             return   await _teacherBL.DeleteTeacher( id);
                
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }
    }
}


