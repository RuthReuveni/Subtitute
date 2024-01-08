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
                List<Teacher> result = await _substituteDbContext.Teachers/*.Where(x=>x.status==1)*/.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }


        //public async Task<List<Teacher>> GetAllTeachersmm()
        //{
        //    try
        //    {
        //        List<Teacher> result = await _substituteDbContext.Teachers t
        //            join _substituteDbContext.subtitute  n on  t.mm==n.id
        //            .ToListAsync();
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

        //        throw;
        //    }
        //}
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

        public async Task<bool> DeleteTeacher( int id)
        {

            try
            {
                Teacher result = await _substituteDbContext.Teachers.FirstOrDefaultAsync(t => t.TeacherId == id);
                _substituteDbContext.Remove(result);
             await  _substituteDbContext.SaveChangesAsync();
                return true;
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
                Teacher _teacher = await _substituteDbContext.Teachers.FirstOrDefaultAsync(t => t.IdNumberT == teacher.IdNumberT);
                if (_teacher == null)
                    _substituteDbContext.AddAsync(teacher);
                await _substituteDbContext.SaveChangesAsync();  
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
