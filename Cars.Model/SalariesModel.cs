namespace Cars.Model;

public class SalariesModel
{
    public int Salarieid { get; set; }
    public string? Nom { get; set; }
    public string? Prenom { get; set; }
    public string Email { get; set; }
    public int Entrepriseid { get; set; }
    public int? Vehiculeid { get; set; }

    public EntreprisesModel? Entreprise { get; set; }
    public VehiculesModel? Vehicule { get; set; }
}