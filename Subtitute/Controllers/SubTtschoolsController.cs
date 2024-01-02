using Microsoft.AspNetCore.Mvc;
using Subtitute.Controllers;
using SubtituteBL;
using SubtituteDTO.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subtitute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubTtschoolsController : ControllerBase
    {
        ISubTtschoolBL _subTtschoolBL;
        public SubTtschoolsController(ISubTtschoolBL subTtschoolBL)
        {
            _subTtschoolBL = subTtschoolBL;
        }
        // GET: api/<SubTtschoolsController>
        [HttpGet]

        public async Task<List<SubTtschoolDTO>> GetAllTeacherSub()
        {
            List<SubTtschoolDTO> result = await _subTtschoolBL.GetAllTeachersSub();
            return result;
        }

        // GET api/<SubTtschoolsController>/5
        [HttpGet("{id}")]
        public async Task<SubTtschoolDTO> GetTeacherById(int id)
        {
            try
            {
                SubTtschoolDTO subTtschoolDTO = await _subTtschoolBL.GetTeacherSubById(id);
                return subTtschoolDTO;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while conversion to TeacherDTO: {ex.Message}");
                throw;
            }
        }

        // POST api/<SubTtschoolsController>
        [HttpPost]
        public async Task<SubTtschoolDTO> AddTeacher(SubTtschoolDTO subTtschoolDTO)
        {
            try
            {
                SubTtschoolDTO _subTtschoolDTO = await _subTtschoolBL.AddTeacherSub(subTtschoolDTO);

                return _subTtschoolDTO;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while adding techers: {ex.Message}");

                throw;
            }
        }

        // PUT api/<SubTtschoolsController>/5
        [HttpPut("{id}")]

        public async Task<SubTtschoolDTO> UpdateTeacher(SubTtschoolDTO subTtschoolDTO, int id)
        {
            try
            {
                SubTtschoolDTO _subTtschoolDTO = await _subTtschoolBL.UpdateTeacherSub(subTtschoolDTO, id);
                return _subTtschoolDTO;

            }
            catch (Exception ex)
            {
                throw new Exception("teacher not found");
            }
        }
        // DELETE api/<SubTtschoolsController>/5
        [HttpDelete("{id}")]
        public async Task<SubTtschoolDTO> DeleteTeacherSub(SubTtschoolDTO subTtschoolDTO, int id)
        {

            try
            {
                SubTtschoolDTO _subTtschoolDTO = await _subTtschoolBL.DeleteTeacherSub(subTtschoolDTO, id);
                return _subTtschoolDTO;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }
    }
}






