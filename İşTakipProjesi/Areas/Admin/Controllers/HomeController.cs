using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using İşTakipProjesi.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace İşTakipProjesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {

        private readonly IGorevService gorevManager;
        private readonly IRaporService raporManager;
        public HomeController(IGorevService _gorevManager , IRaporService _raporManager)
        {
            gorevManager = _gorevManager;
            raporManager = _raporManager;
        }

        public async Task<IActionResult> Index()
        {
            var gorevs = await gorevManager.GetAllAsync();
            var rapors = await raporManager.GetAllAsync();
            var vm = new RaporGorevIstatistikVM()
            {
                gorevs = gorevs.ToList(),
                rapors = rapors.ToList()
            };
            return View(vm) ;
        }


    }


}
