using AppBlogCore.Models;
using BlogCore.AccesoDatos.Data.Repository.IRepository;
using BlogCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppBlogCore.Areas.Cliente.Controllers
{
    [Area("Cliente")]
     public class Proyectos : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public Proyectos(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }
        public IActionResult IndexProyect()
        {
            HomeVM homeVM = new HomeVM()
            {
                ListaDeArticulos = _contenedorTrabajo.Articulo.GetAll()
            };

            return View(homeVM);
        }
        public IActionResult Details(int Id)
        {
            var articuloDesdeDb = _contenedorTrabajo.Articulo.Get(Id);
            return View(articuloDesdeDb);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
