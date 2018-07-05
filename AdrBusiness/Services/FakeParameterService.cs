using AdrBusiness.Model;
using AdrData.Entities;
using AdrData.Repositories;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdrBusiness.Services
{

    public class FakeParameterService 
    {
        private readonly FakePosRepository posRepository;

        public FakeParameterService()
        {
            posRepository = new FakePosRepository();
        }

        public IEnumerable<string> GetAllSuperRegions()
        {
            var result = posRepository.GetAllPosMappings()
                .Select(x => x.SuperRegion)
                .Distinct();

            return result;
        }

        public IEnumerable<string> GetPosGroupsBySuperRegion(string superRegion)
        {
            var result = posRepository.GetAllPosMappings()
                .Where(x => x.SuperRegion == superRegion)
                .Select(x => x.PosGroup)
                .Distinct();

            return result;
        }
  
    }
}
