using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	public class Tester
	{
	
		public int Id { get; set; }
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
				"\ntester Working Days And Hours: " + WorkingDaysAndHours +
				"\ntester Maximum Distance For Exam " + MaximumDistanceForExam;
		}
		
	}
}
