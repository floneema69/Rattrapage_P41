namespace Cars.Model;

public class AttributionVehiculeModel
{
    public int VehiculeID { get; set; }
    public int SalarieID { get; set; }

    public VehiculesModel? Vehicule { get; set; }
    public SalariesModel? Salarie { get; set; }
}