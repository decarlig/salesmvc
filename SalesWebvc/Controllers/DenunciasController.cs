using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebvc.Models;

namespace SalesWebvc.Controllers
{
    public class DenunciasController : Controller
    {
        public IActionResult Index()
        {
            List<Denuncia> list = new List<Denuncia>();
            list.Add(new Denuncia { Id = 1, Logradouro = "Rua dos Coqueiros", Numero = int.Parse("225"), Complemento = "Apto 702C", Estado = "Paraná", Municipio = "Londrina", Responsavel = "Kakaroto Vegeta", Tipo = "Residencial", Zona = "Urbana", Aream3 = 30   });
            
            return View(list);
        }
    }
}