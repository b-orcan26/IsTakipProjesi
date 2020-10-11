using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace İşTakipProjesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class RaporController : Controller
    {
        private readonly IRaporService raporManager;
        public RaporController(IRaporService _raporManager)
        {
            raporManager = _raporManager;
        }

        public async Task<IActionResult> Raporlar()
        {
            var rapors = await raporManager.GetAllWithIncludedElementsAsync();
            return View(rapors);
        }

        public async Task<IActionResult> OkunmamisRaporlar()
        {
            var rapors = await raporManager.GetAllWithIncludedElementsAsync();
            return View(rapors.Where(i=>i.Okundumu==false).ToList());
        }

        public async Task<IActionResult> OkunmusRaporlar()
        {
            var rapors = await raporManager.GetAllWithIncludedElementsAsync();
            return View(rapors.Where(i => i.Okundumu == true).ToList());
        }

        public async Task<IActionResult> OkunduOlarakIsaretle(int id)
        {
            var rapor = await raporManager.Get(id);

            if (rapor != null)
            {
                Rapor r = new Rapor()
                {
                    Id = id,
                    Okundumu = true
                };
                await raporManager.Update(r);
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}
