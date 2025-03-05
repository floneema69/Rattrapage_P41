using Cars.DataContext;
using Cars.DataSource.Interfaces;
using Cars.Model;
using Microsoft.EntityFrameworkCore;

namespace Cars.DataSource
{
    public class SalarierDataSources : ISalarierDataSource
    {
        private readonly MainDbContext _context;

        public SalarierDataSources(MainDbContext context)
        {
            _context = context;
        }

        public void UpdateSalarierWithVehicule(int salarierId, int? idVehicule)
        {
            var salarier = _context.Salaries.FirstOrDefault(s => s.Salarieid == salarierId);
            if (salarier != null)
            {
                salarier.Vehiculeid = idVehicule;
                _context.SaveChanges();
            }
        }
        public List<SalariesModel> GetSalariesWithNoVehicule(int entrepriseId)
        {
            return _context.Salaries
                .Where(s => s.Vehiculeid == null && s.Entrepriseid == entrepriseId)
                .ToList();
        }
        public SalariesModel GetSalarieByVehiculeId(int vehiculeId)
        {
            return _context.Salaries.FirstOrDefault(s => s.Vehiculeid == vehiculeId);
        }
    }
}