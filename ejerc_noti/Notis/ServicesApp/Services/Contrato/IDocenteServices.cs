using Notis.Models;
namespace Notis.Services;
public interface IDocenteService
{
    void EnviarDocumento(string title, string autor, string categoria, string descripcion);
}