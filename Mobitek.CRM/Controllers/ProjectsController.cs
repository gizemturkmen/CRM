using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mobitek.CRM.Data.Repository;
using Mobitek.CRM.Data.UoW;
using Mobitek.CRM.Entities;
using Mobitek.CRM.Models;
using Mobitek.CRM.Models.ProjectModels;
using System.Linq;
using System.Threading.Tasks;

namespace Mobitek.CRM.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IRepository<Project> _projectRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProjectsController(IRepository<Project> projectRepository, IUnitOfWork unitOfWork)
        {
            _projectRepository = projectRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Projeler sayfası. Index sayfası genel olarak tüm entity'lerin listelendiği sayfadır.
        /// </summary>
        /// <returns></returns>

        public async Task<IActionResult> Index()
        {
            var projects = await _projectRepository.GetAllAsync();
            return View(new ProjectsViewModel() { Projects = projects.ToList() });
        }

        /// <summary>
        /// Proje detay sayfası. Detail sayfası genel olarak bir entity'nin detaylarının listelendiği sayfadır. 
        /// Parametre olarak detaylarını listeleyeceği elemanın id'sini alır,
        /// databaseden onu yakalar ve onu modelin içine koyar, o modeli de sayfaya (razor view/view) gönderir
        /// sayfada ise html ile listeleme yapar. tablo veya datatable ile listelemek uygundur.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IActionResult> Detail(string id)
        {
            var model = new ProjectDetailViewModel();
            var project = await _projectRepository.Table.FirstOrDefaultAsync(x => x.Id == id);

            if (project == null)
            {
                model.ErrorMessage = "Müşteri bulunamadı";
                return View(model);
            }

            model.Project = project;
            return View(model);

        }

        /// <summary>
        /// Proje ekleme sayfası. HttpGet ile işaretli olan Add fonksiyonu, Add fonksiyonu ilk tetiklendiğinde çalışıyor
        /// ve sayfaya model göndererek sayfayı açıyor.
        /// </summary>
        /// <returns></returns>
        /// [HttpPost]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProjectAddViewModel();
            model.Project = new Project();
            return View(model);

        }
        /// <summary>
        /// Öte yandan HttpPost ile işaretli olan add fonksiyonu, içine viewda içi doldurulup submitlenmiş
        /// proje modelini alıyor. HttpPost metodunu çağırmak için viewda bunu belirtmemiz gerekecek.
        /// Model hatalıysa, aynı sayfaya modelin içine hata mesajı yerleştirip geri gönderiyor fakat insert atmıyor.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(ProjectAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ErrorMessage = "hata";
                return View(model);
            }
            await _projectRepository.AddAsync(model.Project);
            await _unitOfWork.CommitAsync();
            //return to /Projects/Index
            return RedirectToAction("Index");

        }
    }
}
