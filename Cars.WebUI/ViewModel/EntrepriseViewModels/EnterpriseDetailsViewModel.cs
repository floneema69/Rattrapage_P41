using Cars.Model;

namespace Cars.WebUI.ViewModel.EntrepriseViewModels;

public class EnterpriseDetailsViewModel
{
    public EntreprisesModel Entreprise { get; set; }
    public IEnumerable<SalariesModel> Salaries { get; set; }
    public IEnumerable<VehiculesModel> Vehicules { get; set; }
}