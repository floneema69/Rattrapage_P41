using Microsoft.AspNetCore.Identity;

namespace Cars.Model.Identity;

public class User : IdentityUser
{
    public override string Email { get; set; }
    public override string PasswordHash { get; set; }
    public int? EntrepriseId { get; set; }
    public EntreprisesModel Entreprise { get; set; }
}