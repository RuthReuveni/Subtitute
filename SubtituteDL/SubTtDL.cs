using Microsoft.EntityFrameworkCore;
using SubtituteDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDL
{
    public class SubTtDL : ISubTtDL
    {

        //        SubstituteDbContext _substituteDbContext;
        //        public SubTtDL(SubstituteDbContext substituteDbContext)
        //        {
        //            _substituteDbContext = substituteDbContext;
        //        }

        //        public async Task<List<SubTt>> GetAllSubTts()
        //        {
        //            try
        //            {
        //                List<SubTt> result = await _substituteDbContext.SubTts.ToListAsync();
        //                return result;
        //            }
        //            catch (Exception ex)
        //            {

        //                Console.WriteLine($"An error occurred while fetching SubTts: {ex.Message}");

        //                throw;
        //            }
        //        }
        //        public async Task<SubTt> GetSubTtById(int id)
        //        {
        //            try
        //            {
        //                SubTt subTt = await _substituteDbContext.SubTts.FirstOrDefaultAsync(t => t.SubTtId == id);
        //                return subTt;
        //            }
        //            catch (Exception ex)
        //            {

        //                Console.WriteLine($"An error occurred while fetching subTts: {ex.Message}");

        //                throw;
        //            }
        //        }
        //        public async Task<SubTt> UpdateSubTt(SubTt subTt, int id)
        //        {
        //            try
        //            {
        //                SubTt updateSubTt = await _substituteDbContext.SubTts.FirstOrDefaultAsync(t => t.SubTtId == id);
        //                //.SubTts.FirstOrDefault(l => l.SubTtId == id);

        //                if (updateSubTt != null)
        //                {
        //                    updateSubTt.SubTtname = subTt.School;
        //                    updateSubTt.TeacherName = teacher.TeacherName;
        //                    updateSubTt.IdNumberT = teacher.IdNumberT;
        //                    updateSubTt.PhoneT = teacher.PhoneT;
        //                    updateSubTt.EmailT = teacher.EmailT;
        //                    _substituteDbContext.Update(updateTeacher);
        //                    _substituteDbContext.SaveChanges();
        //                }
        //                return updateTeacher;

        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("teacher not found");
        //            }
        //        }

        //        public async Task<Teacher> DeleteTeacher(Teacher teacher, int id)
        //        {

        //            try
        //            {
        //                Teacher result = await _substituteDbContext.Teachers.FirstOrDefaultAsync(t => t.TeacherId == id);
        //                _substituteDbContext.Remove(result);
        //                return result;
        //            }
        //            catch (Exception ex)
        //            {

        //                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

        //                throw;
        //            }
        //        }
        //        public async Task<Teacher> AddTeacher(Teacher teacher)
        //        {
        //            try
        //            {
        //                Teacher _teacher = await _substituteDbContext.Teachers.FirstOrDefaultAsync(t => t.TeacherId == teacher.TeacherId);
        //                if (_teacher == null)
        //                    _substituteDbContext.Add(teacher);
        //                return teacher;
        //            }
        //            catch (Exception ex)
        //            {

        //                Console.WriteLine($"An error occurred while adding techers: {ex.Message}");

        //                throw;
        //            }
        //        }
    }
}
