using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Avalonia.VisualTree;

namespace TestColoredRectangle
{
    public class UnitTest1
    {
        [Fact]
        public async void TestKhaki()
        {
            //получаем ссылку на приложение
            var app = AvaloniaApp.GetApp();
            //поллучаем ссылку на окно, приложения
            var mainWindow = AvaloniaApp.GetMainWindow();
            //ожидаемое значение цвета
            Color c = Colors.Khaki;

            await Task.Delay(100);

            //получаем ссылку на первую кнопку в окне с подходящим именем
            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonKhaki");
            //получаем ссылку на первый попавшийся премоугольник
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            //нажатие на кнопку
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            //получение цвета прямоугольника
            var rectColor = ((rectangle.Fill as SolidColorBrush).Color);

            Assert.True(rectColor.Equals(c));
        }
        [Fact]
        public async void TestRed()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            Color c = Colors.Red;

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonRed");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            var rectColor = ((rectangle.Fill as SolidColorBrush).Color);

            Assert.True(rectColor.Equals(c));
        }
        [Fact]
        public async void TestMediumVioletRed()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            Color c = Colors.MediumVioletRed;

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonMediumVioletRed");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            var rectColor = ((rectangle.Fill as SolidColorBrush).Color);

            Assert.True(rectColor.Equals(c));
        }
        [Fact]
        public async void TestBisque()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            Color c = Colors.Bisque;

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonBisque");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            var rectColor = ((rectangle.Fill as SolidColorBrush).Color);

            Assert.True(rectColor.Equals(c));
        }
        [Fact]
        public async void TestLemonChiffon()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            Color c = Colors.LemonChiffon;

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonLemonChiffon");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            var rectColor = ((rectangle.Fill as SolidColorBrush).Color);

            Assert.True(rectColor.Equals(c));
        }
        [Fact]
        public async void TestPowderBlue()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            Color c = Colors.PowderBlue;

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonPowderBlue");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            var rectColor = ((rectangle.Fill as SolidColorBrush).Color);

            Assert.True(rectColor.Equals(c));
        }
        [Fact]
        public async void TestMintCream()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            Color c = Colors.MintCream;

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonMintCream");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            var rectColor = ((rectangle.Fill as SolidColorBrush).Color);

            Assert.True(rectColor.Equals(c));
        }
        [Fact]
        public async void TestMaroon()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            Color c = Colors.Maroon;

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonMaroon");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            var rectColor = ((rectangle.Fill as SolidColorBrush).Color);

            Assert.True(rectColor.Equals(c));
        }
        [Fact]
        public async void TestRosyBrown()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            Color c = Colors.RosyBrown;

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonRosyBrown");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            var rectColor = ((rectangle.Fill as SolidColorBrush).Color);

            Assert.True(rectColor.Equals(c));
        }
        [Fact]
        public async void TestLightPink()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            Color c = Colors.LightPink;

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonLightPink");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            var rectColor = ((rectangle.Fill as SolidColorBrush).Color);

            Assert.True(rectColor.Equals(c));
        }
    }
}