using System.Diagnostics;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SR.AutoMapper.Sample.Services;
using SR.AutoMapper.Sample.UI.Extentions;
using SR.AutoMapper.Sample.UI.ViewModels;

namespace SR.AutoMapper.Sample.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUserService userService;

        public HomeController(IMapper mapper, IUserService userService)
        {
            this.mapper = mapper;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            var users = this.userService.GetUsers().Select(u => u.ToViewModel<UserViewModel>(mapper));
            return View(users);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
