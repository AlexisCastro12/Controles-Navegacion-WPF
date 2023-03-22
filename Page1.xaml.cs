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
using System.Windows.Threading;

namespace WPFControlesYNavegacion
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
		public Page1()
		{
			InitializeComponent();
			DispatcherTimer timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromSeconds(1);
			timer.Tick += timer_Tick;
			timer.Start();
			SldStatus.Maximum = 13;
			SldStatus1.Maximum = 9;
		}

		void timer_Tick(object sender, EventArgs e)
		{
			if (Video.NaturalDuration.HasTimeSpan)
				TxtStatus.Text = String.Format("{0} / {1}", Video.Position.ToString(@"mm\:ss"), Video.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
			if (Video1.NaturalDuration.HasTimeSpan)
				TxtStatus1.Text = String.Format("{0} / {1}", Video1.Position.ToString(@"mm\:ss"), Video1.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));

			SldStatus.Value = Video.Position.TotalSeconds;
			SldStatus1.Value = Video1.Position.TotalSeconds;
		}
		private void btnPlay_Click(object sender, RoutedEventArgs e)
		{
			Video.Play();
		}

		private void btnPause_Click(object sender, RoutedEventArgs e)
		{
			Video.Pause();
		}

		private void btnStop_Click(object sender, RoutedEventArgs e)
		{
			Video.Stop();
		}

		private void SldStatus_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
			Video.Position = ts;
		}

		//
		private void btnPlay1_Click(object sender, RoutedEventArgs e)
		{
			Video1.Play();
		}

		private void btnPause1_Click(object sender, RoutedEventArgs e)
		{
			Video1.Pause();
		}

		private void btnStop1_Click(object sender, RoutedEventArgs e)
		{
			Video1.Stop();
		}

		private void SldStatus1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
			Video1.Position = ts;
		}
	}
}
