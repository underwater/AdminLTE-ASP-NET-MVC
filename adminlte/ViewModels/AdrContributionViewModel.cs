using AdrBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace adminlte.ViewModels
{
    public class AdrContributionViewModel
    {
		public string SelectedSuperRegion { get; set; }
		
        public IEnumerable<string> SuperRegions { get; set; }

	    public string SelectedPosGroup { get; set; }

        public IEnumerable<string> PosGroups { get; set; }


        public IEnumerable<StandaloneResult> StandaloneResults{ get; set; }

        public IEnumerable<PackageResult> PackageResults { get; set; }
    }
}