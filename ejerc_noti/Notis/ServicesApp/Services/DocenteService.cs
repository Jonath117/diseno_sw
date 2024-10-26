using Notis.Models;
namespace Notis.Services;

public class DocenteService : IDocenteService
{
    private IDocumentoService _documentoService;
    public DocenteService(IDocumentoService documentoService)
    {
        _documentoService = documentoService;
    }
    public Documento EnviarDocumento(DocumentParams dp)
    {
        return _documentoService.CrearDocumento(dp);
    }
}