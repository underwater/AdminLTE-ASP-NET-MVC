﻿using AdrData.Repositories;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdrBusiness.Services
{

    public class FakePosService 
    {
        private readonly FakePosRepository repository;

        public FakePosService()
        {
            repository = new FakePosRepository();
        }

        public IEnumerable<string> GetAllSuperRegions()
        {
            var result = repository.GetAllPosMappings()
                .Select(x => x.SuperRegion)
                .Distinct();

            return result;
        }

        public IEnumerable<string> GetPosGroupsBySuperRegion(string superRegion)
        {
            var result = repository.GetAllPosMappings()
                .Where(x => x.SuperRegion == superRegion)
                .Select(x => x.PosGroup)
                .Distinct();

            return result;
        }
    }
}
