using System;
using TrocaJusta.Models;
using Microsoft.AspNetCore.Mvc;

namespace TrocaJusta.Controllers
{
    public class FuncionaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }   
}