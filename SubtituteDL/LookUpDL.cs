using Microsoft.EntityFrameworkCore;
using SubtituteDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDL
{
    public class LookUpDL : ILookUpDL
    {

        SubstituteDbContext _substituteDbContext;
        public LookUpDL(SubstituteDbContext substituteDbContext)
        {
            _substituteDbContext = substituteDbContext;
        }

        public async Task<List<Area>> GetAllAreas()
        {
            try
            {
                List<Area> result = await _substituteDbContext.Areas.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching Areas: {ex.Message}");

                throw;
            }
        }

        public async Task<Area> GetAreaById(int id)
        {
            try
            {
                Area area = await _substituteDbContext.Areas.FirstOrDefaultAsync(t => t.AreasId == id);
                return area;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching Areas: {ex.Message}");

                throw;
            }

        }

        public async Task<List<Duration>> GetAllDurations()
        {
            try
            {
                List<Duration> result = await _substituteDbContext.Durations.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching Durations: {ex.Message}");

                throw;
            }
        }

        public async Task<Duration> GetDurationById(int id)
        {
            try
            {
                Duration duration = await _substituteDbContext.Durations.FirstOrDefaultAsync(t => t.DurationId == id);
                return duration;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching Durations: {ex.Message}");

                throw;
            }
        }
        public async Task<List<Network>> GetAllNetworks()
        {
            try
            {
                List<Network> result = await _substituteDbContext.Networks.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching Networks: {ex.Message}");

                throw;
            }
        }

        public async Task<Network> GetNetworkById(int id)
        {
            try
            {
                Network network = await _substituteDbContext.Networks.FirstOrDefaultAsync(t => t.NetworkId == id);
                return network;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching Networks: {ex.Message}");

                throw;
            }
        }

        public async Task<Network> AddNetwork(Network network)
        {
            try
            {

                await _substituteDbContext.AddAsync(network);
                await _substituteDbContext.SaveChangesAsync();
                //await _substituteDbContextלבדוק איך רושמים שדרוג- שיחזיר את האוביט האחרון
                return network;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while adding Networks: {ex.Message}");

                throw;
            }
        }

        public async Task<List<Specialization>> GetAllSpecializations()
        {
            try
            {
                List<Specialization> result = await _substituteDbContext.Specializations.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching Specializations: {ex.Message}");

                throw;
            }
        }

        public async Task<Specialization> GetSpecializationById(int id)
        {
            try
            {
                Specialization specialization = await _substituteDbContext.Specializations.FirstOrDefaultAsync(t => t.SpecializationId == id);
                return specialization;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while fetching Specializations: {ex.Message}");

                throw;
            }
        }
        public async Task<Specialization> AddSpecialization(Specialization specialization)
        {
            try
            {

                await _substituteDbContext.AddAsync(specialization);
                await _substituteDbContext.SaveChangesAsync();
                return specialization;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while adding specialization: {ex.Message}");

                throw;
            }
        }

    }
}