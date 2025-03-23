using Microsoft.AspNetCore.Mvc;
using Cars.DataSource.Interfaces;
using Cars.WebUI.ViewModel;
using System.Collections.Generic;
using System.Linq;
using Cars.Model;
using Cars.WebUI.ViewModel;
using Cars.WebUI.ViewModel.EntrepriseViewModels;
using Cars.WebUI.ViewModel.VehiculesViewModels;
using Microsoft.AspNetCore.Authorization;


namespace Cars.WebUI.Controllers
{
    public class EntrepriseController : Controller
    {
        private readonly IEntrepriseDataSource _entrepriseDataSource;

        public EntrepriseController(IEntrepriseDataSource entrepriseDataSource)
        {
            _entrepriseDataSource = entrepriseDataSource;
        }

        [Authorize(Roles = "Admin")]

        public IActionResult Index()
        {
            var entreprises = _entrepriseDataSource.ListerEntreprisesAvecContrat();
            var entrepriseViewModels = entreprises.Select(e => new EntrepriseViewModel
            {
                EntrepriseId = e.Entrepriseid,
                Nom = e.Nom,
                ContratActif = e.ContratActif,
                Vehicules = e.Vehicules?.Select(v => new VehiculesViewModel
                {
                    VehiculeId = v.Vehiculeid,
                    EntrepriseID = v.EntrepriseID,
                    Nom = v.Nom,
                    Marque = v.Marque,
                    Modele = v.Modele,
                    Immatriculation = v.Immatriculation,
                    Statut = v.statut,
                    Description = v.description,
                    SalarierPrenom = v.Salarie?.Prenom,
                    SalarierNom = v.Salarie?.Nom
                }).ToList()
            }).ToList();

            return View(entrepriseViewModels);
        }
        [Authorize(Roles = "Admin")]

        [HttpGet]
        public IActionResult Allentreprise()
        {
            var entreprises = _entrepriseDataSource.ListerEntreprises();
            var entrepriseViewModels = entreprises.Select(e => new EntrepriseViewModel
            {
                EntrepriseId = e.Entrepriseid,
                Nom = e.Nom,
                ContratActif = e.ContratActif,
                Vehicules = e.Vehicules?.Select(v => new VehiculesViewModel
                {
                    VehiculeId = v.Vehiculeid,
                    EntrepriseID = v.EntrepriseID,
                    Nom = v.Nom,
                    Marque = v.Marque,
                    Modele = v.Modele,
                    Immatriculation = v.Immatriculation,
                    Statut = v.statut,
                    Description = v.description,
                    SalarierPrenom = v.Salarie?.Prenom,
                    SalarierNom = v.Salarie?.Nom
                }).ToList()
            }).ToList();

            return View(entrepriseViewModels);
        }
        [Authorize(Roles = "Admin")]

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateEntrepriseViewModel());
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        public IActionResult Create(CreateEntrepriseViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var entreprise = new EntreprisesModel
            {
                Nom = viewModel.Nom,
                ContratActif = viewModel.ContratActif
            };

            _entrepriseDataSource.CreateEntreprise(entreprise);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var entreprise = _entrepriseDataSource.GetEntrepriseById(id);
            if (entreprise == null)
            {
                return NotFound();
            }

            var model = new EditEntrepriseViewModel
            {
                EntrepriseId = entreprise.Entrepriseid,
                Nom = entreprise.Nom,
                ContratActif = entreprise.ContratActif
            };

            return View(model);
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        public IActionResult Edit(EditEntrepriseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entreprise = _entrepriseDataSource.GetEntrepriseById(model.EntrepriseId);
                if (entreprise == null)
                {
                    return NotFound();
                }

                entreprise.Nom = model.Nom;
                entreprise.ContratActif = model.ContratActif;

                _entrepriseDataSource.UpdateEntreprise(entreprise);

                return RedirectToAction("Index");
            }

            return View(model);
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var entreprise = _entrepriseDataSource.GetEntrepriseById(id);
            if (entreprise == null)
            {
                return NotFound();
            }

            _entrepriseDataSource.DeleteEntreprise(id);

            return RedirectToAction("Index");
        }
        

    }
}