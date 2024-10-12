using Notis.Models;
namespace Notis.Services;

public interface IDocumentoService
{
    public List<Documento> ObtenerDocumentosAprobados();
    public void DescargarDocumento(int id);
    public void CalificarDocumento(int id);
    public List<Documento> BuscarPorCategoria(string categoria);
    List<Documento> ObtenerDocumentosEnRevision();
    //Documento ObtenerDocumentoPorId(int id);
    public void CrearDocumento(string title, string autor, string categoria, string descripcion);
    void GuardarCambios();
    //void AprobarDocumento(int id, string revisadoPor);
    //void RechazarDocumento(int id, string revisadoPor);
}