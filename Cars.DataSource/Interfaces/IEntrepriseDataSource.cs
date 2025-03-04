using Cars.Model;

namespace Cars.DataSource.Interfaces;

public interface IEntrepriseDataSource
{
    List<EntreprisesModel> ListerEntreprisesAvecContrat();
    void CreateEntreprise(EntreprisesModel entreprise);
    
}