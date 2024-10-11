namespace Notis.Models;

public class Examinador
{
    int ID {get; set;}
    string Nombre {get; set;}
    string Correo {get; set}
    string Contrasena {get; set}

    public Examinador(int id, string nombre, string correo, string contrasena)
    {
        ID = id;
        Nombre = nombre;
        Correo = correo;
        Contrasena = contrasena;
    }

}