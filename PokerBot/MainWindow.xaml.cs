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

namespace PokerBot
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

        private void StartButton_Click( object sender, RoutedEventArgs e )
        {

        }

        private void DebugButton_Click( object sender, RoutedEventArgs e )
        {
            Point topLeft = Viewport.PointToScreen(new Point(0,0));
            double width = Viewport.ActualWidth;
            double height = Viewport.ActualHeight;

            MessageBoxResult msgBox = MessageBox.Show(string.Format("Top left: {0}, Width: {1}, Height: {2}", topLeft.ToString(), width, height));
        }

        private void ExitButton_Click( object sender, RoutedEventArgs e )
        {
            Application.Current.Shutdown();
        }

        private void MainWindow1_MouseDown( object sender, MouseButtonEventArgs e )
        {
            if ( e.ChangedButton == MouseButton.Left )
                this.DragMove();
        }
    }
}
