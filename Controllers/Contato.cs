using System;
using TrocaJusta.Models;
using Microsoft.AspNetCore.Mvc;

namespace TrocaJusta.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }   
}