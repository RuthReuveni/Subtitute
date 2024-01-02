using Microsoft.EntityFrameworkCore;
using SubtituteDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDL
{
    public class SubTtschoolDL : ISubTtschoolDL
    {

        SubstituteDbContext _substituteDbContext;
        public SubTtschoolDL(SubstituteDbContext substituteDbContext)
        {
            _substituteDbContext = substituteDbContext;
        }
        ///
        public async Task<List<SubTtschool>> GetAllTeachersSub()
        {
            try
            {
                List<SubTtschool> result = await _substituteDbContext.SubTtschools.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching subtitute techers: {ex.Message}");

                throw;
            }
        }
        public async Task<SubTtschool> GetTeacherSubById(int id)
        {
            try
            {
                SubTtschool teacherSub = await _substituteDbContext.SubTtschools.FirstOrDefaultAsync(t => t.SubTtschoolId == id);
                return teacherSub;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }
        //לפי מה משווים בטבלה זו
        // מה המשמעות שלה??
        //SubTtschoolId
        //זה המפתח הראשי?
        //יוצרים מורה או ביה"ס?
        public async Task<SubTtschool> UpdateTeacherSub(SubTtschool teacherSub, int id)
        {
            try
            {
                SubTtschool updateTeacherSub = await _substituteDbContext.SubTtschools.FirstOrDefaultAsync(t => t.SubTtschoolId == id);


                if (updateTeacherSub != null)
                {
                    updateTeacherSub.SubTt = teacherSub.SubTt;
                    updateTeacherSub.Status = teacherSub.Status;
                    updateTeacherSub.SubTtid = teacherSub.SubTtid;
                    updateTeacherSub.School = teacherSub.School;
                    updateTeacherSub.SchoolId = teacherSub.SchoolId;
                    _substituteDbContext.Update(updateTeacherSub);
                    _substituteDbContext.SaveChanges();
                }
                return updateTeacherSub;

            }
            catch (Exception ex)
            {
                throw new Exception("teacher not found");
            }
        }

        public async Task<SubTtschool> DeleteTeacherSub(SubTtschool teacherSub, int id)
        {

            try
            {
                SubTtschool result = await _substituteDbContext.SubTtschools.FirstOrDefaultAsync(t => t.SubTtschoolId == id);
                _substituteDbContext.Remove(result);
                _substituteDbContext.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techersSub: {ex.Message}");

                throw;
            }
        }
        public async Task<SubTtschool> AddTeacherSub(SubTtschool teacherSub)
        {
            try
            {
                SubTtschool _teacherS = await _substituteDbContext.SubTtschools.FirstOrDefaultAsync(t => t.SubTtschoolId == teacherSub.SubTtschoolId);
                if (_teacherS == null)
                    _substituteDbContext.Add(teacherSub);
                _substituteDbContext.SaveChanges();
                return teacherSub;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while adding techers: {ex.Message}");

                throw;
            }
        }
    }
}
