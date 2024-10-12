namespace Notis.Models;

public class Documento
{
    //public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Autor { get; set; }
    public string? Categoria { get; set; }
    public string? Descripcion { get; set; }
    public bool Aprobado { get; set; }
    public string Estado { get; set; } = "En revisión"; // "En revisión", "Aprobado", "Rechazado"
    public DateTime FechaSubida { get; set; }
    public DateTime? FechaRevision { get; set; }
    public string? RevisadoPor { get; set; }
    public double Rating { get; set; } 
    
    public Documento(string title, string autor, string categoria, string descripcion)
    {
        Titulo = title;
        Autor = autor;
        Categoria = categoria;
        Descripcion = descripcion;
        FechaSubida = DateTime.Now;
        Aprobado = false;
    }
}