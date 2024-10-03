namespace netspa.Models;
public class Docente : IDocente{
    public int ID;
    public string Nombre;

    public string Correo;

    public string Contrasena; 


public Docente (int ID, string Nombre, string Correo, string Contrasena){
    this.ID = ID;
    this.Nombre = Nombre;
    this.Correo = Correo;
    this.Contrasena = Contrasena;
}

    public void enviarArticulos()
    {
        throw new NotImplementedException();
    }

    public void recibirArticulos(){
        throw new NotImplementedException();
    }
}