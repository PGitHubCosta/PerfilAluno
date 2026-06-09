using Microsoft.AspNetCore.Mvc;
using PerfilAluno.Models;
using System.Text.Json; 
namespace PerfilAluno.Controllers
{
    public class AlunoController : Controller

    {
        public IActionResult Index()
        {
            
            ViewBag.Nome = "Pedro Costa";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "3º Semestre";

            return View();
        }

        // Acessado via: /Aluno/Detalhes/1
        public IActionResult Detalhes(int id)
        {
            
            ViewBag.IdAluno = id;
            
            ViewBag.Nome = "Pedro Costa";
            ViewBag.RA = "987654321";
            ViewBag.StatusMatricula = "Ativa";

            return View();
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                
                TempData["AlunoCadastrado"] = JsonSerializer.Serialize(aluno);
                
                
                return RedirectToAction("Confirmacao");
            }

            return View(aluno);
        }

        
        [HttpGet]
        public IActionResult Confirmacao()
        {
           
            if (TempData["AlunoCadastrado"] is string alunoJson)
            {
                
                var aluno = JsonSerializer.Deserialize<Aluno>(alunoJson);
                return View(aluno);
            }

           
            return RedirectToAction("Cadastrar");
        }
    }
}
