using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using netspa.Services;

namespace netspa.Controllers;

[ApiController]
[Route("Examinador")]

public class ExaminadorController: ControllerBase
{
    private readonly IExaminador _examinador;

        // Constructor que recibe la dependencia inyectada
    public ExaminadorController(IExaminador examinador)
        {
            _examinador = examinador;
        }

    // public IExaminador examinador(){
    //     return _examinador;
    // }


    [HttpGet ("ListarArticulos")]

    public ActionResult ObtenerLista(){
        
        List<int> ArticulosPendientes = _examinador.RecibirArticulos();

        return Ok(ArticulosPendientes);
    }

    // private IExaminador? Examinador1 { get; set; }
    // public IExaminador Examinador(IExaminador examinador){
    //     Examinador1 = examinador;
    //     return examinador; 
         
    // }  
    
    

}

