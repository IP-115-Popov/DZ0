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
            //получаем ссылку на приложение
            var app = AvaloniaApp.GetApp();
            //поллучаем ссылку на окно, приложения
            var mainWindow = AvaloniaApp.GetMainWindow();
            //ожидаемое значение цвета
            Color c = Colors.Red;

            await Task.Delay(100);

            //получаем ссылку на первую кнопку в окне с подходящим именем
            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonRed");
            //получаем ссылку на первый попавшийся премоугольник
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            //нажатие на кнопку
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            //получение цвета прямоугольника
            var rectColor = ((rectangle.Fill as SolidColorBrush).Color);

            Assert.True(rectColor.Equals(c));
        }
    }
}