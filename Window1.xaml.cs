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
using System.Windows.Threading;

namespace WPFControlesYNavegacion
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            SldStatus.Maximum = 197;
            SldStatus1.Maximum = 260;
            SldStatus2.Maximum = 363;
            SldStatus3.Maximum = 455;
            SldStatus4.Maximum = 249;
            SldStatus5.Maximum = 196;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (Audio.NaturalDuration.HasTimeSpan)
                TxtStatus.Text = String.Format("{0} / {1}", Audio.Position.ToString(@"mm\:ss"), Audio.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            if (Audio1.NaturalDuration.HasTimeSpan)
                TxtStatus1.Text = String.Format("{0} / {1}", Audio1.Position.ToString(@"mm\:ss"), Audio1.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            if (Audio2.NaturalDuration.HasTimeSpan)
                TxtStatus2.Text = String.Format("{0} / {1}", Audio2.Position.ToString(@"mm\:ss"), Audio2.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            if (Audio3.NaturalDuration.HasTimeSpan)
                TxtStatus3.Text = String.Format("{0} / {1}", Audio3.Position.ToString(@"mm\:ss"), Audio3.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            if (Audio4.NaturalDuration.HasTimeSpan)
                TxtStatus4.Text = String.Format("{0} / {1}", Audio4.Position.ToString(@"mm\:ss"), Audio4.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            if (Audio5.NaturalDuration.HasTimeSpan)
                TxtStatus5.Text = String.Format("{0} / {1}", Audio5.Position.ToString(@"mm\:ss"), Audio5.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));

            SldStatus.Value = Audio.Position.TotalSeconds;
            SldStatus1.Value = Audio1.Position.TotalSeconds;
            SldStatus2.Value = Audio2.Position.TotalSeconds;
            SldStatus3.Value = Audio3.Position.TotalSeconds;
            SldStatus4.Value = Audio4.Position.TotalSeconds;
            SldStatus5.Value = Audio5.Position.TotalSeconds;
        }
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            Audio.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            Audio.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            Audio.Stop();
        }

        //
        private void btnPlay1_Click(object sender, RoutedEventArgs e)
        {
            Audio1.Play();
        }

        private void btnPause1_Click(object sender, RoutedEventArgs e)
        {
            Audio1.Pause();
        }

        private void btnStop1_Click(object sender, RoutedEventArgs e)
        {
            Audio1.Stop();
        }

        //
        private void btnPlay2_Click(object sender, RoutedEventArgs e)
        {
            Audio2.Play();
        }

        private void btnPause2_Click(object sender, RoutedEventArgs e)
        {
            Audio2.Pause();
        }

        private void btnStop2_Click(object sender, RoutedEventArgs e)
        {
            Audio2.Stop();
        }

        //
        private void btnPlay3_Click(object sender, RoutedEventArgs e)
        {
            Audio3.Play();
        }

        private void btnPause3_Click(object sender, RoutedEventArgs e)
        {
            Audio3.Pause();
        }

        private void btnStop3_Click(object sender, RoutedEventArgs e)
        {
            Audio3.Stop();
        }

        //
        private void btnPlay4_Click(object sender, RoutedEventArgs e)
        {
            Audio4.Play();
        }

        private void btnPause4_Click(object sender, RoutedEventArgs e)
        {
            Audio4.Pause();
        }

        private void btnStop4_Click(object sender, RoutedEventArgs e)
        {
            Audio4.Stop();
        }

        //
        private void btnPlay5_Click(object sender, RoutedEventArgs e)
        {
            Audio5.Play();
        }

        private void btnPause5_Click(object sender, RoutedEventArgs e)
        {
            Audio5.Pause();
        }

        private void btnStop5_Click(object sender, RoutedEventArgs e)
        {
            Audio5.Stop();
        }

        private void SldStatus_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            Audio.Position = ts;
        }

        //
        private void SldStatus1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            Audio1.Position = ts;
        }

        //
        private void SldStatus2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            Audio2.Position = ts;
        }

        //
        private void SldStatus3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            Audio3.Position = ts;
        }

        //
        private void SldStatus4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            Audio4.Position = ts;
        }

        //
        private void SldStatus5_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            Audio5.Position = ts;
        }


        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Close();
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
    }
}
