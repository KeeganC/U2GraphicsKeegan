using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U2GraphicsKeegan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Line myLine = CreateLine(10,10,65,10);

            //In MainWindow.xaml set x:Name of canvas to myGrid
            myGrid.Children.Add(CreateLine(10, 10, 65, 10)); 
            myGrid.Children.Add(CreateLine(10, 65, 10, 10));
            myGrid.Children.Add(CreateLine(65, 65, 10, 65));
            myGrid.Children.Add(CreateLine(10, 65, 65, 65));

            myGrid.Children.Add(CreateLine(10, 10, 65, 10));
            myGrid.Children.Add(CreateLine(10, 65, 10, 10));
            myGrid.Children.Add(CreateLine(65, 65, 10, 65));
            myGrid.Children.Add(CreateLine(10, 65, 65, 65));

            Line TopLine = new Line();
            TopLine.X1 = 10;
            TopLine.Y1 = 10;
            TopLine.X2 = 65;
            TopLine.Y2 = 10;
        }

        private static Line CreateLine(double x1, double x2, double y1, double y2)
        {
            Line myLine = new Line();
            myLine.Stroke = System.Windows.Media.Brushes.Purple;
            myLine.X1 = x1;
            myLine.X2 = x2;
            myLine.Y1 = y1;
            myLine.Y2 = y2;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 5;
            return myLine;
        }
    }
}
