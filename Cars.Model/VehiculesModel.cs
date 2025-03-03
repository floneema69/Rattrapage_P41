namespace Cars.Model;

public class VehiculesModel
{
    public int Vehiculeid { get; set; }
    public int EntrepriseID { get; set; }
    public string Nom { get; set; }
    public string Marque { get; set; }
    public string Modele { get; set; }
    public string Immatriculation { get; set; }
    public string statut { get; set; }
    
    public EntreprisesModel? Entreprise { get; set; }
    public List<AttributionVehiculeModel>? AttributionVehicules { get; set; }
}