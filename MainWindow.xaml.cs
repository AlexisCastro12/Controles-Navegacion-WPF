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

namespace WPFControlesYNavegacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnVentana1_Click(object sender, RoutedEventArgs e)
        {
            //Ventana 1
            Window1 Vent1 = new Window1();
            Vent1.ShowDialog();
        }

        private void BtnFormulario_Click(object sender, RoutedEventArgs e)
        {
            Form1 formulario1 = new Form1();
            formulario1.ShowDialog();
        }

        private void BtnPag1_Click(object sender, RoutedEventArgs e)
        {
            Frame1.NavigationService.Navigate(new Page1());
        }

        private void BtnPag2_Click(object sender, RoutedEventArgs e)
        {
            Frame1.NavigationService.Navigate(new Page2());
        }

        private void BtnPag3_Click(object sender, RoutedEventArgs e)
        {
            Frame1.NavigationService.Navigate(new Page3());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Castro.exe");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Imagenes Vent2 = new Imagenes();
            Vent2.ShowDialog();
        }
    }
}
