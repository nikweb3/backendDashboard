using ViadexDashboard.Data;
using ViadexDashboard.Interfaces;

public class ComponentService : IComponentService
{
    private readonly AppDbContext _context;

    public ComponentService(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Component> GetAllComponents()
    {
        var components = _context.Components
                                 .Select(c => new Component
                                 {
                                     Id = c.Id,
                                     Name = c.Name,
                                     Type = c.Type,
                                     CreatedAt = c.CreatedAt,
                                     UpdatedAt = c.UpdatedAt,
                                     HtmlContent = _context.ComponentHtmls
                                                            .Where(h => h.ComponentId == c.Id)
                                                            .ToList(),
                                     CssContent = _context.ComponentCss
                                                           .Where(cs => cs.ComponentId == c.Id)
                                                           .ToList(),
                                     JsContent = _context.ComponentJs
                                                          .Where(js => js.ComponentId == c.Id)
                                                          .ToList()
                                 }).ToList();

        return components;
    }


    public Component? GetComponentById(int id) => _context.Components
        .FirstOrDefault(c => c.Id == id);

    public void AddComponent(Component component)
    {
        _context.Components.Add(component);
        _context.SaveChanges(); 
    }

    public void UpdateComponent(Component component)
    {
        _context.Components.Update(component);
        _context.SaveChanges();
    }

    public void DeleteComponent(int id)
    {
        var component = _context.Components.Find(id);
        if (component != null)
        {
            _context.Components.Remove(component);
            _context.SaveChanges();
        }
    }

    public void AddComponentContent(Component component)
    {
        // Add content manually
        if (component.HtmlContent != null && component.HtmlContent.Count > 0)
        {
            foreach (var html in component.HtmlContent)
            {
                html.ComponentId = component.Id; // Ensure the ComponentId is set manually
                _context.ComponentHtmls.Add(html);
            }
        }

        if (component.CssContent != null && component.CssContent.Count > 0)
        {
            foreach (var css in component.CssContent)
            {
                css.ComponentId = component.Id; // Ensure the ComponentId is set manually
                _context.ComponentCss.Add(css);
            }
        }

        if (component.JsContent != null && component.JsContent.Count > 0)
        {
            foreach (var js in component.JsContent)
            {
                js.ComponentId = component.Id; // Ensure the ComponentId is set manually
                _context.ComponentJs.Add(js);
            }
        }

        _context.SaveChanges(); // Save all content
    }

}
