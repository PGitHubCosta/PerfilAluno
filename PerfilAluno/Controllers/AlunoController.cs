using Microsoft.AspNetCore.Mvc;

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

       
        public IActionResult Detalhes(int id)
        {
            
            ViewBag.IdAluno = id;
                        
            ViewBag.Nome = "Pedro Costa";
            ViewBag.RA = "987654321";
            ViewBag.StatusMatricula = "Ativa";

            return View();
        }
    }
}
