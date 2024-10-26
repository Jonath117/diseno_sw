using Notis.Models;
namespace Notis.Services;

public class DocumentoService : IDocumentoService
{
    private List<Documento> _documentos;
    public DocumentoService()
    {
        _documentos = new List<Documento>()
        {
            new Documento("titulo1", "autor1", "categoria1", "descripcion1"),
            new Documento("titulo2", "autor2", "categoria2", "descripcion2"),
            new Documento("titulo3", "autor3", "categoria3", "descripcion3"),
        };
    }
    public Documento CrearDocumento(DocumentParams dp)
    {
        var documento = new Documento(dp.title!, dp.autor!, dp.descripcion!, dp.categoria!);
        _documentos.Add(documento);
        MostrarListaDocumentos();
        return documento;
    }

    public void MostrarListaDocumentos()
    {
        Console.WriteLine(string.Join("\n", _documentos));
    }
}