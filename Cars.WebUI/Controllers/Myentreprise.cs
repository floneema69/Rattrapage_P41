using Microsoft.AspNetCore.Mvc;
using Cars.DataSource.Interfaces;
using Cars.WebUI.ViewModel;
using Cars.WebUI.ViewModel.EntrepriseViewModels;

namespace Cars.WebUI.Controllers
{
    public class Myentreprise : Controller
    {
        private readonly IEntrepriseDataSource _entrepriseDataSource;
        private readonly ISalarierDataSource _salarierDataSource;
        private readonly IVehiculesDataSource _vehiculesDataSource;

        public Myentreprise(IEntrepriseDataSource entrepriseDataSource, ISalarierDataSource salarierDataSource, IVehiculesDataSource vehiculesDataSource)
        {
            _entrepriseDataSource = entrepriseDataSource;
            _salarierDataSource = salarierDataSource;
            _vehiculesDataSource = vehiculesDataSource;
        }

        public async Task<IActionResult> EnterpriseDetails()
        {
            var entrepriseId = HttpContext.Session.GetInt32("EntrepriseId");
            if (entrepriseId == null || entrepriseId == 0)
            {
                return NotFound("Enterprise not found.");
            }

            var entreprise = _entrepriseDataSource.GetEntrepriseById(entrepriseId.Value);
            var salaries = _salarierDataSource.GetSalariesByEntrepriseId(entrepriseId.Value);
            var vehicules = _vehiculesDataSource.GetVehiculesByEntrepriseId(entrepriseId.Value);

            var model = new EnterpriseDetailsViewModel
            {
                Entreprise = entreprise,
                Salaries = salaries,
                Vehicules = vehicules
            };

            return View(model);
        }
    }
}