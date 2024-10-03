namespace Notis.Models;
public class Docente
{
    public int ID;
    public string Nombre;

    public Docente(int id, string nombre)
    {
        ID = id;
        Nombre = nombre;
    }

    public void EnviarDocumento()
    {
        throw new NotImplementedException();
    }

    public void RecibirDocumento()
    {
        throw new NotImplementedException();
    }
}