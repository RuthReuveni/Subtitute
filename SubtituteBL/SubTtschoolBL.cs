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
    public class SubTtschoolBL : ISubTtschoolBL
    {
        public IMapper _mapper;
        ISubTtschoolDL _subTtSchoolDl;
        public SubTtschoolBL(ISubTtschoolDL subTtSchoolDl, IMapper mapper)
        {
            _subTtSchoolDl = subTtSchoolDl;
            _mapper = mapper;
        }

        public async Task<List<SubTtschoolDTO>> GetAllTeachersSub()
        {
            try
            {
                List<SubTtschool> subTtSchoolList = await _subTtSchoolDl.GetAllTeachersSub();
                List<SubTtschoolDTO> resualt = _mapper.Map<List<SubTtschoolDTO>>(subTtSchoolList);
                return resualt;
            }
            catch (Exception ex)
            {///לשים לב להערות האדומות
                Console.WriteLine($"An error occurred while conversion to SubTtschoolDTO: {ex.Message}");
                throw;
            }
        }
        public async Task<SubTtschoolDTO> GetTeacherSubById(int id)
        {
            try
            {
                SubTtschool subTtschool = await _subTtSchoolDl.GetTeacherSubById(id);
                SubTtschoolDTO subTtschoolDTO = _mapper.Map<SubTtschoolDTO>(subTtschool);
                return subTtschoolDTO;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }
        public async Task<SubTtschoolDTO> UpdateTeacherSub(SubTtschoolDTO subTtschoolDTO, int id)
        {
            try
            {
                SubTtschool subTtschool = _mapper.Map<SubTtschool>(subTtschoolDTO);
                SubTtschool _subTtSchool = await _subTtSchoolDl.UpdateTeacherSub(subTtschool, id);
                //כאן דורסת את מה שקיבלתי
                //האם נכון או ליצור חדש?
                subTtschoolDTO = _mapper.Map<SubTtschoolDTO>(_subTtSchool);
                return subTtschoolDTO;

            }
            catch (Exception ex)
            {
                throw new Exception("teacher not found");
            }
        }

        public async Task<SubTtschoolDTO> DeleteTeacherSub(SubTtschoolDTO subTtschoolDTO, int id)
        {

            try
            {
                SubTtschool subTtschool = _mapper.Map<SubTtschool>(subTtschoolDTO);
                SubTtschool _subTtschool = await _subTtSchoolDl.DeleteTeacherSub(subTtschool, id);
                subTtschoolDTO = _mapper.Map<SubTtschoolDTO>(_subTtschool);
                return subTtschoolDTO;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }
        public async Task<SubTtschoolDTO> AddTeacherSub(SubTtschoolDTO subTtschoolDTO)
        {
            try
            {
                SubTtschool subTtschool = _mapper.Map<SubTtschool>(subTtschoolDTO);
                SubTtschool _subTtschool = await _subTtSchoolDl.AddTeacherSub(subTtschool);
                subTtschoolDTO = _mapper.Map<SubTtschoolDTO>(_subTtschool);
                return subTtschoolDTO;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while adding techers: {ex.Message}");

                throw;
            }
        }

    }
}
