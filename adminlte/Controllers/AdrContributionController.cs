using adminlte.ViewModels;
using AdrBusiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace adminlte.Controllers
{
    public class AdrContributionController : Controller
    {
        private readonly FakeParameterService parameterService;
        private readonly FakeResultService resultService;

        public AdrContributionController()
        {
            parameterService = new FakeParameterService();
            resultService = new FakeResultService();
        }

        public ActionResult Index()
        {
            var vm = new AdrContributionViewModel
            {
                SuperRegions = parameterService.GetAllSuperRegions()
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(string superRegion)
        {
            var superRegions = parameterService.GetAllSuperRegions();
            var posGroup = parameterService.GetPosGroupsBySuperRegion(superRegion);

            var vm = new AdrContributionViewModel
            {
                SuperRegions = superRegions,
                PosGroups = posGroup
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult LoadPosGroup(string selectedPosGroup)
        {
            var superRegions = parameterService.GetAllSuperRegions();
            var posGroups = parameterService.GetPosGroupsBySuperRegion(selectedPosGroup);
            var standaloneResults = resultService.GetStandaloneResults(selectedPosGroup);
            var packageResults = resultService.GetPackageResults(selectedPosGroup);


            var vm = new AdrContributionViewModel
            {
                SuperRegions = superRegions,
                PosGroups = posGroups,
                StandaloneResults = standaloneResults,
                PackageResults = packageResults
                
            };

            return View("Index", vm);
        }
    }
}