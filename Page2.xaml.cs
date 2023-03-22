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
using System.Reflection;

namespace WPFControlesYNavegacion
{
    /// <summary>
    /// Lógica de interacción para Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void BtnWeb1_Click(object sender, RoutedEventArgs e)
        {
            web1.Navigate("https://www.ipn.mx/");
            HideScriptErrors(web1, true);
        }

        private void BtnWeb2_Click(object sender, RoutedEventArgs e)
        {
            web1.Navigate("https://www.esimez.ipn.mx/");
            HideScriptErrors(web1, true);
        }

        private void BtnWeb3_Click(object sender, RoutedEventArgs e)
        {
            web1.Navigate("https://www.saes.esimez.ipn.mx/");
            HideScriptErrors(web1, true);
        }

        public void HideScriptErrors(WebBrowser wb, bool hide)
        {
            var fiComWebBrowser = typeof(WebBrowser).GetField("_axIWebBrowser2", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fiComWebBrowser == null) return;
            var objComWebBrowser = fiComWebBrowser.GetValue(wb);
            if (objComWebBrowser == null)
            {
                wb.Navigated += (o, s) => HideScriptErrors(wb, hide);
                return;
            }
            objComWebBrowser.GetType().InvokeMember("Silent", BindingFlags.SetProperty, null, objComWebBrowser, new object[] { hide });
        }
    }
}
