using ViadexDashboard.Models;

public class Component
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public ICollection<ComponentHtml>? HtmlContent { get; set; }
    public ICollection<ComponentCss>? CssContent { get; set; }
    public ICollection<ComponentJs>? JsContent { get; set; }
}