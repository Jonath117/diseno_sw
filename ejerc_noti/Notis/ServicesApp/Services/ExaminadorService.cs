using Notis.Models;
using Notis.Services;

public class ExaminadorService : IExaminadorService
{
    private Examinador _examinador = new Examinador(1, "Examinador", "examinador.correo@gmail.com", "contraseña");
    private Docente _docente = new Docente(1, "Nombre");
    private Documento _documento = new Documento(1, "Titulo", "Descripcion", 1);

    public void AprobarDocumento()
    {
        INotificacionService _notiservice = new NotificacionService();
        _documento.Aprobado = true;
        _documento.descrip_Estado = "Aprobado";
        _notiservice.DocumentoAprobado();
    }

    public void RechazarDocumento()
    {
        INotificacionService _notiservice = new NotificacionService();
        _documento.Aprobado = false;
        _documento.descrip_Estado = "Rechazado";
        _notiservice.DocumentoRechazado();
    }
}