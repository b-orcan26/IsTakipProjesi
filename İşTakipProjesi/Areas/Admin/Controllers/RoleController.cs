using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using DTO;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace İşTakipProjesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class RoleController : Controller
    {
        private readonly IRoleService rolManager;
        private readonly IUserService userManager;
        private readonly IMapper mapper;
        public RoleController(IRoleService _rolManager , IMapper _mapper , IUserService _userManager)
        {
            rolManager = _rolManager;
            mapper = _mapper;
            userManager = _userManager;
        }

        public async Task<IActionResult> Roller()
        {
            var roller = await rolManager.GetAllAsync();            
            return View(roller);
        }

        public IActionResult RolEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RolEkle(RolEkleDTO model)
        {
            if (ModelState.IsValid)
            {
                var role = mapper.Map<Role>(model);
                await rolManager.Add(role);
            }
            return View();
        }

        public async Task<IActionResult> RolSil(int id)
        {
            await rolManager.Delete(id);
            return View();
        }

        public async Task<IActionResult> RolGuncelle(int id)
        {
            var role = await rolManager.Get(id);
            var model = mapper.Map<RolGuncelleDTO>(role);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RolGuncelle(RolGuncelleDTO model)
        {
            if (ModelState.IsValid)
            {
                var role = await rolManager.Get(model.Id);
                if (role != null)
                {
                    role = mapper.Map<Role>(model);
                    await rolManager.Update(role);
                    return RedirectToAction("Roller");
                }
            }            
            return View(model);
        }

    }
}
