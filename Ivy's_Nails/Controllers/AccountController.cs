using IvysNails.Core.Models.ViewModels;
using IvysNails.Infrastructure.Data;
using IvysNails.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IvysNails.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IvyNailsDbContext _dbContext; 

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IvyNailsDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = dbContext;
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var fullName = $"{model.FirstName} {model.LastName}";
                    var customer = new Customer { CustomerName = fullName };
                    _dbContext.Customers.Add(customer);
                    await _dbContext.SaveChangesAsync();

                    
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }
    }
}
