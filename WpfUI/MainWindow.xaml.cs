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
using MediumLib;

namespace WpfUI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			if (!Controller.Setup())
			{
				MessageBox.Show("An error occurred during setup. Closing program.");
				Close();
			}
		}

		/// <summary>
		/// on click, generate & display prophecy.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GetProphecyButton_Click(object sender, RoutedEventArgs e)
		{
			DisplayProphecy(Controller.CreateProphecy());

			TextOutput.Text = prophecy.Text;
			BitmapImage image = new BitmapImage(new Uri(prophecy.ImagePath, UriKind.RelativeOrAbsolute));
			MainGrid.Background = new ImageBrush(image);
		}

		/// <summary>
		/// on click, close program.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		/// <summary>
		/// display prophecy in UI.
		/// </summary>
		/// <param name="prophecy">prophecy to be displayed.</param>
		private void DisplayProphecy(Prophecy prophecy)
		{
			TextOutput.Text = prophecy.Text;
			MainGrid.Background = prophecy.Image;
		}
	}
}
