using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	class Tester
	{

		private int testerId;

		public int TesterId
		{
			get { return testerId; }
			set { testerId = value; }
		}

		private string testerLastName;

		public string TesterLastName
		{
			get { return testerLastName; }
			set { testerLastName = value; }
		}


		private string testerFirstName;

		public string TesterFirstName
		{
			get { return testerFirstName; }
			set { testerFirstName = value; }
		}

		private string testerDateOfBirth;

		public string TesterDateOfBirth
		{
			get { return testerDateOfBirth; }
			set { testerDateOfBirth = value; }
		}


		private string testerGender;

		public string TesterGender
		{
			get { return testerGender; }
			set { testerGender = value; }
		}

		private int testerPhoneNumber;

		public int TesterPhoneNumber
		{
			get { return testerPhoneNumber; }
			set { testerPhoneNumber = value; }
		}


		private string testerAddresss;

		public string TesterAddresss
		{
			get { return testerAddresss; }
			set { testerAddresss = value; }
		}


		private int testerYearsOfExperience;

		public int TesterYearsOfExperience
		{
			get { return testerYearsOfExperience; }
			set { testerYearsOfExperience = value; }
		}


		private int testerMaximumNumberOfWeeklytestsPossible;

		public int TesterMaximumNumberOfWeeklytestsPossible
		{
			get { return testerMaximumNumberOfWeeklytestsPossible; }
			set { testerMaximumNumberOfWeeklytestsPossible = value; }
		}


		private string testerSpecializesInCarOfType;

		public string TesterSpecializesInCarOfType
		{
			get { return testerSpecializesInCarOfType; }
			set { testerSpecializesInCarOfType = value; }
		}


		private string testerWorkingDaysAndHours;

		public string TesterWorkingDaysAndHours
		{
			get { return testerWorkingDaysAndHours; }
			set { testerWorkingDaysAndHours = value; }
		}


		private double testerMaximumDistanceForExam;

		public double TesterMaximumDistanceForExam
		{
			get { return testerMaximumDistanceForExam; }
			set { testerMaximumDistanceForExam = value; }
		}

		public override string ToString()
		{

			return "\nTester ID : " + TesterId +
				"\nTester last name : " + TesterLastName +
				"\nTester First Name : " + TesterFirstName +
				"\ntester Date Of Birth : " + testerDateOfBirth +
				"\ntester Gender : " + testerGender +
				"\nTester Phone Number : " + TesterPhoneNumber +
				"\ntester Addresss : " + testerAddresss +
				"\nTester Years Of Experience : " + TesterYearsOfExperience +
				"\nTester Maximum Number Of Weekly tests Possible : " + TesterMaximumNumberOfWeeklytestsPossible +
				"\nTester Specializes In Car Of Type : " + TesterSpecializesInCarOfType +
				"\ntester Working Days And Hours: " + testerWorkingDaysAndHours +
				"\ntester Maximum Distance For Exam " + testerMaximumDistanceForExam;
		}

	}
}
