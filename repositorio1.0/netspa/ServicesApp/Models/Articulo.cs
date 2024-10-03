namespace netspa.Models;

public class Articulo{
    public int ID;
    public string Titulo;
    public string Descripcion;
    public string Autor;
    public string descrip_Estado;
    public bool  Estado;
//comportamiento orientado a persistencia 
//servicios son servicios por que esta orientado a servicios por que es backend 
//olap 
//IDAo accesores a la bases de datos
//dao metodos para las queries, orientado a las bases de datos
//dto
    public Articulo(int ID, string Titulo, string Descripcion, string Autor, string descrip_Estado, bool Estado){
        this.ID = ID;
        this.Titulo = Titulo;
        this.Descripcion = Descripcion;
        this.Autor = Autor;
        this.descrip_Estado = "Aceptado";
        this.Estado = true;
    }

    public bool EstadoP(){
        return this.Estado;
    }


}