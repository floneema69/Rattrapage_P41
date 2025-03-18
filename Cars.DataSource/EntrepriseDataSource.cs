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
        public List<EntreprisesModel> ListerEntreprises()
        {
            return _context.Entreprises
                .Include(e => e.Vehicules)
                .ThenInclude(v => v.Salarie)
                .ToList();
        }
        public List<EntreprisesModel> ListerEntreprisesAvecContrat()
        {
            return _context.Entreprises
                .Where(e => e.ContratActif)
                .Include(e => e.Vehicules)
                .ThenInclude(v => v.Salarie)
                .ToList();
        }
        public void CreateEntreprise(EntreprisesModel entreprise)
        {
            _context.Entreprises.Add(entreprise);
            _context.SaveChanges();
        }
        public EntreprisesModel GetEntrepriseById(int entrepriseId)
        {
            return _context.Entreprises
                .Include(e => e.Vehicules)
                .ThenInclude(v => v.Salarie)
                .FirstOrDefault(e => e.Entrepriseid == entrepriseId);
        }
        public void UpdateEntreprise(EntreprisesModel entreprise)
        {
            var existingEntreprise = _context.Entreprises.Find(entreprise.Entrepriseid);
            if (existingEntreprise != null)
            {
                existingEntreprise.Nom = entreprise.Nom;
                existingEntreprise.ContratActif = entreprise.ContratActif;
                _context.SaveChanges();
            }
        }
        public void DeleteEntreprise(int entrepriseId)
        {
            var entreprise = _context.Entreprises.Find(entrepriseId);
            if (entreprise != null)
            {
                _context.Entreprises.Remove(entreprise);
                _context.SaveChanges();
            }
        }
    }
}