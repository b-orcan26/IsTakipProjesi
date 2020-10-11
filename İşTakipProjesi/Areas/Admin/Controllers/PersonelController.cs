using System.Collections.Generic;
using System.Linq;
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
    public class PersonelController : Controller
    {
        private readonly IUserService userManager;
        private readonly IMapper mapper;
        private readonly IRoleService roleManager;
        public PersonelController(IUserService _userManager, IMapper _mapper, IRoleService _roleManager)
        {
            userManager = _userManager;
            mapper = _mapper;
            roleManager = _roleManager;
        }

        public async Task<IActionResult> Personeller()
        {
            var users = await userManager.GetAllAsync();
            var list = mapper.Map<List<UserListDTO>>(users);
            return View(list);
        }

        [HttpGet]
        public IActionResult PersonelEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PersonelEkle(UserAddDTO model)
        {
            if (ModelState.IsValid)
            {
                var user = mapper.Map<User>(model);
                await userManager.Add(user);
                return RedirectToAction("Personeller");
            }
            return View();
        }


        public async Task<IActionResult> PersonelSil(int id)
        {
            await userManager.Delete(id);
            return RedirectToAction("Personeller");
        }

        public async Task<IActionResult> PersoneleRolAta()
        {
            var roles = await roleManager.GetAllAsync();
            ViewBag.Roller = roles.ToList();
            var users = await userManager.GetUsersWithRoles();
            return View(users);
        }
    
        public async Task<IActionResult> PersonelRolDegistir(List<UsersRoleUpdate> dtos)
        {
            await roleManager.UserAssignRole(dtos);
            return RedirectToAction("PersoneleRolAta");
        }

    }
}
