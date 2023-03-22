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
using System.IO;

namespace WPFControlesYNavegacion
{
    /// <summary>
    /// Lógica de interacción para Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {

        public Page3()
        {
            InitializeComponent();
        }

        private void BtnDocumento_Click(object sender, RoutedEventArgs e)
        {
            web2.Visibility = Visibility.Visible;
            VerXPS.Visibility = Visibility.Hidden;

            web2.Navigate(Directory.GetCurrentDirectory() + "\\ejemplo.pdf");
        }

        private void BtnDocumento2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Doc2.docx");
        }

    }
}
