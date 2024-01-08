using AutoMapper;
using SubtituteDL.Models;
using SubtituteDL;
using SubtituteDTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteBL
{
    public class SpesializitionSubTtBL : ISpesializitionSubTtBL
    {
        public IMapper _mapper;
        ISpesializitionSubTtDL _spesializitionSubTtDl;
        public SpesializitionSubTtBL(ISpesializitionSubTtDL spesializitionSubTtDl, IMapper mapper)
        {
            _spesializitionSubTtDl = spesializitionSubTtDl;
            _mapper = mapper;
        }

        public async Task<List<SpesializitionSubTtDTO>> GetAllSpesializitionSubTts()
        {
            try
            {
                List<SpesializitionSubTt> teacherList = await _spesializitionSubTtDl.GetAllSpesializitionSubTts();
                List<SpesializitionSubTtDTO> resualt = _mapper.Map<List<SpesializitionSubTtDTO>>(teacherList);
                return resualt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while conversion to SpesializitionSubTtDTO: {ex.Message}");
                throw;
            }
        }
        public async Task<SpesializitionSubTtDTO> GetTeacherBySPId(int id)
        {
            try
            {
                List<SpesializitionSubTt> teachers = await _spesializitionSubTtDl.GetTeacherBySPId(id);
                SpesializitionSubTtDTO techerSpDTO = _mapper.Map<SpesializitionSubTtDTO>(teachers);
                return techerSpDTO;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }
    }
}
