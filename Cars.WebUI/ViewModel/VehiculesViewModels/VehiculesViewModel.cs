namespace Cars.WebUI.ViewModel.VehiculesViewModels
{
    public class VehiculesViewModel
    {
        public int VehiculeId { get; set; }
        public int EntrepriseID { get; set; }
        public string Nom { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string Immatriculation { get; set; }
        public bool Statut { get; set; }
        public string? SalarierPrenom { get; set; }
        public string? SalarierNom { get; set; }
        
        public string? Description { get; set; }
        public string SalarieNomComplet => $"{SalarierPrenom} {SalarierNom}".Trim();
    }

}