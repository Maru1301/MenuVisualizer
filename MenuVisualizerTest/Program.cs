using MenuVisualizer;
using MenuVisualizer.Model;

namespace MenuVisualizerTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var menu = new Menu()
            {
                Name = "Test",
                Descriptions = 
                [
                    "Description"
                ],
                Options = 
                [
                    new SubMenuOption
                    {
                        Name = "Sub",
                        SubMenu =  new Menu()
                        {
                            Name = "Test",
                            Descriptions =
                            [
                                "Description"
                            ],
                        }
                    }
                ]
            };

            var manager = new ConsoleMenuManager();
            manager.Construct(menu);

            await manager.ShowAsync();
        }
    }
}
