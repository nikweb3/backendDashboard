using ViadexDashboard.Models;

namespace ViadexDashboard.Interfaces
{
    public interface IComponentService
    {
        IEnumerable<Component> GetAllComponents();
        Component? GetComponentById(int id);
        void AddComponent(Component component);
        void UpdateComponent(Component component);
        void DeleteComponent(int id);
        void AddComponentContent(Component component);
    }
}
