using Microsoft.AspNetCore.Mvc;
using SubtituteBL;
using SubtituteDL.Models;
using SubtituteDTO.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subtitute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        ILessonBL _lessonBL;
        public LessonsController(ILessonBL lessonBL)
        {
            _lessonBL = lessonBL;
        }

        // GET: api/<LessonController>
        [HttpGet]
        public List<LessonDTO> Get()
        {
            return _lessonBL.getLessons();
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LessonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public LessonDTO Put(int id, [FromBody] LessonDTO lesson)
        {
            return _lessonBL.UpdateLesson(lesson, id);
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
