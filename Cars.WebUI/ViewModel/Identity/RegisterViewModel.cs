using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cars.WebUI.ViewModel.Identity;

public class RegisterViewModel
{
    public string Email { get; set; }
    public string Password { get; set; }
    public int? EntrepriseId { get; set; }
    public SelectList Entreprises { get; set; }
}