using Microsoft.AspNetCore.Mvc;
using Notis.Services;

public class ExaminadorController: ControllerBase
{
    private readonly IExaminadorService _examinador;
    public ExaminadorController(IExaminadorService examinador)
    {
        _examinador = examinador;
    }

    

    [HttpPost("aceptar")]
    public void AceptarDocumento()
    {
        _examinador.AprobarDocumento();
    }


    
}

