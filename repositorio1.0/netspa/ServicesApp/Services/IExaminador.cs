using netspa.Models;

public interface IExaminador{
    void corregir();
    void enviarArticulos();
    List<Articulo> RecibirArticulos();
}