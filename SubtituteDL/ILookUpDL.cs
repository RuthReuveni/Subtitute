using SubtituteDL.Models;

namespace SubtituteDL
{
    public interface ILookUpDL
    {
        Task<Network> AddNetwork(Network network);
        Task<Specialization> AddSpecialization(Specialization specialization);
        Task<List<Area>> GetAllAreas();
        Task<List<Duration>> GetAllDurations();
        Task<List<Network>> GetAllNetworks();
        Task<List<Specialization>> GetAllSpecializations();
        Task<Area> GetAreaById(int id);
        Task<Duration> GetDurationById(int id);
        Task<Network> GetNetworkById(int id);
        Task<Specialization> GetSpecializationById(int id);
    }
}