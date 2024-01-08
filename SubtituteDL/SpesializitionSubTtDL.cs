using Microsoft.EntityFrameworkCore;
using SubtituteDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDL
{
    public class SpesializitionSubTtDL : ISpesializitionSubTtDL
    {

        SubstituteDbContext _substituteDbContext;
        public SpesializitionSubTtDL(SubstituteDbContext substituteDbContext)
        {
            _substituteDbContext = substituteDbContext;
        }

        public async Task<List<SpesializitionSubTt>> GetAllSpesializitionSubTts()
        {
            try
            {
                List<SpesializitionSubTt> result = await _substituteDbContext.SpesializitionSubTts.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching SpesializitionSubTts: {ex.Message}");

                throw;
            }
        }
        ///פונקציה המביאה מורות לפי התמחות
        public async Task<List<SpesializitionSubTt>> GetTeacherBySPId(int id)
        {
            try
            {
                List<SpesializitionSubTt> spesializitionSubTt = await _substituteDbContext.SpesializitionSubTts.Where(t => t.SpecializationId == id).ToListAsync();
                return spesializitionSubTt;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching techers: {ex.Message}");

                throw;
            }
        }





    }
}
