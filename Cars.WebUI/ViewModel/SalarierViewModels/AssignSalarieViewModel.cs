using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cars.WebUI.ViewModel
{
    public class AssignSalarieViewModel
    {
        public int IdEntreprise { get; set; }
        public int IdVehicule { get; set; }
        public int SelectedSalarieId { get; set; }
        public List<SelectListItem> Salaries { get; set; }
    }
}