using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using DTO;
using Entities;
using İşTakipProjesi.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace İşTakipProjesi.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class GorevController : Controller
    {
        private readonly IGorevService gorevManager;
        private readonly IUserService userManager;
        private readonly IMapper mapper;
        private readonly IRaporService raporManager;
        public GorevController(IGorevService _gorevService , IMapper _mapper, IUserService _userManager , IRaporService _raporManager)
        {
            gorevManager = _gorevService;
            mapper = _mapper;
            userManager = _userManager;
            raporManager = _raporManager;
        }

        public async Task<IActionResult> Gorevler()
        {
            var liste = await gorevManager.GetAllWithIncludedElementsAsync();
            var gorevler = mapper.Map<IEnumerable<GorevListDTO>>(liste);
            var gorevList = gorevler.ToList();
            return View(gorevList);
        }

        public IActionResult GorevEkle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GorevEkle(GorevEkleDTO model)
        {
            if (ModelState.IsValid)
            {
                var gorev = mapper.Map<Gorev>(model);
                await gorevManager.Add(gorev);
                return RedirectToAction("Gorevler");
            }
            return View(model);
        }


        public async Task<IActionResult> GorevDuzenle(int id)
        {
            var gorev = await gorevManager.Get(id);
            var gorevUpdateModel = mapper.Map<GorevGuncelleDTO>(gorev);
            return View(gorevUpdateModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GorevDuzenle(GorevGuncelleDTO model)
        {
            if (ModelState.IsValid)
            {
                var gorev = await gorevManager.Get(model.Id);

                if (gorev != null)
                {
                    gorev.Tanim = model.Tanim;
                    gorev.Aciklama = model.Aciklama;
                    await gorevManager.Update(gorev);
                    return RedirectToAction("Gorevler");
                }
            }
            return View(model);
        }

        public async Task<IActionResult> GorevSil(int id)
        {
            await gorevManager.Delete(id);
            return RedirectToAction("Gorevler");
        }


        [HttpGet]
        public async Task<IActionResult> PersonelAta(int id)
        {
            var users = await userManager.GetAllAsync();
            var gorev = await gorevManager.Get(id);
            GorevUsersVM vm = new GorevUsersVM()
            {
                gorev = gorev,
                users = users.ToList()
            };
            return View(vm);            
        }
        
        [HttpPost]
        public async Task<JsonResult> PersonelAta(int gorevId , int userId)
        {
            if (ModelState.IsValid)
            {
                var gorev = await gorevManager.Get(gorevId);
                if (gorev != null && gorev.UserId == 0)
                {
                    gorev.UserId = userId;
                    await gorevManager.Update(gorev);
                    return Json(new { success = true});
                }
            }
            return Json(new { success = false });
        }

        public async Task<IActionResult> Raporlar(int id)
        {
            var rapors = await raporManager.RaporsByGorevId(id);
            var dtoList = mapper.Map<List<RaporListDTO>>(rapors);
            return View(dtoList);
        }

        public async Task<IActionResult> GorevTamamla(int id)
        {
            var gorev = await gorevManager.Get(id);
            gorev.Durum = true;
            await gorevManager.Update(gorev);
            return RedirectToAction("Gorevler");
        }

    }
}
