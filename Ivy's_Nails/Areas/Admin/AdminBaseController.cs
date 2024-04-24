using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static IvysNails.Core.Constants.AdministratorConstants;

namespace IvysNails.Areas.Admin
{
    [Area(AdminAreaName)]
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {
        
    }
}
