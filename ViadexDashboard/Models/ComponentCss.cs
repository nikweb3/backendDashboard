using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class ComponentCss
{
    public int Id { get; set; }
    public int ComponentId { get; set; }
    public string Css { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}