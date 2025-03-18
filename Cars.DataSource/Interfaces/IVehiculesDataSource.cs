using Cars.Model;

namespace Cars.DataSource.Interfaces;

public interface IVehiculesDataSource
{
    void CreateVehicule(VehiculesModel vehicule);
    void UpdateVehiculeStatus(int vehiculeId, bool statut, string description);
    VehiculesModel GetVehiculeById(int vehiculeId);
    IEnumerable<VehiculesModel> GetVehiculesByEntrepriseId(int entrepriseId);
    void DeleteVehicule(int vehiculeId);
    void UpdateVehicule(VehiculesModel vehicule);


}