using Cars.Model;

namespace Cars.DataSource.Interfaces;

public interface IEntrepriseDataSource
{
    List<EntreprisesModel> ListerEntreprisesAvecContrat();
    List<EntreprisesModel> ListerEntreprises();
    void CreateEntreprise(EntreprisesModel entreprise);
    
    EntreprisesModel GetEntrepriseById(int entrepriseId);
    
}