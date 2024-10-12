namespace Notis.Models;

public class Examinador
{
    int ID {get; set;}
    string Nombre ;
    string Correo ;
    string Contrasena ;

    public Examinador(int id, string nombre, string correo, string contrasena)
    {
        ID = id;
        Nombre = nombre;
        Correo = correo;
        Contrasena = contrasena;
    }

}