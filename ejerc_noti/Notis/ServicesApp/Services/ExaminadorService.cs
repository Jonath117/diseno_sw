using Notis.Models;
using Notis.Services;

public class ExaminadorService : IExaminadorService
{
    private Docente _docente = new Docente(1, "Nombre");
    private Documento _documento = new Documento(1, "Titulo", "Descripcion", 1);

    public void AprobarDocumento()
    {
        INotificacionService _notiservice = new NotificacionService();
        _documento.Aprobado = true;
        _documento.descrip_Estado = "Aprobado";
        _notiservice.DocumentoAprobado();
    }
}