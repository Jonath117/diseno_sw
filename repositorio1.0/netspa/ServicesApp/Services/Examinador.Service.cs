using netspa.Models;

namespace netspa.Services;
public class ExaminadorService : IExaminador
{
    public void corregir()
    {
        throw new NotImplementedException();
    }

    public void enviarArticulos()
    {
        throw new NotImplementedException();
    }

    public List<Articulo> RecibirArticulos()
    {
        List<Articulo> lista = new List<Articulo> {
            new Articulo(1, "Titulo1", "Descripcion1", "Autor1", "DescrpEstado1", false),
            new Articulo(2, "Titulo2", "Descripcion2", "Autor2", "DescrpEstado2", false),
            new Articulo(2, "Titulo3", "Descripcion3", "Autor3", "DescrpEstado3", false),
        };

        foreach (Articulo Articulo in lista){
            System.Console.WriteLine($"Articulo con ID: {Articulo}");
        }
        return lista;
    }
}