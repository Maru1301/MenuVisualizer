using MenuVisualizer.Model.Interface;

namespace MenuVisualizer.Model;

public class FunctionOption : IOption
{
    public string Name { get; set; } = string.Empty;

    public required Delegate Func { get; set; }

    public Menu? AfterFuncSubMenu = new();
}
