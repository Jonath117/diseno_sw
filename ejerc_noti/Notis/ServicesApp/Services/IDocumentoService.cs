using Notis.Models;
namespace Notis.Services;
public interface IDocumentoService
{
    public Documento CrearDocumento(DocumentParams documentParams);
}