using Cars.DataSource.Interfaces;
using Cars.WebUI.ViewModel.EntrepriseViewModels;
using Cars.WebUI.ViewModel.VehiculesViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cars.WebUI.Controllers;

public class StatistiqueController : Controller
{
    private readonly IEntrepriseDataSource _entrepriseDataSource;

    public StatistiqueController(IEntrepriseDataSource entrepriseDataSource)
    {
        _entrepriseDataSource = entrepriseDataSource;
    }
    [Authorize(Roles = "Admin")]

    public IActionResult Index()
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
                SalarierPrenom = v.Salarie?.Prenom,
                SalarierNom = v.Salarie?.Nom
            }).ToList()
        }).ToList();

        return View(entrepriseViewModels);
    }
}