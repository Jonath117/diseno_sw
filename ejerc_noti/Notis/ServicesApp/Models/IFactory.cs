namespace Notis.Models;

public interface IFactory
{
    /*
    public IArchivo CreatePDF();

    public IArchivo CreateExcel();

    public IArchivo CreateWord();
    */

    public IArchivo Create(string tipoDato);
}