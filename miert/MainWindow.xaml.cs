using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;
using System.IO;
using HelixToolkit.Wpf;

namespace miert
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Gyongy> gyongyok = File.ReadAllLines("gyongyok.txt").Skip(1).Select(x => new Gyongy(x)).ToList();
        public MainWindow()
        {
            InitializeComponent();
            btnGomb.Click += (s,e) => 
            {
                General();
            };


            

        }
        public void General()
        {
            gyongyok.ForEach(x =>
            {
                Random rnd = new();
                EllipsoidVisual3D gyongy3D = new();
                gyongy3D.RadiusX = rnd.Next(0, 20);
                gyongy3D.RadiusY = rnd.Next(0, 20);
                gyongy3D.RadiusZ = rnd.Next(0, 20);
                gyongy3D.Center = new Point3D(x.X, x.Z, x.Y);
                gyongy3D.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)));



                ter.Children.Add(gyongy3D);
            });
        }
    }
}