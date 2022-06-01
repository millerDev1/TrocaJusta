using System;
using TrocaJusta.Models;
using Microsoft.AspNetCore.Mvc;


namespace TrocaJusta.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    [HttpPost]
    public IActionResult Entrar(Login login)
    {
        try
        {
            if(ModelState.IsValid)
            {
                if(login.Email == "adm" && login.Senha == "123")
                {
                    return RedirectToAction("Index","Home");
                }
                TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente.";
            }

            return View("Index");
        }
        catch (Exception erro)
        {
            TempData["MensagemErro"] = $"Não conseguimos realizar seu login, tente novamente, detalhe do erro:{erro.Message}";
            return RedirectToAction("Index");
        }
    }
}
}