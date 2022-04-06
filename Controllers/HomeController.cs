using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Enquete.Models;

namespace Enquete.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Responder()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Responder(Resposta form)
    {
        if(ModelState.IsValid)
        {
            Repositorio.AdicionarResposta(form);
            return View("Obrigado");
        }

        return View(form);
    }

    public IActionResult Resultado()
    {
        return View(Repositorio.Respostas);
    }
}
