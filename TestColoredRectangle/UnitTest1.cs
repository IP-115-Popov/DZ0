using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Avalonia.VisualTree;

namespace TestColoredRectangle
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            Color c = Colors.Red;

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonRed");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();

            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);

            var rectColor = (Color?)(rectangle.Fill as SolidColorBrush).Color;

            Assert.True(rectColor.Equals(c));
        }
    }
}