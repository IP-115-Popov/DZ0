using Avalonia.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ColoredRectangle.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        string rectangleColor = "LightGray";   
        public string RectangleColor
        {
            get => rectangleColor;
            set
            {
                rectangleColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RectangleColor)));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public void ClickColorButKhaki() => RectangleColor = "Khaki";
        public void ClickColorButRed() => RectangleColor = "Red";
        public void ClickColorButMediumVioletRed() => RectangleColor = "MediumVioletRed";
        public void ClickColorButBisque() => RectangleColor = "Bisque";
        public void ClickColorButLemonChiffon() => RectangleColor = "LemonChiffon";
        public void ClickColorButPowderBlue() => RectangleColor = "PowderBlue";
        public void ClickColorButMintCream() => RectangleColor = "MintCream";
        public void ClickColorButMaroon() => RectangleColor = "Maroon";
        public void ClickColorButRosyBrown() => RectangleColor = "RosyBrown";
        public void ClickColorButLightPink() => RectangleColor = "LightPink";
    }
}
