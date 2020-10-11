using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using DTO;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace İşTakipProjesi.Areas.Personel.Controllers
{
    [Area("Personel")]
    [Authorize(Roles ="Member")]
    public class RaporController : Controller
    {
        private readonly IRaporService raporManager;
        private readonly IGorevService gorevManager;
        private readonly IMapper mapper;
        private readonly IUserService userManager;
        public RaporController(IRaporService _raporManager , IMapper _mapper , IGorevService _gorevManager , IUserService _userManager)
        {
            raporManager = _raporManager;
            gorevManager = _gorevManager;
            mapper = _mapper;
            userManager = _userManager;
        }

        public async Task<IActionResult> Raporlar()
        {
            var username = User.Identity.Name;
            var user = await userManager.GetUserByUsername(username);
            var rapors = await raporManager.RaporsByUserId(user.Id);
            var model = mapper.Map<List<RaporListDTO>>(rapors);
            return View(model);
        }

        public async Task<IActionResult> GorevRaporlari(int id)
        {
            var rapors = await raporManager.RaporsByGorevId(id);
            var dtoList = mapper.Map<List<RaporListDTO>>(rapors);
            return View(dtoList);
        }

        public async Task<IActionResult> RaporGuncelle(int id)
        {
            var rapor = await raporManager.Get(id);
            var model = mapper.Map<RaporUpdateDTO>(rapor);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RaporGuncelle(RaporUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                var rapor = mapper.Map<Rapor>(model);
                await raporManager.Update(rapor);
                return RedirectToAction("Raporlar");
            }
            return View(model);
        }

        public async Task<IActionResult> RaporSil(int id)
        {
            await raporManager.Delete(id);
            return RedirectToAction("Raporlar");
        }

        public async Task<IActionResult> RaporEkle()
        {
            var user = await userManager.GetUserByUsername(User.Identity.Name);
            var liste = await gorevManager.GetAllWithIncludedElementsAsync(user.Id);
            var gorevler = mapper.Map<IEnumerable<GorevListDTO>>(liste);
            var gorevList = gorevler.Where(i=>i.Durum==false).ToList();
            return View(gorevList);

        }

        [HttpPost]        
        public async Task<IActionResult> RaporEkle(RaporAddDTO model)
        {
            if (ModelState.IsValid && model.GorevId!=null && model.GorevId !=0)
            {
                var rapor = mapper.Map<Rapor>(model);
                await raporManager.Add(rapor);
                return RedirectToAction("GorevRaporlari", new { id = model.GorevId });
            }
            return View(model);
        }



    }
}
