using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaNN.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "QUERO O PC DE VOLTA";
            ViewBag.BG = "BAG GANGSTER";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.CONT = "Eu adoro a professora Heliene"; 

            return View();
        }

        public ActionResult Aluno()
        {
            ViewBag.ID = "1";
            ViewBag.NOME = "Filipe";
            ViewBag.SEXO = "Celta vermelho rebaixado";
            return View();
        }
    }
}