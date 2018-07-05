using AdrBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdrBusiness.Services
{
    public class FakeResultService
    {
        public IEnumerable<StandaloneResult> GetStandaloneResults(string superRegion)
        {
            var result = new List<StandaloneResult>
            {
                new StandaloneResult{Month="Jan-18", Adr=120M, Adjustment = 0.01M},
                new StandaloneResult{Month="Feb-18", Adr=135M, Adjustment = 0.02M},
                new StandaloneResult{Month="Mar-18", Adr=140M, Adjustment = 0.03M},
            };

            return result;
        }

        public IEnumerable<PackageResult> GetPackageResults(string superRegion)
        {
            var result = new List<PackageResult>
            {
                new PackageResult{Month="Jan-18", Adr=210M, Adjustment = 0.04M},
                new PackageResult{Month="Feb-18", Adr=215M, Adjustment = 0.04M},
                new PackageResult{Month="Mar-18", Adr=210M, Adjustment = 0.03M},
            };

            return result;
        }
    }
}
