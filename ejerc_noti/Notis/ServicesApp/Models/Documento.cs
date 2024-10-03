namespace Notis.Models;

public class Documento{
    public int ID { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public int IdResponsable { get; set; }
    public string descrip_Estado { get; set; }
    public bool Aprobado { get; set; }
//comportamiento orientado a persistencia 
//servicios son servicios por que esta orientado a servicios por que es backend 
//olap 
//IDAo accesores a la bases de datos
//dao metodos para las queries, orientado a las bases de datos
//dto
    public Documento(int id, string titulo, string descripcion, int responsable){
        ID = id;
        Titulo = titulo;
        Descripcion = descripcion;
        IdResponsable = responsable;
        descrip_Estado = "En revision";
        Aprobado = false;
    }
}