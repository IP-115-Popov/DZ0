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

        public void ClickColorBut() => RectangleColor = "Red";
    }
}
