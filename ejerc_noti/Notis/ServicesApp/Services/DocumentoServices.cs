using Notis.Models;
namespace Notis.Services;

public class DocumentoServices : IDocumentoService
{
    private Documento _documento;
    public DocumentoServices(Documento doc)
    {
        _documento = doc;
    }
    public void AprobarDocumento()
    {
        _documento.Aprobado = true;
        _documento.descrip_Estado = "Aprobado";
    }

    public bool ObtenerEstadoDoc()
    {
        return _documento.Aprobado;
    }
}