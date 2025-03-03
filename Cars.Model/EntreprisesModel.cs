namespace Cars.Model;

public class EntreprisesModel
{
    public int Entrepriseid { get; set; }
    public string Nom { get; set; }
    public bool ContratActif { get; set; }
    
    public List<VehiculesModel>? Vehicules { get; set; }
    public List<SalariesModel>? Salaries { get; set; }
}