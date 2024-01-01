using Microsoft.EntityFrameworkCore;
using SubtituteDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDL
{
    public class TeacherDL : ITeacherDL
    {

        SubstituteDbContext _substituteDbContext;
        public TeacherDL(SubstituteDbContext substituteDbContext)
        {
            _substituteDbContext = substituteDbContext;
        }

        public async Task<List<Teacher>> GetAllTeachers()
        {
            try
            {
                List<Teacher> result = await _substituteDbContext.Teachers.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }
        public async Task<Teacher> GetTeacherById(int id)
        {
            try
            {
                Teacher teacher = await _substituteDbContext.Teachers.FirstOrDefaultAsync(t => t.TeacherId == id);
                return teacher;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }
        public async Task<Teacher> UpdateTeacher(Teacher teacher, int id)
        {
            try
            {
                Teacher updateTeacher = await _substituteDbContext.Teachers.FirstOrDefaultAsync(t => t.TeacherId == id);
                //.Teachers.FirstOrDefault(l => l.TeacherId == id);

                if (updateTeacher != null)
                {
                    updateTeacher.School = teacher.School;
                    updateTeacher.TeacherName = teacher.TeacherName;
                    updateTeacher.IdNumberT = teacher.IdNumberT;
                    updateTeacher.PhoneT = teacher.PhoneT;
                    updateTeacher.EmailT = teacher.EmailT;
                    _substituteDbContext.Update(updateTeacher);
                    _substituteDbContext.SaveChanges();
                }
                return updateTeacher;

            }
            catch (Exception ex)
            {
                throw new Exception("teacher not found");
            }
        }

        public async Task<Teacher> DeleteTeacher(Teacher teacher, int id)
        {

            try
            {
                Teacher result = await _substituteDbContext.Teachers.FirstOrDefaultAsync(t => t.TeacherId == id);
                _substituteDbContext.Remove(result);
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }
        public async Task<Teacher> AddTeacher(Teacher teacher)
        {
            try
            {
                Teacher _teacher = await _substituteDbContext.Teachers.FirstOrDefaultAsync(t => t.TeacherId == teacher.TeacherId);
                if (_teacher == null)
                    _substituteDbContext.Add(teacher);
                return teacher;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while adding techers: {ex.Message}");

                throw;
            }
        }

    }
}
