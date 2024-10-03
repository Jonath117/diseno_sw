namespace netspa.Models;
public class Estudiante{
    public int ID;
    public string Nombre;

    public string Correo;

    public string Contrasena;
    
    
    public Estudiante(int ID, string Nombre, string Correo, string Contrasena){
        this.ID = ID;
        this.Nombre = Nombre;
        this.Correo = Correo;
        this.Contrasena = Contrasena;
    }


}