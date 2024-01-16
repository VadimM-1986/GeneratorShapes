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

namespace WpfAppTEST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
 
        private void GeneratorShapes()
        {
            // Очищаем экран
            myCanvas.Children.Clear();

            Random rnd = new Random();
            // Расположение для треугольника и четырехугольника:
            int xRnd = rnd.Next(0, 500);

            // RND размеров
            int sizeRnd = rnd.Next(30, 100);



            // Создаем и добавляем круг
            Ellipse ellipse = CreateEllipse(rnd.Next(100, 600), rnd.Next(100, 500), sizeRnd, sizeRnd, Brushes.Orange);
            myCanvas.Children.Add(ellipse);

            // Создаем и добавляем эллипс
            ellipse = CreateEllipse(rnd.Next(100, 600), rnd.Next(100, 500), sizeRnd, sizeRnd + 40, Brushes.Green);
            myCanvas.Children.Add(ellipse);

            // Создаем и добавляем квадрат
            Rectangle rectangle = CreateRectangle(rnd.Next(100, 600), rnd.Next(100, 500), sizeRnd, sizeRnd, Brushes.Blue);
            myCanvas.Children.Add(rectangle);

            // Создаем и добавляем треугольник
            Polygon triangle = CreateTriangle(xRnd, xRnd + 100, xRnd + 50, xRnd + 100, xRnd + 25, xRnd + 150, Brushes.Red);
            myCanvas.Children.Add(triangle);

            // Создаем и добавляем четырехугольник
            Polygon quadrilateral = CreateQuadrilateral(xRnd, xRnd - 100, xRnd + 100, xRnd - 100, xRnd + 140, xRnd - 50, xRnd + 60, xRnd - 30, Brushes.Purple);
            myCanvas.Children.Add(quadrilateral);

        }


        private Ellipse CreateEllipse(int x, int y, int width, int height, Brush brush)
        {
            Ellipse ellipse = new Ellipse
            {
                Width = width,
                Height = height,
                Fill = brush,
            };

            Canvas.SetLeft(ellipse, x);
            Canvas.SetTop(ellipse, y);

            return ellipse;
        }

        private Rectangle CreateRectangle(int x, int y, int width, int height, Brush brush)
        {
            Rectangle rectangle = new Rectangle
            {
                Width = width,
                Height = height,
                Fill = brush,
            };

            Canvas.SetLeft(rectangle, x);
            Canvas.SetTop(rectangle, y);

            return rectangle;
        }

        private Polygon CreateTriangle(int x1, int y1, int x2, int y2, int x3, int y3, Brush brush)
        {
            Polygon triangle = new Polygon
            {

                Points = new PointCollection { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3) },
                Fill = brush,
            };

            return triangle;
        }

        private Polygon CreateQuadrilateral(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, Brush brush)
        {
            Polygon quadrilateral = new Polygon
            {
                Points = new PointCollection { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4) },
                Fill = brush,
            };

            return quadrilateral;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GeneratorShapes();
        }
    }
}
