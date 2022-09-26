using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mobitek.CRM.Data.Repository;
using Mobitek.CRM.Entities;
using Mobitek.CRM.Models;
using Mobitek.CRM.Models.UserModels;
using System.Linq;
using System.Threading.Tasks;

namespace Mobitek.CRM.Controllers
{
    /// <summary>
    /// Kullanıcı işlemleri, ekleme, çıkarma, rol verme vb işlemleri userManager kullanılarak yapılacaktır.
    /// UserRepository zorda kalmadıkça kullanılmazsa iyi olur.
    /// </summary>
    public class UsersController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IRepository<User> _userRepository;

        public UsersController(UserManager<User> userManager, IRepository<User> userRepository)
        {
            _userManager = userManager;
            _userRepository = userRepository;
        }

        /// <summary>
        /// Kullanıcılar sayfası
        /// </summary>
        /// <returns></returns>

        public async Task<IActionResult> Index()
        {
            var users = await _userRepository.GetAllAsync();
            return View(new UsersViewModel() { Users = users.ToList() });
        }

        /// <summary>
        /// Kullanıcı detay sayfası
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IActionResult> Detail(string id)
        {
            //implement here
            var model = new UserDetailViewModel();
            return View(model);
        }

        /// <summary>
        /// Kullanıcı ekleme sayfası
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(UserAddModel model)
        {
            //implement here
            if (!ModelState.IsValid)
                return Json(new { Succeeded = false });
            return Json(new { Succeeded = true });

        }
    }
}
