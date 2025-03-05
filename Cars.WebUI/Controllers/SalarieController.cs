using Cars.DataSource.Interfaces;
using Cars.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cars.WebUI.Controllers
{
    public class SalarieController : Controller
    {
        private readonly ISalarierDataSource _salarierDataSource;
        private readonly IVehiculesDataSource _vehiculesDataSource;

        public SalarieController(ISalarierDataSource salarierDataSource, IVehiculesDataSource vehiculeDataSource)
        {
            _salarierDataSource = salarierDataSource;
            _vehiculesDataSource = vehiculeDataSource;
        }

        [HttpGet]
        public IActionResult Assign(int idEntreprise, int idVehicule)
        {
            var vehicule = _vehiculesDataSource.GetVehiculeById(idVehicule);
            if (vehicule == null || !vehicule.statut)
            {
                return RedirectToAction("Index", "Entreprise");
            }

            var viewModel = new AssignSalarieViewModel
            {
                IdEntreprise = idEntreprise,
                IdVehicule = idVehicule,
                Salaries = _salarierDataSource.GetSalariesWithNoVehicule(idEntreprise)
                    .Select(s => new SelectListItem
                    {
                        Value = s.Salarieid.ToString(),
                        Text = $"{s.Prenom} {s.Nom}"
                    })
                    .ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Assign(AssignSalarieViewModel model)
        {
            
                _salarierDataSource.UpdateSalarierWithVehicule(model.SelectedSalarieId, model.IdVehicule);
                return RedirectToAction("Index", "Entreprise");
            

            return View(model);
        }
    }
}