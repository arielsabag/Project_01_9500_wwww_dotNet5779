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


namespace PL
{
	public static class AAAA
	{

		public static T ToEnum<T>(this string enumString)
		{
			return (T)Enum.Parse(typeof(T), enumString);
		}
		public static T ToCar<T>(this string enumString)
		{
			return (T)Enum.Parse(typeof(T), enumString);
		}
		public static T ToAddress<T>(this string enumString)
		{
			return (T)Enum.Parse(typeof(T), enumString);
		}

	}
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		BL.IBL bl = new BL.Bl_imp();

		public MainWindow()
		{
			
			InitializeComponent();
			
			try
			{
				genderTesterComboBox.Items.Add(BE.Gender.Male);
				genderTesterComboBox.Items.Add(BE.Gender.Female);
				TraineeGenderToAdd.Items.Add(BE.Gender.Male);
				TraineeGenderToAdd.Items.Add(BE.Gender.Female);
				genderTesterComboBoxToUpdate.Items.Add(BE.Gender.Male);
				genderTesterComboBoxToUpdate.Items.Add(BE.Gender.Female);
				TraineegenderToUpdate.Items.Add(BE.Gender.Male);
				TraineegenderToUpdate.Items.Add(BE.Gender.Female);

				carTypeSpcializesComboBox.Items.Add(BE.CarType.HeavyTruck);
				carTypeSpcializesComboBox.Items.Add(BE.CarType.MediumTruck);
				carTypeSpcializesComboBox.Items.Add(BE.CarType.PrivateVehicle);
				carTypeSpcializesComboBox.Items.Add(BE.CarType.TwoWheeledVehicle);
				carTypeSpcializesComboBoxToUpdate.Items.Add(BE.CarType.HeavyTruck);
				carTypeSpcializesComboBoxToUpdate.Items.Add(BE.CarType.MediumTruck);
				carTypeSpcializesComboBoxToUpdate.Items.Add(BE.CarType.PrivateVehicle);
				carTypeSpcializesComboBoxToUpdate.Items.Add(BE.CarType.TwoWheeledVehicle);

				TraineeTypeOfVehicleHeStudiedToAdd.Items.Add(BE.CarType.HeavyTruck);
				TraineeTypeOfVehicleHeStudiedToAdd.Items.Add(BE.CarType.MediumTruck);
				TraineeTypeOfVehicleHeStudiedToAdd.Items.Add(BE.CarType.PrivateVehicle);
				TraineeTypeOfVehicleHeStudiedToAdd.Items.Add(BE.CarType.TwoWheeledVehicle);
				TraineeTypeOfVihecleStudiedToUpdate.Items.Add(BE.CarType.HeavyTruck);
				TraineeTypeOfVihecleStudiedToUpdate.Items.Add(BE.CarType.MediumTruck);
				TraineeTypeOfVihecleStudiedToUpdate.Items.Add(BE.CarType.PrivateVehicle);
				TraineeTypeOfVihecleStudiedToUpdate.Items.Add(BE.CarType.TwoWheeledVehicle);

				TraineeTypeOfGearToAdd.Items.Add(BE.GearboxType.Automatic);
				TraineeTypeOfGearToAdd.Items.Add(BE.GearboxType.Manual);
				TraineeTypeOfGearToUpdate.Items.Add(BE.GearboxType.Automatic);
				TraineeTypeOfGearToUpdate.Items.Add(BE.GearboxType.Manual);
				bool[][] temp = new bool[7][];
				for (int i = 0; i < 7; i++)
				{
					temp[i] = new bool[5];
				}
				bl.addTester(new BE.Tester("205829500", "A", "h", new DateTime(1000, 11, 07), new BE.Gender() { }, 222, new BE.Address() { street = "Yoseftal", buildingNumber = 48 / 1, city = "Zefat" }, 333, 555, new BE.CarType(), temp, 444));
				bl.addTester(new BE.Tester("062839360", "a", "b", new DateTime(1960, 1, 1), new BE.Gender(), 222, new BE.Address(), 333, 555, new BE.CarType(), temp, 444));
				bl.addTester(new BE.Tester("066416611", "a", "b", new DateTime(1960, 1, 1), new BE.Gender(), 222, new BE.Address(), 333, 555, new BE.CarType(), temp, 444));
				
				bl.addTrainee(new BE.Trainee("330886284", new DateTime(2018, 12, 29), "a", "b", new BE.Gender(), 222, new BE.Address() { street = "a", buildingNumber = 99 / 1, city = "m" }, new DateTime(1960, 1, 1), new BE.CarType(), new BE.GearboxType(), "sss", "eeee", 888));
				bl.addTrainee(new BE.Trainee("217984749", new DateTime(1960, 1, 1), "a", "b", new BE.Gender(), 222, new BE.Address() { street = "a", buildingNumber = 99 / 1, city = "m" }, new DateTime(1960, 1, 1), new BE.CarType(), new BE.GearboxType(), "sss", "eeee", 444));
				bl.addTrainee(new BE.Trainee("335746962", new DateTime(1960, 1, 1), "a", "b", new BE.Gender(), 222, new BE.Address() { street = "a", buildingNumber = 99 / 1, city = "m" }, new DateTime(1960, 1, 1), new BE.CarType(), new BE.GearboxType(), "sss", "eeee", 444));

				bl.addTest(new BE.Test(BE.Configuration.RunningIDNumber, "205829500" , "330886284", new DateTime(1960, 1, 1), new DateTime(1960, 1, 1), new BE.Address(), false, true, false, false, false, "comment"));
				bl.addTest(new BE.Test(BE.Configuration.RunningIDNumber, "062839360", "217984749", new DateTime(1961, 1, 2), new DateTime(1969, 1, 1), new BE.Address(), false, false, false, false, true, "comment"));
				bl.addTest(new BE.Test(BE.Configuration.RunningIDNumber, "066416611" , "335746962" , new DateTime(1962, 1, 3), new DateTime(1963, 1, 8), new BE.Address(), false, false, false, false, true, "comment"));
				

				TestDistancekeepToUpdate.Items.Add(BE.boolean.True);
				TestDistancekeepToUpdate.Items.Add(BE.boolean.False);

				TestParkingInReverseToUpdate.Items.Add(BE.boolean.True);
				TestParkingInReverseToUpdate.Items.Add(BE.boolean.False);
				TestLookingAtMirrorsToUpdate.Items.Add(BE.boolean.True);
				TestLookingAtMirrorsToUpdate.Items.Add(BE.boolean.False);
				TestSignalsToUpdate.Items.Add(BE.boolean.True);
				TestSignalsToUpdate.Items.Add(BE.boolean.False);
				TestScoreToUpdate.Items.Add(BE.boolean.True);
				TestScoreToUpdate.Items.Add(BE.boolean.False);


		

			}
			catch (Exception e)
			{

				MessageBox.Show(e.Message);
			}

		}
		//private static bool IDValidator(int id)
		//{
		//	string strId = Convert.ToString(id);
		//	if (strId.Length != 9)
		//		return false;
		//	int counter = 0, incNum = 0;
		//	for (int i = 0; i < 8; i++)
		//	{
		//		incNum = (Convert.ToInt32(strId[i].ToString())) * ((i % 2) + 1);//multiply digit by 1 or 2
		//		if (incNum > 9)//sum the digits up and add to counter
		//		{
		//			counter += incNum - 9;
		//		}
		//		else
		//		{
		//			counter += incNum;
		//		}
		//	}
		//	return (counter % 10 == Convert.ToInt32(strId[8].ToString()));
		//}
		private void AddTesterButton_Click(object sender, RoutedEventArgs e)
		{
			
				bool[][] scheduleAdd = new bool[7][];
				for (int i = 0; i < 7; i++)
				{
					scheduleAdd[i] = new bool[5];
				}
				scheduleAdd[0][0] = c01Add.IsChecked.Value;
				scheduleAdd[1][0] = c11Add.IsChecked.Value;
				scheduleAdd[2][0] = c21Add.IsChecked.Value;
				scheduleAdd[3][0] = c31Add.IsChecked.Value;
				scheduleAdd[4][0] = c41Add.IsChecked.Value;
				scheduleAdd[5][0] = c51Add.IsChecked.Value;
				scheduleAdd[6][0] = c61Add.IsChecked.Value;
				scheduleAdd[0][1] = c02Add.IsChecked.Value;
				scheduleAdd[1][1] = c12Add.IsChecked.Value;
				scheduleAdd[2][1] = c22Add.IsChecked.Value;
				scheduleAdd[3][1] = c32Add.IsChecked.Value;
				scheduleAdd[4][1] = c42Add.IsChecked.Value;
				scheduleAdd[5][1] = c52Add.IsChecked.Value;
				scheduleAdd[6][1] = c62Add.IsChecked.Value;
				scheduleAdd[0][2] = c03Add.IsChecked.Value;
				scheduleAdd[1][2] = c13Add.IsChecked.Value;
				scheduleAdd[2][2] = c23Add.IsChecked.Value;
				scheduleAdd[3][2] = c33Add.IsChecked.Value;
				scheduleAdd[4][2] = c43Add.IsChecked.Value;
				scheduleAdd[5][2] = c53Add.IsChecked.Value;
				scheduleAdd[6][2] = c63Add.IsChecked.Value;
				scheduleAdd[0][3] = c04Add.IsChecked.Value;
				scheduleAdd[1][3] = c14Add.IsChecked.Value;
				scheduleAdd[2][3] = c24Add.IsChecked.Value;
				scheduleAdd[3][3] = c34Add.IsChecked.Value;
				scheduleAdd[4][3] = c44Add.IsChecked.Value;
				scheduleAdd[5][3] = c54Add.IsChecked.Value;
				scheduleAdd[6][3] = c64Add.IsChecked.Value;
				scheduleAdd[0][4] = c05Add.IsChecked.Value;
				scheduleAdd[1][4] = c15Add.IsChecked.Value;
				scheduleAdd[2][4] = c25Add.IsChecked.Value;
				scheduleAdd[3][4] = c35Add.IsChecked.Value;
				scheduleAdd[4][4] = c45Add.IsChecked.Value;
				scheduleAdd[5][4] = c55Add.IsChecked.Value;
				scheduleAdd[6][4] = c65Add.IsChecked.Value;
				DateTime? d = dateOfBirthTester.SelectedDate;
				try
				{
					bl.addTester(new BE.Tester(Convert.ToString(idBox.Text), lastNameBox.Text, firstNameBox.Text, d.Value, new BE.Gender(), Convert.ToInt32(phoneNumberBox.Text), new BE.Address() { street = streetBox.Text, buildingNumber = Convert.ToInt32(buildingNumberBox.Text), city = cityBox.Text }, Convert.ToInt32(yearsOfExperienceBox.Text), Convert.ToInt32(maxWeeklyTestsBox.Text), new BE.CarType(), scheduleAdd, Convert.ToDouble(maxDistanceExamBox.Text)));
					MessageBox.Show("Tester succesfully added");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			
		
		}
		private void DelleteTesterButton_Click(object sender, RoutedEventArgs e)
		{
			int temp = Convert.ToInt32(testerIdToDellete.Text);
			foreach (BE.Tester item in bl.getTestersList())
			{
				if (temp.CompareTo(item.Id)==0)
				{
					bl.delleteTester(item);
					MessageBox.Show("Tester succesfully delleted");
					foreach (BE.Tester x in bl.getTestersList())
					{
						MessageBox.Show(x.ToString()
);
					}
					return;
				}
			}
		}
		private void UpdateTesterButton_Click(object sender, RoutedEventArgs e)
		{
			bool[][] schedule = new bool[7][];
			for (int i = 0; i < 7; i++)
			{
				schedule[i] = new bool[5];
			}
			schedule[0][0] = c01.IsChecked.Value;
			schedule[1][0] = c11.IsChecked.Value;
			schedule[2][0] = c21.IsChecked.Value;
			schedule[3][0] = c31.IsChecked.Value;
			schedule[4][0] = c41.IsChecked.Value;
			schedule[5][0] = c51.IsChecked.Value;
			schedule[6][0] = c61.IsChecked.Value;
			schedule[0][1] = c02.IsChecked.Value;
			schedule[1][1] = c12.IsChecked.Value;
			schedule[2][1] = c22.IsChecked.Value;
			schedule[3][1] = c32.IsChecked.Value;
			schedule[4][1] = c42.IsChecked.Value;
			schedule[5][1] = c52.IsChecked.Value;
			schedule[6][1] = c62.IsChecked.Value;
			schedule[0][2] = c03.IsChecked.Value;
			schedule[1][2] = c13.IsChecked.Value;
			schedule[2][2] = c23.IsChecked.Value;
			schedule[3][2] = c33.IsChecked.Value;
			schedule[4][2] = c43.IsChecked.Value;
			schedule[5][2] = c53.IsChecked.Value;
			schedule[6][2] = c63.IsChecked.Value;
			schedule[0][3] = c04.IsChecked.Value;
			schedule[1][3] = c14.IsChecked.Value;
			schedule[2][3] = c24.IsChecked.Value;
			schedule[3][3] = c34.IsChecked.Value;
			schedule[4][3] = c44.IsChecked.Value;
			schedule[5][3] = c54.IsChecked.Value;
			schedule[6][3] = c64.IsChecked.Value;
			schedule[0][4] = c05.IsChecked.Value;
			schedule[1][4] = c15.IsChecked.Value;
			schedule[2][4] = c25.IsChecked.Value;
			schedule[3][4] = c35.IsChecked.Value;
			schedule[4][4] = c45.IsChecked.Value;
			schedule[5][4] = c55.IsChecked.Value;
			schedule[6][4] = c65.IsChecked.Value;
			
			BE.CarType c = new BE.CarType();
			BE.Gender g = new BE.Gender();
			if (Convert.ToString(BE.CarType.HeavyTruck) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.HeavyTruck;
			}
			if (Convert.ToString(BE.CarType.MediumTruck) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.MediumTruck;
			}
			if (Convert.ToString(BE.CarType.PrivateVehicle) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.PrivateVehicle;
			}
			if (Convert.ToString(BE.CarType.TwoWheeledVehicle) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.TwoWheeledVehicle;
			}
			if (Convert.ToString(BE.Gender.Female) == genderTesterComboBoxToUpdate.Text)
			{
				g = BE.Gender.Female;
			}
			if (Convert.ToString(BE.Gender.Male) == genderTesterComboBoxToUpdate.Text)
			{
				g = BE.Gender.Male;
			}
			BE.Address a = new BE.Address();
			a.street = streetToUpdate.Text;
			a.buildingNumber = Convert.ToInt32(buildingNumberToUpdate.Text);
			a.city = cityToUpdate.Text;
 			try
			{
				BE.Tester toUpdate = new BE.Tester(Convert.ToString(idBoxToUpdate.Text), lastNameBoxToUpdate.Text, firstNameBoxToUpdate.Text, Convert.ToDateTime(dateOfBirthTesterToUpdate.Text), g, Convert.ToInt32(phoneNumberBoxToUpdate.Text), a, Convert.ToInt32(yearsOfExperienceBoxToUpdate.Text), Convert.ToInt32(maxWeeklyTestsBoxToUpdate.Text), c, schedule, Convert.ToInt32(maxDistanceExamBoxToUpdate.Text));
				bl.updateExistTester(toUpdate);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void AddTraineeButton_Click(object sender, RoutedEventArgs e)
		{
			BE.GearboxType tempGearType = new BE.GearboxType();
			BE.CarType tempCarType = new BE.CarType();
			if (Convert.ToString(BE.CarType.HeavyTruck) == TraineeTypeOfVehicleHeStudiedToAdd.Text)
			{
				tempCarType = BE.CarType.HeavyTruck;
			}
			if (Convert.ToString(BE.CarType.MediumTruck) == TraineeTypeOfVehicleHeStudiedToAdd.Text)
			{
				tempCarType = BE.CarType.MediumTruck;
			}
			if (Convert.ToString(BE.CarType.PrivateVehicle) == TraineeTypeOfVehicleHeStudiedToAdd.Text)
			{
				tempCarType = BE.CarType.PrivateVehicle;
			}
			if (Convert.ToString(BE.CarType.TwoWheeledVehicle) == TraineeTypeOfVehicleHeStudiedToAdd.Text)
			{
				tempCarType = BE.CarType.TwoWheeledVehicle;
			}
			if (Convert.ToString(BE.GearboxType.Manual) == TraineeTypeOfGearToAdd.Text)
			{
				tempGearType = BE.GearboxType.Manual;
			}
			if (Convert.ToString(BE.GearboxType.Automatic) == TraineeTypeOfGearToAdd.Text)
			{
				tempGearType = BE.GearboxType.Automatic;
			}
			BE.Gender tempGender = new BE.Gender();
			if (TraineeGenderToAdd.Text=="Male")
			{
				tempGender = BE.Gender.Male;
			}
			else
			{
				tempGender = BE.Gender.Female;
			}
			DateTime? d = TraineedateOfBirthToAdd.SelectedDate;
			try
			{
				bl.addTrainee(new BE.Trainee(Convert.ToString(TraineeIdToAdd.Text),Convert.ToDateTime(TraineeLastTestToAdd.Text), TraineefirstNameToAdd.Text,TraineeLastNameToAdd.Text, tempGender, Convert.ToInt32(TraineePhoneNumberToAdd.Text), new BE.Address() { street = TraineeStreetToAdd.Text, buildingNumber = Convert.ToInt32(TraineeBuildingNumberToAdd.Text), city = TraineeCityToAdd.Text },Convert.ToDateTime(TraineedateOfBirthToAdd.Text), tempCarType,tempGearType, TraineeDrivingSchoolToAdd.Text, TraineeDrivingTeacherToAdd.Text,Convert.ToInt32(TraineeNumberOfDrivingLessonsToAdd.Text)));
			
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void DelleteTraineeButton_Click(object sender, RoutedEventArgs e)
		{
			int temp = Convert.ToInt32(TraineeIdToDellete.Text);
			foreach (BE.Trainee item in bl.getTraineesList())
			{
				if (temp.CompareTo(item.ID)==0)
				{
					bl.delleteTrainee(item);
					MessageBox.Show("Trainee succesfully delleted");
					foreach (BE.Trainee x in bl.getTraineesList())
					{
						MessageBox.Show(x.ToString());
					}
					return;
				}
			}
		}
		private void UpdateTraineeButton_Click(object sender, RoutedEventArgs e)
		{
			BE.GearboxType tempGearType = new BE.GearboxType();
			BE.CarType tempCarType = new BE.CarType();
			if (Convert.ToString(BE.CarType.HeavyTruck) == TraineeTypeOfVihecleStudiedToUpdate.Text)
			{
				tempCarType = BE.CarType.HeavyTruck;
			}
			if (Convert.ToString(BE.CarType.MediumTruck) == TraineeTypeOfVihecleStudiedToUpdate.Text)
			{
				tempCarType = BE.CarType.MediumTruck;
			}
			if (Convert.ToString(BE.CarType.PrivateVehicle) == TraineeTypeOfVihecleStudiedToUpdate.Text)
			{
				tempCarType = BE.CarType.PrivateVehicle;
			}
			if (Convert.ToString(BE.CarType.TwoWheeledVehicle) == TraineeTypeOfVihecleStudiedToUpdate.Text)
			{
				tempCarType = BE.CarType.TwoWheeledVehicle;
			}
			if (Convert.ToString(BE.GearboxType.Manual) == TraineeTypeOfGearToUpdate.Text)
			{
				tempGearType = BE.GearboxType.Manual;
			}
			if (Convert.ToString(BE.GearboxType.Automatic) == TraineeTypeOfGearToUpdate.Text)
			{
				tempGearType = BE.GearboxType.Automatic;
			}
			BE.Gender tempGender = new BE.Gender();
			if (TraineegenderToUpdate.Text == "Male")
			{
				tempGender = BE.Gender.Male;
			}
			else
			{
				tempGender = BE.Gender.Female;
			}
			DateTime? d = TraineeDateOfBirthToUpdate.SelectedDate;
			try
			{
				bl.updateExistTrainee(new BE.Trainee(Convert.ToString(TraineeIdToUpdate.Text), Convert.ToDateTime(TraineeLastTestToUpdate.Text), TraineefirstNameToUpdate.Text, TraineelastNameToUpdate.Text, tempGender, Convert.ToInt32(TraineephoneNumberToUpdate.Text), new BE.Address() { street = TraineeStreetToUpdate.Text, buildingNumber = Convert.ToInt32(TraineeBuildingNumberToUpdate.Text), city = TraineeCityToUpdate.Text }, Convert.ToDateTime(TraineeDateOfBirthToUpdate.Text), tempCarType, tempGearType, TraineeDrivingSchoolToUpdate.Text, TraineeDrivingTeacherToUpdate.Text, Convert.ToInt32(TraineeNumberOfDrivingLessonToUpdate.Text)));
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void AddTestButton_Click(object sender, RoutedEventArgs e)
		{
			
			BE.Address a = new BE.Address();
			
				a.street = TestStreetToAdd.Text;
				a.buildingNumber = Convert.ToInt32(TestBuildingNumberToAdd.Text);
				a.city = TestCityToAdd.Text;
				BE.Test toAdd = new BE.Test(BE.Configuration.RunningIDNumber, Convert.ToString(TestTesterIdToAdd.Text), Convert.ToString(TestTraineeIdToAdd.Text), Convert.ToDateTime(TestDateForTestToAdd.Text), Convert.ToDateTime(TestDateAndTimeForTestToAdd.Text), a, false, false, false, false, false, "");
				try
				{
					bl.addTest(toAdd);
					MessageBox.Show("Test successfully added");
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}
			
		}
		private void UpdateTestButton_Click(object sender, RoutedEventArgs e)
		{
			bool distance, park, mirrors, signals, score;

			if (TestDistancekeepToUpdate.Text == "True")
			{
				distance = true;
			}
			else
			{
				distance = false;
			}
			if (TestParkingInReverseToUpdate.Text == "True")
			{
				park = true;
			}
			else
			{
				park = false;
			}
			if (TestLookingAtMirrorsToUpdate.Text == "True")
			{
				mirrors = true;
			}
			else
			{
				mirrors = false;
			}
			if (TestSignalsToUpdate.Text == "True")
			{
				signals = true;
			}
			else
			{
				signals = false;
			}
			if (TestScoreToUpdate.Text == "True")
			{
				score = true;
			}
			else
			{
				score = false;
			}
			BE.Address a = new BE.Address();
			a.street = TestStreetToUpdate.Text;
			a.buildingNumber = Convert.ToInt32(TestBuildingNumberToUpdate.Text);
			a.city = TestCityToUpdate.Text;
			try
			{
				BE.Test toUpdate = new BE.Test(Convert.ToInt32(TestNumberToUpdateTest.Text), Convert.ToString(TestTesterIdToUpdate.Text), Convert.ToString(TestTraineeIdToUpdate.Text), Convert.ToDateTime(TestdateForTestTestToUpdate.Text), Convert.ToDateTime(TestDateAndTimeForTestToUpdate.Text), a, distance, park, mirrors, signals, score, TestTesterCommentToUpdate.Text);
				bl.updateTestAtTheEnd(toUpdate);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
			
		}
		private void RefreshTesterListButton_Click(object sender, RoutedEventArgs e)
		{
			bool t = false;
			for (int i = 0; i < testerListBox.Items.Count; i++)
			{

				foreach (var item in bl.getTestersList())
				{
					if (testerListBox.Items.GetItemAt(i) == item)
					{
						t = true;
					}
				}
				if (!t)
				{
					testerListBox.Items.RemoveAt(i);
				}
			}
			foreach (BE.Tester item in bl.getTestersList())
			{
				if (!testerListBox.Items.Contains(item))
				{
					testerListBox.Items.Add(item);
				}
			}
		}
		private void RefreshTraineeListButton_Click(object sender, RoutedEventArgs e)
		{
			bool t = false;
			for (int i = 0; i < traineeListBox.Items.Count; i++)
			{

				foreach (BE.Trainee item in bl.getTraineesList())
				{
					if (traineeListBox.Items.GetItemAt(i) == item)
					{
						t = true;
					}
				}
				if (!t)
				{
					traineeListBox.Items.RemoveAt(i);
				}
			}
			foreach (BE.Trainee item in bl.getTraineesList())
			{
				if (!traineeListBox.Items.Contains(item))
				{
					traineeListBox.Items.Add(item);
				}
			}
		}

		private void RefreshTestListButton_Click(object sender, RoutedEventArgs e)
		{
			bool t = false;
			for (int i = 0; i < testListBox.Items.Count; i++)
			{

				foreach (var item in bl.getTestsList())
				{
					if (testListBox.Items.GetItemAt(i) == item)
					{
						t = true;
					}
				}
				if (!t)
				{
					testListBox.Items.RemoveAt(i);
				}
			}
			foreach (BE.Test item in bl.getTestsList())
			{
				if (!testListBox.Items.Contains(item))
				{
					testListBox.Items.Add(item);
				}
			}
		}

		private void ImporeTesterListButton_Click(object sender, RoutedEventArgs e)
		{

			foreach (BE.Tester item in bl.getTestersList())
			{
				if (!testerListToUpdate.Items.Contains(item))
				{
					testerListToUpdate.Items.Add(item);
				}
			}
		}
		private void ImportTraineeListButton_Click(object sender, RoutedEventArgs e)
		{

			foreach (BE.Trainee item in bl.getTraineesList())
			{
				if (!traineeListToUpdate.Items.Contains(item))
				{
					traineeListToUpdate.Items.Add(item);
				}
			}

		}
		private void ImportTestListButton_Click(object sender, RoutedEventArgs e)
		{
			foreach (BE.Test item in bl.getTestsList())
			{
				if (!testListToUpdate.Items.Contains(item))
				{
					testListToUpdate.Items.Add(item);
				}
			}
		}
			 
		private void testerListToUpdateSelectionChangedButton_Click(object sender, SelectionChangedEventArgs e)
		{
			
			testerListToUpdate.IsDropDownOpen = false;
			BE.Tester w = testerListToUpdate.SelectedItem as BE.Tester;
			idBoxToUpdate.Text = Convert.ToString(w.Id);
			lastNameBoxToUpdate.Text = w.LastName;
			firstNameBoxToUpdate.Text = w.FirstName;
			dateOfBirthTesterToUpdate.Text = Convert.ToString(w.DateOfBirth);
			genderTesterComboBoxToUpdate.Text = (Convert.ToString(w.Gender));
			phoneNumberBoxToUpdate.Text = Convert.ToString(w.PhoneNumber);
			streetToUpdate.Text = Convert.ToString(w.Addresss.street);
			buildingNumberToUpdate.Text = Convert.ToString(w.Addresss.buildingNumber);
			cityToUpdate.Text = Convert.ToString(w.Addresss.city);
			yearsOfExperienceBoxToUpdate.Text = Convert.ToString(w.YearsOfExperience);
			maxWeeklyTestsBoxToUpdate.Text = Convert.ToString(w.MaximumNumberOfWeeklytestsPossible);
			carTypeSpcializesComboBoxToUpdate.Text = Convert.ToString(w.SpecializesInCarOfType);
			maxDistanceExamBoxToUpdate.Text = Convert.ToString(w.MaximumDistanceForExam);
		
			
			
		
			c01.IsChecked= w.WorkingDaysAndHours[0][0];
			c11.IsChecked=w.WorkingDaysAndHours[1][0];
			c21.IsChecked=w.WorkingDaysAndHours[2][0];
			c31.IsChecked=w.WorkingDaysAndHours[3][0];
			c41.IsChecked=w.WorkingDaysAndHours[4][0];
			c51.IsChecked = w.WorkingDaysAndHours[5][0];
			c61.IsChecked=w.WorkingDaysAndHours[6][0];

			c02.IsChecked=w.WorkingDaysAndHours[0][1];
			c12.IsChecked=w.WorkingDaysAndHours[1][1];
			c22.IsChecked=w.WorkingDaysAndHours[2][1];
			c32.IsChecked=w.WorkingDaysAndHours[3][1];
			c42.IsChecked=w.WorkingDaysAndHours[4][1];
			c52.IsChecked=w.WorkingDaysAndHours[5][1];
			c62.IsChecked=w.WorkingDaysAndHours[6][1];

			c03.IsChecked=w.WorkingDaysAndHours[0][2];
			c13.IsChecked=w.WorkingDaysAndHours[1][2];
			c23.IsChecked=w.WorkingDaysAndHours[2][2];
			c33.IsChecked=w.WorkingDaysAndHours[3][2];
			c43.IsChecked=w.WorkingDaysAndHours[4][2];
			c53.IsChecked=w.WorkingDaysAndHours[5][2];
			c63.IsChecked=w.WorkingDaysAndHours[6][2];

			c04.IsChecked=w.WorkingDaysAndHours[0][3];
			c14.IsChecked=w.WorkingDaysAndHours[1][3];
			c24.IsChecked=w.WorkingDaysAndHours[2][3];
			c34.IsChecked=w.WorkingDaysAndHours[3][3];
			c44.IsChecked=w.WorkingDaysAndHours[4][3];
			c54.IsChecked=w.WorkingDaysAndHours[5][3];
			c64.IsChecked=w.WorkingDaysAndHours[6][3];

			c05.IsChecked=w.WorkingDaysAndHours[0][4];
			c15.IsChecked=w.WorkingDaysAndHours[1][4];
			c25.IsChecked=w.WorkingDaysAndHours[2][4];
			c35.IsChecked=w.WorkingDaysAndHours[3][4];
			c45.IsChecked=w.WorkingDaysAndHours[4][4];
			c55.IsChecked=w.WorkingDaysAndHours[5][4];
			c65.IsChecked=w.WorkingDaysAndHours[6][4];

			
		}





		private void traineeListToUpdateSelectionChangedButton_Click(object sender, RoutedEventArgs e)
		{
			BE.CarType c = new BE.CarType();
			BE.Gender g = new BE.Gender();
			if (Convert.ToString(BE.CarType.HeavyTruck) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.HeavyTruck;
			}
			if (Convert.ToString(BE.CarType.MediumTruck) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.MediumTruck;
			}
			if (Convert.ToString(BE.CarType.PrivateVehicle) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.PrivateVehicle;
			}
			if (Convert.ToString(BE.CarType.TwoWheeledVehicle) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.TwoWheeledVehicle;
			}
			if (Convert.ToString(BE.Gender.Female) == genderTesterComboBoxToUpdate.Text)
			{
				g = BE.Gender.Female;
			}
			if (Convert.ToString(BE.Gender.Male) == genderTesterComboBoxToUpdate.Text)
			{
				g = BE.Gender.Male;
			}
			BE.Address a = new BE.Address();
			a.street = streetToUpdate.Text;
			a.buildingNumber = Convert.ToInt32(buildingNumberToUpdate.Text);
			a.city = cityToUpdate.Text;
			BE.Tester toAdd = new BE.Tester(Convert.ToString(idBoxToUpdate.Text), lastNameBoxToUpdate.Text, firstNameBoxToUpdate.Text, Convert.ToDateTime(dateOfBirthTesterToUpdate.Text), g, Convert.ToInt32(phoneNumberBoxToUpdate.Text), a, Convert.ToInt32(yearsOfExperienceBoxToUpdate.Text), Convert.ToInt32(maxWeeklyTestsBoxToUpdate.Text), c, new bool[6][], Convert.ToInt32(maxDistanceExamBoxToUpdate.Text));
			bl.updateExistTester(toAdd);
		}

		

		private void traineeListToUpdateSelectionChangedButton_Click(object sender, SelectionChangedEventArgs e)
		{

			BE.Trainee w = traineeListToUpdate.SelectedItem as BE.Trainee;
			TraineeLastTestToUpdate.Text = Convert.ToString(w.LastTest);
			TraineeIdToUpdate.Text = Convert.ToString(w.ID);
			TraineelastNameToUpdate.Text = w.LastName;
			TraineefirstNameToUpdate.Text = w.FirstName;
			TraineeDateOfBirthToUpdate.Text = Convert.ToString(w.DateOfBirth);
			TraineegenderToUpdate.Text = (Convert.ToString(w.Gender));
			TraineephoneNumberToUpdate.Text = Convert.ToString(w.PhoneNumber);
			TraineeStreetToUpdate.Text = Convert.ToString(w.Address.street);
			TraineeBuildingNumberToUpdate.Text = Convert.ToString(w.Address.buildingNumber);
			TraineeCityToUpdate.Text = Convert.ToString(w.Address.city);
			TraineeTypeOfVihecleStudiedToUpdate.Text = Convert.ToString(w.TypeOfVehicleHeStudied);
			TraineeTypeOfGearToUpdate.Text = Convert.ToString(w.TypeOfGear);
			TraineeDrivingSchoolToUpdate.Text = Convert.ToString(w.DrivingSchool);
			TraineeDrivingTeacherToUpdate.Text = Convert.ToString(w.DrivingTeacher);
			TraineeNumberOfDrivingLessonToUpdate.Text = Convert.ToString(w.NumberOfDrivingLessons);
			TraineeAmountOfTestsToUpdate.Text = Convert.ToString(w.amountOfTests);
		}

		private void testListToUpdateSelectionChangedButton_Click(object sender, SelectionChangedEventArgs e)
		{
			BE.Test w = testListToUpdate.SelectedItem as BE.Test;
			TestNumberToUpdateTest.Text = Convert.ToString(w.TestNumber);
			TestTraineeIdToUpdate.Text = Convert.ToString(w.TraineeId);
			TestTesterIdToUpdate.Text = Convert.ToString(w.TesterId);
			TestdateForTestTestToUpdate.Text = Convert.ToString(w.DateForTest);
			TestDateAndTimeForTestToUpdate.Text = Convert.ToString(w.DateAndTimeForTest);
			TestStreetToUpdate.Text = Convert.ToString(w.CheckOutAddress.street);
			TestBuildingNumberToUpdate.Text = Convert.ToString(w.CheckOutAddress.buildingNumber);
		    TestCityToUpdate.Text = Convert.ToString(w.CheckOutAddress.city);
			TestDistancekeepToUpdate.Text = (Convert.ToString(w.Distancekeep));
			TestParkingInReverseToUpdate.Text = Convert.ToString(w.ParkingInReverse);
			TestLookingAtMirrorsToUpdate.Text = Convert.ToString(w.LookingAtMirrors);
			TestSignalsToUpdate.Text = Convert.ToString(w.Signals);
			TestScoreToUpdate.Text = Convert.ToString(w.Score);
			TestTesterCommentToUpdate.Text = Convert.ToString(w.TesterComment);
			
		}

		private void RefreshSuccessfullyPassedTestTraineeListButton_Click(object sender, RoutedEventArgs e)
		{

			
			for (int i = 0; i < successfullyPassedTestTraineeListBox.Items.Count; i++)
			{


				successfullyPassedTestTraineeListBox.Items.RemoveAt(i);
				
			}
			foreach (BE.Trainee item in bl.getTraineesList())
			{
				if (bl.successfullyPassedDrivingTest(item))
				{
					successfullyPassedTestTraineeListBox.Items.Add(item);
				}
			}
		}

		private void RefreshTestListByDateTestListButton_Click(object sender, RoutedEventArgs e)
		{
			for (int i = 0; i < testListByDateTestListBox.Items.Count; i++)
			{
				testListByDateTestListBox.Items.RemoveAt(i);
			}
			foreach (BE.Test item in bl.testsListByDate(Convert.ToDateTime(TestListByDateDatePicker.Text)))
			{
				testListByDateTestListBox.Items.Add(item);
			}
		}
	}


}

