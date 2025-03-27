using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    [HttpGet("mongo")]
    public IActionResult ListarSalonesMongoDb(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Practica2_Amarildo_Juan");
        var collection = db.GetCollection<SalonMongo>("Peliculas");
    
        var lista = collection.Find(FilterDefinition<SalonMongo>.Empty).ToList();

        return Ok(lista); 
    }
}