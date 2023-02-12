using Avalonia.Data;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ColoredRectangle.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        SolidColorBrush rectangleColor = new SolidColorBrush(Colors.LightGray);//"LightGray";   
        public SolidColorBrush RectangleColor
        {
            get => rectangleColor;
            set
            {
                rectangleColor = value;
                //оповещяем подпищиков, ивента о изменении своиства RectangleColor
                //непонятна кто подпищики
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RectangleColor)));
            }
        }
        //создаем ивент PropertyChanged от делегата PropertyChangedEventHandler?
        //непонятно что за делегат
        public event PropertyChangedEventHandler? PropertyChanged;

        public void ClickColorButKhaki() => RectangleColor = new SolidColorBrush(Colors.Khaki);
        public void ClickColorButRed() => RectangleColor = new SolidColorBrush(Colors.Red);
        public void ClickColorButMediumVioletRed() => RectangleColor = new SolidColorBrush(Colors.MediumVioletRed);
        public void ClickColorButBisque() => RectangleColor = new SolidColorBrush(Colors.Bisque);
        public void ClickColorButLemonChiffon() => RectangleColor = new SolidColorBrush(Colors.LemonChiffon);
        public void ClickColorButPowderBlue() => RectangleColor = new SolidColorBrush(Colors.PowderBlue);
        public void ClickColorButMintCream() => RectangleColor = new SolidColorBrush(Colors.MintCream);
        public void ClickColorButMaroon() => RectangleColor = new SolidColorBrush(Colors.Maroon);
        public void ClickColorButRosyBrown() => RectangleColor = new SolidColorBrush(Colors.RosyBrown);
        public void ClickColorButLightPink() => RectangleColor = new SolidColorBrush(Colors.LightPink);
    }
}
