using MongoDB.Bson.Serialization.Attributes;

public class SalonMongo {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; } 
    public string Titulo { get; set; } = string.Empty;
    public string AñoEstreno { get; set; } = string.Empty; 
    public List<string> Genero { get; set; } 
    public string Director { get; set; } 
    public int DuracionMinutos { get; set; } 
    public decimal Calificacion { get; set; } 
    public decimal Recaudacion { get; set; }
    public string Sinopsis { get; set; } = string.Empty;

}