using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace İşTakipProjesi.Areas.Personel.Controllers
{
    [Area("Personel")]
    [Authorize(Roles ="Member")]
    public class GorevController : Controller
    {
        private readonly IGorevService gorevManager;
        private readonly IUserService userManager;
        private readonly IMapper mapper;

        public GorevController(IGorevService _gorevService, IMapper _mapper, IUserService _userManager)
        {
            gorevManager = _gorevService;
            mapper = _mapper;
            userManager = _userManager;
        }

        public async Task<IActionResult> Gorevler()
        {
            var user = await userManager.GetUserByUsername(User.Identity.Name);
            var liste = await gorevManager.GetAllWithIncludedElementsAsync(user.Id);
            var gorevler = mapper.Map<IEnumerable<GorevListDTO>>(liste);
            var gorevList = gorevler.ToList();
            return View(gorevList);
        }






    }
}
