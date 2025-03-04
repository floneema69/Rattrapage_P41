using Cars.DataContext;
using Cars.DataSource.Interfaces;
using Cars.Model;
using Microsoft.EntityFrameworkCore;

namespace Cars.DataSource
{
    public class EntrepriseDataSource : IEntrepriseDataSource
    {
        private readonly MainDbContext _context;

        public EntrepriseDataSource(MainDbContext context)
        {
            _context = context;
        }

        public List<EntreprisesModel> ListerEntreprisesAvecContrat()
        {
            return _context.Entreprises
                .Where(e => e.ContratActif)
                .Include(e => e.Vehicules)
                .ToList();
        }
    }
}