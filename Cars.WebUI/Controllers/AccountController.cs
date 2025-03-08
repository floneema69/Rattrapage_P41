using Cars.Model.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Cars.DataSource.Interfaces;
using Cars.WebUI.ViewModel.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cars.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEntrepriseDataSource _entrepriseDataSource;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEntrepriseDataSource entrepriseDataSource)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _entrepriseDataSource = entrepriseDataSource;
        }


        [HttpGet]
        [HttpGet]
        [HttpGet]
        public IActionResult Register()
        {
            var model = new RegisterViewModel
            {
                Entreprises = new SelectList(_entrepriseDataSource.ListerEntreprisesAvecContrat(), "Entrepriseid", "Nom")
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            
                var user = new User { UserName = model.Email, Email = model.Email, EntrepriseId = model.EntrepriseId };
                var result = await _userManager.CreateAsync(user, model.Password);
               
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Entreprise");
               
            
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(email, password, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(email);
                    if (user != null) HttpContext.Session.SetInt32("EntrepriseId", user.EntrepriseId ?? 0);
                    if (user != null)
                    {
                        if (await _userManager.IsInRoleAsync(user, "Admin"))
                        {
                            return RedirectToAction("Index", "Entreprise");
                        }
                        else if (await _userManager.IsInRoleAsync(user, "Client"))
                        {
                            HttpContext.Session.SetInt32("EntrepriseId", user.EntrepriseId ?? 0);
                            return RedirectToAction("EnterpriseDetails", "Myentreprise");
                        }
                    }
                }
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}