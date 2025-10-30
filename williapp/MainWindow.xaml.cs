
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace williapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color strokeColor = Colors.Black;
        Color fillColor = Colors.Transparent;
        int strokeThickness = 1;
        string actionType = "Draw";
        string shapeType = "Line";
        Point start, end;
        public MainWindow()
        {
            InitializeComponent();
            outline.SelectedColor = strokeColor;
            inner.SelectedColor = fillColor;
            
        }

    }
}
