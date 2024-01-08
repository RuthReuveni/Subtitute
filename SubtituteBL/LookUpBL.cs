using AutoMapper;
using SubtituteDTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteBL
{
    public class LookUpBL:ILookUpBL
    {
        private IMapper mapper;

        public Task<NetworkDTO> AddNetwork(NetworkDTO networkDTO)
        {
            throw new NotImplementedException();
        }

        public Task<SpecializationDTO> AddSpecialization(SpecializationDTO specializationDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<AreaDTO>> GetAllAreas()
        {
            throw new NotImplementedException();
        }

        public Task<List<DurationDTO>> GetAllDurations()
        {
            throw new NotImplementedException();
        }

        public Task<List<NetworkDTO>> GetAllNetworks()
        {
            throw new NotImplementedException();
        }

        public Task<List<SpecializationDTO>> GetAllSpecializations()
        {
            throw new NotImplementedException();
        }

        public Task<AreaDTO> GetAreaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DurationDTO> GetDurationById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<NetworkDTO> GetNetworkById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SpecializationDTO> GetSpecializationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
