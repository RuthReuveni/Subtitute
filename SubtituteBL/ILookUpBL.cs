using SubtituteDL.Models;
using SubtituteDTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteBL
{
    public interface ILookUpBL
    {
        Task<NetworkDTO> AddNetwork(NetworkDTO networkDTO);
        Task<SpecializationDTO> AddSpecialization(SpecializationDTO specializationDTO);
        Task<List<AreaDTO>> GetAllAreas();
        Task<List<DurationDTO>> GetAllDurations();
        Task<List<NetworkDTO>> GetAllNetworks();
        Task<List<SpecializationDTO>> GetAllSpecializations();
        Task<AreaDTO> GetAreaById(int id);
        Task<DurationDTO> GetDurationById(int id);
        Task<NetworkDTO> GetNetworkById(int id);
        Task<SpecializationDTO> GetSpecializationById(int id);
    }
}
