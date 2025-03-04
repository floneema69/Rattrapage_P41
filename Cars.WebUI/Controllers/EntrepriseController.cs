using Microsoft.AspNetCore.Mvc;
using Cars.DataSource.Interfaces;
using Cars.WebUI.ViewModel;
using System.Collections.Generic;
using System.Linq;

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
                    Statut = v.statut
                }).ToList()
            }).ToList();

            return View(entrepriseViewModels);
        }
    }
}