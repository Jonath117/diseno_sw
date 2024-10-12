namespace Notis.Services;

public class DocenteService : IDocenteService
{
    public void EnviarDocumento(string title, string autor, string categoria, string descripcion)
    {
        var _documentoService = new DocumentoService();
        _documentoService.CrearDocumento(title, autor, categoria, descripcion);
    }
}