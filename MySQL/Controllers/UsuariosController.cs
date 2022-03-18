using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySQL.Entidades;

namespace MySQL.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Contexto db;
        public UsuariosController(Contexto _db)
        {
            db = _db;
        }
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Usuario dadosQueVemTela)
        {
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Edit(int id, Usuario dadosQueVemTela)
        {
            return RedirectToAction("index");
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }


    }
}
