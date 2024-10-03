namespace netspa.Models;
public class Examinador : IExaminador{
    public int ID;
    public string Nombre;

    public string Correo;

    public string Contrasena;
    
    
    public Examinador(int ID, string Nombre, string Correo, string Contrasena){
        this.ID = ID;
        this.Nombre = Nombre;
        this.Correo = Correo;
        this.Contrasena = Contrasena;
    }

    public void corregir()
    {
        throw new NotImplementedException();
    }

    public void enviarArticulos()
    {
        throw new NotImplementedException();
    }

    public List<int> RecibirArticulos()
    {
        return new List<int> {1, 2, 3};
    }

    List<Articulo> IExaminador.RecibirArticulos()
    {
        throw new NotImplementedException();
    }
}