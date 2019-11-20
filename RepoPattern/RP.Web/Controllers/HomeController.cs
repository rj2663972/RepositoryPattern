using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RP.Domain.Core.Interfaces;
using RP.Domain.Entities.UserAgg;
using RP.Web.Models;

namespace RP.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISampleDataContext _dataContext;
        private readonly IAsyncRepository<User> _asyncUserRepository;

        public HomeController(ILogger<HomeController> logger,
            ISampleDataContext dataContext,
            IAsyncRepository<User> asyncUserRepository)
        {
            _dataContext = dataContext;
            _logger = logger;
            _asyncUserRepository = asyncUserRepository;
        }

        public IActionResult Index()
        {
            var users = _asyncUserRepository.GetAllAsync().Result;
            return View(users);
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
