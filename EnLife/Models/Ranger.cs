namespace EnLife.Models;

public class Ranger
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int BugdeNo { get; set; }
    public int GroudId { get; set; }
    
    public virtual  ICollection<Group> Groups { get; set; }
}