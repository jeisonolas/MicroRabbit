using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MicroRabbit.MVC.Models;
using MicroRabbit.MVC.Services;
using MicroRabbit.MVC.Models.DTO;

namespace MicroRabbit.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransferService _transferService;

        public HomeController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        public IActionResult Index()
        {
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

        [HttpPost]
        public async Task<IActionResult> Transfer(TransferDTO model)
        {
            await _transferService.Transfer(model);

            return View("Index");
        }
    }
}
