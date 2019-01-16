using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	public class Tester
	{
		public Tester(String id, string lastName, string firstName, DateTime dateOfBirth, Gender gender,int phoneNumber, Address addresss, int yearsOfExperience, int maximumNumberOfWeeklytestsPossible, CarType specializesInCarOfType, bool[][] workingDaysAndHours, double maximumDistanceForExam)
		{
			Id = id;
			LastName = lastName;
			FirstName = firstName;
			DateOfBirth = dateOfBirth;
			Gender = gender;
			PhoneNumber = phoneNumber;
			Addresss = addresss;
			YearsOfExperience = yearsOfExperience;
			MaximumNumberOfWeeklytestsPossible = maximumNumberOfWeeklytestsPossible;
			SpecializesInCarOfType = specializesInCarOfType;
			WorkingDaysAndHours = workingDaysAndHours;
			MaximumDistanceForExam = maximumDistanceForExam;
		}

		public String Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public Gender Gender { get; set; }
		public int PhoneNumber { get; set; }
		public Address Addresss { get; set; }
		public int YearsOfExperience { get; set; }
		public int MaximumNumberOfWeeklytestsPossible { get; set; }
		public CarType SpecializesInCarOfType { get; set; }
		public bool[][] WorkingDaysAndHours { get; set; }
		public double MaximumDistanceForExam { get; set; }
		public override string ToString()
		{
			return "\nTester ID : " + Id +
				"\nTester last name : " + LastName +
				"\nTester First Name : " + FirstName +
				"\ntester Date Of Birth : " + DateOfBirth +
				"\ntester Gender : " + Gender +
				"\nTester Phone Number : " + PhoneNumber +
				"\ntester Addresss : " + Addresss +
				"\nTester Years Of Experience : " + YearsOfExperience +
				"\nTester Maximum Number Of Weekly tests Possible : " + MaximumNumberOfWeeklytestsPossible +
				"\nTester Specializes In Car Of Type : " + SpecializesInCarOfType +
				"\ntester Working Days And Hours: \n" + printBoolArr() +
				"\ntester Maximum Distance For Exam " + MaximumDistanceForExam;
		}
		
		private string printBoolArr() // function to help print the schedule of tester
		{
			string[] ss = new string[7];
			ss[0] = "09:00";
			ss[1] = "10:00";
			ss[2] = "11:00";
			ss[3] = "12:00";
			ss[4] = "13:00";
			ss[5] = "14:00";
			ss[6] = "15:00";
			string arr ="               sunday monday thuesday wednesday thursday\n";
			for (int i = 0; i < 7; i++)
			{
				arr +=ss[i]+"   ";
				for (int j = 0; j < 5; j++)
				{
					if (j == 4)
					{
						arr += "       ";
					}
						arr += "      " + WorkingDaysAndHours[i][j];
				}
				arr += "\n";
			}
			return arr;
		}
	}
}
