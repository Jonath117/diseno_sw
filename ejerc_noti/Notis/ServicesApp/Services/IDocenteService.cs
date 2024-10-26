using Notis.Models;
namespace Notis.Services;
public interface IDocenteService
{
    public Documento EnviarDocumento(DocumentParams dp);
}