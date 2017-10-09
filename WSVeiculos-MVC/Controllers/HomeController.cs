using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WSVeiculos.DAL;
using WSVeiculos.DTO;

namespace WSVeiculos_MVC.Controllers
{
    public class HomeController : Controller
    {
        private Produtos dtoProdutos = new Produtos();

        private Cliente dtoCliente = new Cliente();


   
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Financiamento()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Message = "Your contact page.";

            List<object> list = new List<object>();
                  
            list.Add("JonatasFreitas");
            list.Add("HelloWorld!");
            list.Add(3);
            list.Add("thecodebr.blogspot.com");

            return View(list);
        }

        public ActionResult SelectedVal(string Valor)
        {

            ViewBag.Valor = Valor;

            return View();
        }

        [HttpPost]
        public ActionResult GridResultado( string Nome, string Sobrenome, int Telefone, string Marca, string Mensagem, string CheckboxAnuncio)
        {



            dtoCliente.Nome = ViewBag.Nome = Nome;
            

            return View();
        }

    
































    }
}