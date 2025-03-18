using Cars.DataSource.Interfaces;
using Cars.Model;
using Cars.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Cars.WebUI.ViewModel.VehiculesViewModels;

namespace Cars.WebUI.Controllers
{
    public class VehiculeController : Controller
    {
        private readonly IVehiculesDataSource _vehiculeDataSource;
        private readonly ISalarierDataSource _salarierDataSource;

        public VehiculeController(IVehiculesDataSource vehiculeDataSource, ISalarierDataSource salarierDataSource)
        {
            _vehiculeDataSource = vehiculeDataSource;
            _salarierDataSource = salarierDataSource;
        }
     

        [HttpGet]
        public IActionResult Create(int idEntreprise)
        {
            var viewModel = new CreateVehiculeViewModel
            {
                Vehicule = new VehiculesViewModel
                {
                    EntrepriseID = idEntreprise
                }
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateVehiculeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var vehicule = new VehiculesModel
                {
                    EntrepriseID = viewModel.Vehicule.EntrepriseID,
                    Nom = viewModel.Vehicule.Nom,
                    Marque = viewModel.Vehicule.Marque,
                    Modele = viewModel.Vehicule.Modele,
                    Immatriculation = viewModel.Vehicule.Immatriculation,
                    statut = viewModel.Vehicule.Statut,
                    description = viewModel.Vehicule.Description
                };

                _vehiculeDataSource.CreateVehicule(vehicule);
                return RedirectToAction("Index", "Entreprise");
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult UpdateStatus(int id)
        {
            var vehicule = _vehiculeDataSource.GetVehiculeById(id);
            if (vehicule == null)
            {
                return NotFound();
            }

            var viewModel = new UpdateVehiculeStatusViewModel
            {
                VehiculeId = vehicule.Vehiculeid,
                Status = vehicule.statut
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult UpdateStatus(UpdateVehiculeStatusViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!model.Status)
                {
                    var salarie = _salarierDataSource.GetSalarieByVehiculeId(model.VehiculeId);
                    if (salarie != null)
                    {
                        _salarierDataSource.UpdateSalarierWithVehicule(salarie.Salarieid, null);
                    }
                }

                _vehiculeDataSource.UpdateVehiculeStatus(model.VehiculeId, model.Status,model.Description);
                return RedirectToAction("Index", "Entreprise");
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var vehicule = _vehiculeDataSource.GetVehiculeById(id);
            if (vehicule == null)
            {
                return NotFound();
            }

            var salarie = _salarierDataSource.GetSalarieByVehiculeId(id);
            if (salarie != null)
            {
                _salarierDataSource.UpdateSalarierWithVehicule(salarie.Salarieid, null);
            }

            _vehiculeDataSource.DeleteVehicule(id);

            return RedirectToAction("Index", "Entreprise");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var vehicule = _vehiculeDataSource.GetVehiculeById(id);
            if (vehicule == null)
            {
                return NotFound();
            }

            var viewModel = new EditVehiculeViewModel
            {
                VehiculeId = vehicule.Vehiculeid,
                Nom = vehicule.Nom,
                Marque = vehicule.Marque,
                Modele = vehicule.Modele,
                Immatriculation = vehicule.Immatriculation,
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(EditVehiculeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                
                var vehicule = _vehiculeDataSource.GetVehiculeById(viewModel.VehiculeId);
                if (vehicule == null)
                {
                    return NotFound();
                }

                vehicule.Nom = viewModel.Nom;
                vehicule.Marque = viewModel.Marque;
                vehicule.Modele = viewModel.Modele;
                vehicule.Immatriculation = viewModel.Immatriculation;

                _vehiculeDataSource.UpdateVehicule(vehicule);

                return RedirectToAction("Index", "Entreprise");
            }

            return View(viewModel);
        }
    }
}