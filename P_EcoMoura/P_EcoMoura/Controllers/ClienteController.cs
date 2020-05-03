using Microsoft.AspNetCore.Mvc;
using P_EcoMoura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_EcoMoura.Controllers
{
    public class ClienteController : Controller
    {
        /*
        *  ActionResult
        *  IActionResult
        */
        public ActionResult Visualizar()
        {

            Cliente Cliente = GetCliente();

            return View(Cliente);
            //return new ContentResult() { Content = "<h3>Produto -> Visualizar</h3>", ContentType = "text/html" }; 
        }

        private Cliente GetCliente()
        {
            return new Cliente()
            {
                id = 1,
                idEmpresa = 561,
                razaoSocial = "Presidente Prudente Comercio de Baterias LTDA",
                cnpj = "29.478.894/0001-01",
                telefone = "(18) 3221-4588",
                celular = "(18) 99701-2233",
                saldoBIN = 0,
                idRota = 1,
                situacao = 1,
    };
        }
    }
}
