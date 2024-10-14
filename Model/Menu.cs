using MenuVisualizer.Model.Interface;

namespace MenuVisualizer.Model;

public class Menu : IMenu
{
    public string Name { get; set; } = string.Empty;
    public List<IOption> Options { get; set; } = [];
}
