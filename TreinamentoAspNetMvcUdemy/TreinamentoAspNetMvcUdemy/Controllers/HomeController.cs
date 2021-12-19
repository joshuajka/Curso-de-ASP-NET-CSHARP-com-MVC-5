using System.Web.Mvc;
using TreinamentoAspNetMvcUdemy.Models;
namespace TreinamentoAspNetMvcUdemy.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                PessoaId = 1,
                Nome = "João Oliveira",
                Tipo = "Administrador"
            };

            var pessoa2 = new Pessoa()
            {
                PessoaId = 2,
                Nome = "Oliveira",
                Tipo = "Ajudante"
            };

            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;
            //ViewBag.Id = pessoa.PessoaId;
            //ViewBag.Nome = pessoa.Nome;
            //ViewBag.Tipo = pessoa.Tipo;
            return View(pessoa2);
        }

        public ActionResult Autor()
        {
            return View();
        }

        public ActionResult Contatos()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //[HttpGet]
        //public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        //{
        //    ViewData["PessoaId"] = PessoaId;
        //    ViewData["Nome"] = Nome;
        //    ViewData["Tipo"] = Tipo;
        //    return View();
        //}

        //public ActionResult Lista(FormCollection form)
        //{            "Nome da variável"       "nome do campo no form"
        //    ViewData["PessoaId"] = form["PessoaId"];
        //    ViewData["Nome"] = form["Nome"];
        //    ViewData["Tipo"] = form["Tipo"];
        //    return View();
        //}
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;
            return View(pessoa);
        }

    }
}