using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class ComponentJs
{
    public int Id { get; set; }
    public int ComponentId { get; set; }
    public string Js { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}