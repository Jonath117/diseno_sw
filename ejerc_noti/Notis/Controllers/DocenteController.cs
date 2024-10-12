using Microsoft.AspNetCore.Mvc;
using Notis.Models;
using Notis.Services;

namespace Notis.Controllers;

public class DocenteController: ControllerBase
{
    private readonly IDocenteService _docenteService;
    public DocenteController(DocenteService docenteService)
    {
        _docenteService = docenteService;
    }

    [HttpPost("subirDocumento")]
    public void SubirDocumento(string title, string autor, string categoria, string descripcion)
    {
        _docenteService.EnviarDocumento(title, autor, categoria, descripcion);
    }
}