using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoWeb.Models;

namespace TodoWeb.Controllers
{
    public class UsuarioController : Controller
    {
        static List<Usuario> lista = new List<Usuario>();

        public UsuarioController()
        {
            //lista.Add(new Usuario { Nome = "Fulano", UsuarioId = 1 });
            //lista.Add(new Usuario { Nome = "Ciclano", UsuarioId = 2 });

            //ViewBag.Usuario = lista;
        }
        //GET: Usuario/Index
        public ActionResult Index()
        {
            return View(lista);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            String nome = form["Nome"];
            int id = int.Parse(form["UsuarioId"]);
            String email = form["Email"];
            string senha = form["Senha"];

            Usuario u = new Usuario();
            u.Nome = nome;
            u.UsuarioId = id;
            u.Email = email;
            u.Senha = senha;


            lista.Add(u);

            return RedirectToAction("Index");
        }

        // GET: Usuario/Update
        public ActionResult Update(int id)
        {
            Usuario user = null;

            foreach (var u in lista)
            {
                if (u.UsuarioId == id)
                {
                    user = u;
                    break;
                }
            }
            return View(user);
        }

        // POST: Usuario/Update
        [HttpPost]
        public ActionResult Update(FormCollection form)
        {
            Usuario u = new Usuario();
            u.Nome = form["Nome"];
            u.UsuarioId = int.Parse(form["UsuarioId"]);
            u.Email = form["Email"];

            foreach (var x in lista)
            {
                if (x.UsuarioId == u.UsuarioId)
                {
                    x.Nome = form["Nome"];
                    x.UsuarioId = int.Parse(form["UsuarioId"]);
                    x.Email = form["Email"];
                    return RedirectToAction("Index");
                }
            }

            lista.Add(u);
            return RedirectToAction("Index");

        }

        //GET: Usuario/Login
        public ActionResult Login()
        {
            return View();
        }

        //GET: Usuario/Delete
        public ActionResult Delete(int id)
        {
            Usuario user = null;

            foreach (var u in lista)
            {
                if (u.UsuarioId == id)
                {
                    lista.Remove(u);
                    break;
                }

            }
            return RedirectToAction("Index");
        }
    }

}