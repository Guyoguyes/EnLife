namespace EnLife.Models;

public class Animal
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int RangerID { get; set; }
    public int TypeID { get; set; }
    
    public virtual ICollection<Ranger> Rangers { get; set; }
    public virtual ICollection<Type> Types { get; set; }
}