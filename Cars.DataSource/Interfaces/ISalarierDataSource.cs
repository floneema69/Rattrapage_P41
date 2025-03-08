using Cars.Model;

namespace Cars.DataSource.Interfaces
{
    public interface ISalarierDataSource
    {
        void UpdateSalarierWithVehicule(int salarierId, int? idVehicule);
        List<SalariesModel> GetSalariesWithNoVehicule(int entrepriseId);
        SalariesModel GetSalarieByVehiculeId(int vehiculeId);

        SalariesModel GetSalarierById(int salarierId);
        
        IEnumerable<SalariesModel> GetSalariesByEntrepriseId(int entrepriseId);
    }
}