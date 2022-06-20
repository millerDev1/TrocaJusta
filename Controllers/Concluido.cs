using System;
using TrocaJusta.Models;
using Microsoft.AspNetCore.Mvc;

namespace TrocaJusta.Controllers
{
    public class ConcluidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }   
}