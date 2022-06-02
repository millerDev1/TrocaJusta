using System;
using TrocaJusta.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace TrocaJusta.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Entrar(string Email, string  Senha)
        {
            MySqlConnection mySqlConnection = new MySqlConnection ("server=localhost;DataBase=TrocaJusta;Uid=root");
            await mySqlConnection.OpenAsync();

             MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
             mySqlCommand.CommandText = $" SELECT *FROM usuario WHERE Email = '{Email}' AND Senha = '{Senha}'";
             MySqlDataReader reader = mySqlCommand.ExecuteReader();
            try
            {
                if(ModelState.IsValid) 
                {  
                    if (await reader.ReadAsync())
                    {

                        return RedirectToAction("Index","Home");

                
                     }
                    TempData["MensagemErro"]=$"Usuário e/ou Senha Inválido(s).Por Favor, Tente Novamente:";

                }

                return View ("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"]=$"Ops, não conseguimos Encontrar Seu Login,Tente Novamente, detalhes do erro:{erro.Message}";
                return RedirectToAction("Index");
                
            }
        
        
        }       
    
    
    
    } 



}