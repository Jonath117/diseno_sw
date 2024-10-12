/*using Notis.Models;
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
}*/
using Notis.Models;

namespace Notis.Services;
public class DocumentoService : IDocumentoService
{
    private List<Documento> _documentos;

    public DocumentoService()
    {
        _documentos = new List<Documento>
        {
            new Documento ("Documento 1", "Autor 1", "ciencia", "Descripcion 1"),
            new Documento ("Documento 2", "Autor 2", "ingenieria", "Descripcion 2"),
            new Documento ("Documento 3", "Autor 3", "medicina", "Descripcion 3")
        };
    }

    // Implementación del método para aprobar un documento
    /*public void AprobarDocumento(int id, string revisadoPor)
    {
        var documento = ObtenerDocumentoPorId(id);
        if (documento == null)
        {
            throw new Exception("Documento no encontrado.");
        }
        
        documento.Aprobado = true;
        documento.Estado = "Aprobado";
        documento.FechaRevision = DateTime.Now;
        documento.RevisadoPor = revisadoPor;
    }*/

    // Implementación del método para rechazar un documento
    /*public void RechazarDocumento(int id, string revisadoPor)
    {
        var documento = ObtenerDocumentoPorId(id);
        if (documento == null)
        {
            throw new Exception("Documento no encontrado.");
        }
        
        documento.Aprobado = false;
        documento.Estado = "Rechazado";
        documento.FechaRevision = DateTime.Now;
        documento.RevisadoPor = revisadoPor;
    }*/

    // Método para obtener un documento por su ID
    /*public Documento ObtenerDocumentoPorId(int id)
    {
#pragma warning disable CS8603 // Possible null reference return.
        return _documentos.FirstOrDefault(doc => doc.Id == id);
#pragma warning restore CS8603 // Possible null reference return.
    }*/

    // Método para obtener todos los documentos que están en revisión
    public List<Documento> ObtenerDocumentosEnRevision()
    {
        return _documentos.Where(doc => doc.Estado == "En revisión").ToList();
    }

    public List<Documento> ObtenerDocumentosAprobados()
    {
        return _documentos.Where(doc => doc.Estado == "Aprobado").ToList();
    }

    public void GuardarCambios()
    {
        
    }

    public void DescargarDocumento(int id)
    {
        throw new NotImplementedException();
    }

    public void CalificarDocumento(int id)
    {
        throw new NotImplementedException();
    }

    public List<Documento> BuscarPorCategoria(string categoria)
    {
        return _documentos.Where(doc => doc.Categoria == categoria).ToList();
    }

    public void CrearDocumento(string title, string autor, string categoria, string descripcion)
    {
        var nuevoDocumento = new Documento(title, autor, categoria, descripcion);
        _documentos.Add(nuevoDocumento);
    }
}