namespace Cars.Model;

public class VehiculesModel
{
    public int Vehiculeid { get; set; }
    public int EntrepriseID { get; set; }
    public string Nom { get; set; }
    public string Marque { get; set; }
    public string Modele { get; set; }
    public string Immatriculation { get; set; }
    public bool statut { get; set; }
    
    public string? description { get; set; }
    
    public EntreprisesModel? Entreprise { get; set; }
    
    public SalariesModel? Salarie { get; set; }
}