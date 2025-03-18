using Cars.DataContext;
using Cars.DataSource.Interfaces;
using Cars.Model;

namespace Cars.DataSource;

public class VehiculesDataSources : IVehiculesDataSource
{
    private readonly MainDbContext _context;

    public VehiculesDataSources(MainDbContext context)
    {
        _context = context;
    }
    public void CreateVehicule(VehiculesModel vehicule)
    {
        _context.Vehicules.Add(vehicule);
        _context.SaveChanges();
    }
    public void UpdateVehiculeStatus(int vehiculeId, bool statut, string description)
    {
        var vehicule = _context.Vehicules.Find(vehiculeId);
        if (vehicule != null)
        {
            vehicule.statut = statut;
            vehicule.description = description;
            _context.SaveChanges();
        }
    }
    public VehiculesModel GetVehiculeById(int vehiculeId)
    {
        return _context.Vehicules.Find(vehiculeId);
    }
    public IEnumerable<VehiculesModel> GetVehiculesByEntrepriseId(int entrepriseId)
    {
        return _context.Vehicules
            .Where(v => v.EntrepriseID == entrepriseId)
            .ToList();
    }
    public void DeleteVehicule(int vehiculeId)
    {
        var vehicule = _context.Vehicules.Find(vehiculeId);
        if (vehicule != null)
        {
            _context.Vehicules.Remove(vehicule);
            _context.SaveChanges();
        }
    }
    public void UpdateVehicule(VehiculesModel vehicule)
    {
        _context.Vehicules.Update(vehicule);
        _context.SaveChanges();
    }
}