using Microsoft.AspNetCore.Mvc;
using Cars.DataSource.Interfaces;
using Cars.WebUI.ViewModel;
using System.Collections.Generic;
using System.Linq;
using Cars.Model;
using Cars.WebUI.ViewModel;
using Cars.WebUI.ViewModel.EntrepriseViewModels;
using Cars.WebUI.ViewModel.VehiculesViewModels;


namespace Cars.WebUI.Controllers
{
    public class EntrepriseController : Controller
    {
        private readonly IEntrepriseDataSource _entrepriseDataSource;

        public EntrepriseController(IEntrepriseDataSource entrepriseDataSource)
        {
            _entrepriseDataSource = entrepriseDataSource;
        }

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
                    SalarierPrenom = v.Salarie?.Prenom,
                    SalarierNom = v.Salarie?.Nom
                }).ToList()
            }).ToList();

            return View(entrepriseViewModels);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateEntrepriseViewModel());
        }

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

    }
}