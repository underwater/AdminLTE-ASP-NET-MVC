using AdrBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace adminlte.ViewModels
{
    public class AdrContributionViewModel
    {
        public IEnumerable<string> SuperRegions { get; set; }
        public IEnumerable<string> PosGroups { get; set; }
        public IEnumerable<StandaloneResult> StandaloneResults{ get; set; }
        public IEnumerable<PackageResult> PackageResults { get; set; }
    }
}