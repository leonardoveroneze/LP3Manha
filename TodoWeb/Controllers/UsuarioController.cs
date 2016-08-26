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
        public ActionResult Update()
        {
            return View();
        }

        //GET: Usuario/Login
        public ActionResult Login()
        {
            return View();
        }
    }

}