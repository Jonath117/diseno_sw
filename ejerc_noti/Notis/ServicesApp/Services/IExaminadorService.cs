using Notis.Models;
namespace Notis.Services;

public interface IExaminadorService
{
    public void AprobarDocumento();
    public void RechazarDocumento();
}