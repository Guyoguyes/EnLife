namespace EnLife.Models;

public class Sighting
{
    public int ID { get; set; }
    public string Location { get; set; }
    public int RangerId { get; set; }
    public int AnimalId { get; set; }
    public DateTime TimeReported { get; set; }
    
    public virtual ICollection<Ranger> Rangers { get; set; }
    public virtual ICollection<Animal> Animals { get; set; }
}