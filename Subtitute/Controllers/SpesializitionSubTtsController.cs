using Microsoft.AspNetCore.Mvc;
using SubtituteBL;
using SubtituteDTO.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subtitute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpesializitionSubTtsController : ControllerBase
    {
        ISpesializitionSubTtBL _spesializitionSubTtBL;
        public SpesializitionSubTtsController(ISpesializitionSubTtBL spesializitionSubTtBL)
        {
            _spesializitionSubTtBL = spesializitionSubTtBL;
        }
        // GET: api/<SpesializitionSubTtsController>
        [HttpGet("GetAllSpesializitionSubTts")]

        public async Task<List<SpesializitionSubTtDTO>> GetAllSpesializitionSubTts()
        {
            List<SpesializitionSubTtDTO> result = await _spesializitionSubTtBL.GetAllSpesializitionSubTts();
            return result;
        }
        // GET api/<SpesializitionSubTtsController>/5
        [HttpGet("GetTeacherBySPId{id}")]
        public async Task<SpesializitionSubTtDTO> GetTeacherBySPId(int id)
        {
            try
            {
                SpesializitionSubTtDTO teacherDTO = await _spesializitionSubTtBL.GetTeacherBySPId(id);
                return teacherDTO;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while conversion to TeacherDTO: {ex.Message}");
                throw;
            }
        }


    }
}
