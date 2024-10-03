using Notis.Models;
namespace Notis.Services;
public interface IDocumentoService
{
    public bool ObtenerEstadoDoc();
    public void AprobarDocumento();

}