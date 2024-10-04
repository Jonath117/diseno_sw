public class ExaminadorController: ControllerBase
{
    private readonly IExaminadorService _examinador;
    public ExaminadorController(IExaminador examinador)
    {
        _examinador = examinador;
    }

    [HttpPost("aceptar")]
    public void AceptarDocumento()
    {
        return _examinador.AprobarDocumento();
    }
    
}

