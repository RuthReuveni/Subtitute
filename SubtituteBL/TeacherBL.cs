using AutoMapper;
using SubtituteDL;
using SubtituteDL.Models;
using SubtituteDTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteBL
{
    public class TeacherBL : ITeacherBL
    {
        public IMapper _mapper;
        ITeacherDL _teacherDl;
        public TeacherBL(ITeacherDL teacherDl, IMapper mapper)
        {
            _teacherDl = teacherDl;
            _mapper = mapper;
        }

        public async Task<List<TeacherDTO>> GetAllTeachers()
        {
            try
            {
                List<Teacher> teacherList = await _teacherDl.GetAllTeachers();
                List<TeacherDTO> resualt = _mapper.Map<List<TeacherDTO>>(teacherList);
                return resualt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while conversion to TeacherDTO: {ex.Message}");
                throw;
            }
        }
        public async Task<TeacherDTO> GetTeacherById(int id)
        {
            try
            {
                Teacher teacher = await _teacherDl.GetTeacherById(id);
                TeacherDTO techerDTO = _mapper.Map<TeacherDTO>(teacher);
                return techerDTO;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }
        public async Task<TeacherDTO> UpdateTeacher(TeacherDTO teacherDTO, int id)
        {
            try
            {
                Teacher teacher = _mapper.Map<Teacher>(teacherDTO);
                Teacher _teacher = await _teacherDl.UpdateTeacher(teacher, id);
                teacherDTO = _mapper.Map<TeacherDTO>(_teacher);
                return teacherDTO;

            }
            catch (Exception ex)
            {
                throw new Exception("teacher not found");
            }
        }

        public async Task<TeacherDTO> DeleteTeacher(TeacherDTO teacherDTO, int id)
        {

            try
            {
                Teacher teacher = _mapper.Map<Teacher>(teacherDTO);
                Teacher _teacher = await _teacherDl.DeleteTeacher(teacher, id);
                teacherDTO = _mapper.Map<TeacherDTO>(_teacher);
                return teacherDTO;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }
        public async Task<TeacherDTO> AddTeacher(TeacherDTO teacherDTO)
        {
            try
            {
                Teacher teacher = _mapper.Map<Teacher>(teacherDTO);
                Teacher _teacher = await _teacherDl.AddTeacher(teacher);
                teacherDTO = _mapper.Map<TeacherDTO>(_teacher);
                return teacherDTO;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while adding techers: {ex.Message}");

                throw;
            }
        }

    }
}
