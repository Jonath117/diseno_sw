using Microsoft.AspNetCore.Mvc;
using Notis.Models;
using Notis.Services;

namespace Notis.Controllers;

[ApiController]
[Route("[controller]")]
public class DocumentController : ControllerBase
{
    private readonly IDocumentoService _documentService;
    public DocumentController(IDocumentoService documentoService)
    {
        _documentService = documentoService;
    }

    [HttpGet("en-revision")]
    public IEnumerable<Documento> GetDocumentosEnRevision()
    {
        return _documentService.ObtenerDocumentosEnRevision();
    }

    [HttpGet("aprobados")]
    public IEnumerable<Documento> GetDocumentosAprobados()
    {
        return _documentService.ObtenerDocumentosAprobados();
    }

/*
    [HttpGet("{id}")]
    public Documento GetDocumentoPorId(int id)
    {
        return _documentService.ObtenerDocumentoPorId(id);
    }
*/
    [HttpGet("{id}/descargar")]
    public void DownloadDoc(int id)
    {
        _documentService.DescargarDocumento(id);
    }

    [HttpGet]
    public IEnumerable<Documento> SearchPorCategoria(string categoria)
    {
        return _documentService.BuscarPorCategoria(categoria);
    }
}