using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class ComponentHtml
{
    public int Id { get; set; }
    public int ComponentId { get; set; }
    public string Html { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}