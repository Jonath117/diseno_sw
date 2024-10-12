using Microsoft.AspNetCore.Mvc;
using Notis.Services;

[ApiController]
[Route("api/[controller]")]

public class ExaminadorController: ControllerBase
{
    private readonly IExaminadorService _examinador;
    public ExaminadorController(IExaminadorService examinador)
    {
        _examinador = examinador;
    }

    

    [HttpPost("aceptar")]
    public IActionResult AceptarDocumento()
    {
        _examinador.AprobarDocumento();
        return Ok("Documento Aceptado");
    }


    [HttpPost("rechazar")]
    public IActionResult RechazarDocumento()
    {
        _examinador.RechazarDocumento();
        return Ok("Documento Rechazado");
    }

}

