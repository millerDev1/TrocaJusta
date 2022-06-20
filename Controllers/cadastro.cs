using System;
using TrocaJusta.Models;
using Microsoft.AspNetCore.Mvc;

namespace TrocaJusta.Controllers
{
    public class cadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }   
}