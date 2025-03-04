namespace Cars.WebUI.ViewModel
{
    public class EntrepriseViewModel
    {
        public int EntrepriseId { get; set; }
        public string Nom { get; set; }
        public bool ContratActif { get; set; }
        
        public List<VehiculesViewModel>? Vehicules { get; set; }
    }
}