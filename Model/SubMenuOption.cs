using MenuVisualizer.Model.Interface;

namespace MenuVisualizer.Model;

public class SubMenuOption : IOption
{
    public string Name { get; set; } = string.Empty;
    public Menu? SubMenu { get; set; }
}
