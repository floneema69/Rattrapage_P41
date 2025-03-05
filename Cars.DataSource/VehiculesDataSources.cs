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
    public void UpdateVehiculeStatus(int vehiculeId, bool statut)
    {
        var vehicule = _context.Vehicules.Find(vehiculeId);
        if (vehicule != null)
        {
            vehicule.statut = statut;
            _context.SaveChanges();
        }
    }
    public VehiculesModel GetVehiculeById(int vehiculeId)
    {
        return _context.Vehicules.Find(vehiculeId);
    }
}