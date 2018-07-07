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
        public ActionResult Index(AdrContributionViewModel viewModel, string submitType)
        {
	        if (submitType == Constants.LoadPosGroups)
	        {
		        var posGroups = parameterService.GetPosGroupsBySuperRegion(viewModel.SelectedSuperRegion);
		        viewModel.PosGroups = posGroups;
	        }

	        if (submitType == Constants.LoadResults)
	        {
		        var standaloneResults = resultService.GetStandaloneResults(viewModel.SelectedPosGroup);
		        var packageResults = resultService.GetPackageResults(viewModel.SelectedPosGroup);

		        viewModel.StandaloneResults = standaloneResults;
		        viewModel.PackageResults = packageResults;
	        }

			return View(viewModel);
        }
    }
}