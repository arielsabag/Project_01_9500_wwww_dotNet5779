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
using BL; 

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		bool[][] A = new bool[6][5];
		//private BE.Tester be = new BE.Tester();
		BE.Address a;
		private BL.IBL bl = new BL.Bl_imp();
		public MainWindow()
		{
			InitializeComponent();

		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			bl.addTester(new BE.Tester(1,"a","aa",DateTime.Now,BE.Gender.Male,1,a,1,1, BE.CarType.HeavyTruck,A,1));
		}
	}
}
