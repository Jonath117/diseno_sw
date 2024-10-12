using Notis.Models;
namespace Notis.Services;

public interface INotificacionService
{
    public Notificacion DocumentoAprobado();
    public Notificacion DocumentoRechazado();

}