namespace Notis.Models;

public class Examinador
{
    public int ID { get; set; }
    public string Nombre { get; set; }

    Examinador (int id, string nombre)
    {
        ID = id;
        Nombre = nombre;
    }


}