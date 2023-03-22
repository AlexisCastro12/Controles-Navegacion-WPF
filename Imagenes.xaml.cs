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
using System.Windows.Shapes;
using System.Drawing.Imaging;

namespace WPFControlesYNavegacion
{
    /// <summary>
    /// Lógica de interacción para Imagenes.xaml
    /// </summary>
    public partial class Imagenes : Window
    {
        public Imagenes()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Castro.exe");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Cargar_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog Abrir = new System.Windows.Forms.OpenFileDialog();
            Abrir.Filter = "";

            ImageCodecInfo[] codecsImagenes = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty;
            foreach (var c in codecsImagenes)
            {
                string Tiposcodec = c.CodecName.Substring(8).Replace("Codec", "Archivos").Trim();
                Abrir.Filter = string.Format("{0}{1}{2} ({3})|{3}", Abrir.Filter, sep, Tiposcodec, c.FilenameExtension);
                sep = "|";
            }

            Abrir.Filter = String.Format("{0}{1}{2} ({3})|{3}", Abrir.Filter, sep, "All Files", "*.*");

            MessageBox.Show("¡Recuerda colocar el filtro con la extensión o tipo de imagen que deseas abrir!");

            if (Abrir.ShowDialog().ToString() == "OK")
            {
                Uri UriArchivo = new Uri(Abrir.FileName, UriKind.RelativeOrAbsolute);
                ImgCargada.Source = new BitmapImage(UriArchivo);
                ImgCargada2.Source = new BitmapImage(UriArchivo);
                ImgCargada3.Source = new BitmapImage(UriArchivo);
                ImgCargada4.Source = new BitmapImage(UriArchivo);
            }
        }
    }
}
