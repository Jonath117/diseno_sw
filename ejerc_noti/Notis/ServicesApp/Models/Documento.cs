namespace Notis.Models;

public class Documento {
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Categoria { get; set; }
    public string Descripcion { get; set; }
    public string descrip_Estado { get; set; }
    public bool Aprobado { get; set; }
//comportamiento orientado a persistencia 
//servicios son servicios por que esta orientado a servicios por que es backend 
//olap 
//IDAo accesores a la bases de datos
//dao metodos para las queries, orientado a las bases de datos
//dto
    public Documento(string titulo, string autor, string categoria, string descripcion)
    {
        Titulo = titulo;
        Autor = autor;
        Categoria = categoria;
        Descripcion = descripcion;
        descrip_Estado = "En revision";
        Aprobado = false;
    }

    public override string ToString()
    {
        return $"{Titulo}, {Autor}, {Categoria}, {Descripcion}, {descrip_Estado}, {Aprobado}";
    }
}