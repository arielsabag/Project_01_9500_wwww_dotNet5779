using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 id, firstName, lastName, gender, phone, address, dateOfBirth, carType, gearBoxType, schoolName, teacherName, lessonsAmount, toString,...
	 */
namespace BE
{
	public class Trainee
	{
		public int ID { get; set; }
		public DateTime LastTest { get; set; }  
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Gender Gender { get; set; }
		public int PhoneNumber { get; set; }
		public Address Address { get; set; }
		public DateTime DateOfBirth { get; set; }
		public CarType TypeOfVehicleHeStudied { get; set; }
		public GearboxType TypeOfGear { get; set; }
		 public string DrivingSchool { get; set; }
		 public string DrivingTeacher { get; set; }
		public int NumberOfDrivingLessons { get; set; }
		public int amountOfTests { get; set; }
		public override string ToString()
		{
			return "\nTester ID: " + ID +
				"\nnTrainee First Name: " + FirstName +
				"\nnTrainee last name: " + LastName +
				"\nnTrainee Gender: " + Gender +
				"\nnTrainee Phone Number: " + PhoneNumber +
				"\nnTrainee Addresss: " + Address +
				"\nnTrainee Date Of Birth: " + DateOfBirth +
				"\nnTrainee Specializes In Car Of Type: " + TypeOfVehicleHeStudied +
				"\nTrainee type of gear: " + TypeOfGear +
				"\nTrainee driving school: " + DrivingSchool +
				"\nTrainee driving teacher: " + DrivingTeacher +
				"\nTrainee number of driving lessons: " + NumberOfDrivingLessons;
		}
	}
}
