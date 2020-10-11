using System;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using DTO;
using Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace İşTakipProjesi.Areas.Personel.Controllers
{
    [Area("Personel")]
    [Authorize(Roles ="Member")]
    public class ProfilController : Controller
    {
        private readonly IUserService userManager;
        private readonly IMapper mapper;

        public ProfilController(IUserService _userManager , IMapper _mapper)
        {
            userManager = _userManager;
            mapper = _mapper;
        }

        public async Task<IActionResult> Profilim()
        {
            var user = await userManager.GetUserByUsername(User.Identity.Name);
            var model = mapper.Map<UserListDTO>(user);
            return View(model);
        }

        public async Task<IActionResult> ProfilGuncelle()
        {
            var username = User.Identity.Name;
            var user = await userManager.GetUserByUsername(username);
            var model = mapper.Map<UserUpdateDTO>(user);
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> ProfilGuncelle(UserUpdateDTO model , IFormFile Resim)
        {
            if (ModelState.IsValid && model.Id != 0)
            {
                var user = mapper.Map<User>(model);

                if (Resim != null)
                {

                    var baseImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/");
                    if (user.ResimUrl != null)
                    {
                        var oldImagePath = Path.Combine(baseImagePath, user.ResimUrl);

                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    var uzanti = Path.GetExtension(Resim.FileName);
                    var resimAdi = Guid.NewGuid() + uzanti;
                    var imagePath = Path.Combine(baseImagePath, resimAdi);
                    using var stream = new FileStream(imagePath, FileMode.Create);
                    await Resim.CopyToAsync(stream);
                    user.ResimUrl = resimAdi;
                }

                await userManager.Update(user);
                return RedirectToAction("Profilim");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult ParolaGuncelle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ParolaGuncelle(ParolaUpdateDTO model)
        {
            if (ModelState.IsValid && model.Parola != null)
            {
                var user = await userManager.GetUserByUsername(User.Identity.Name);
                user.Parola = model.Parola;
                await userManager.Update(user);
                await HttpContext.SignOutAsync();
                return RedirectToRoute(new { controller = "Home", action = "Login" , area="" });
            }
            return View(model);
        }

    }
}
