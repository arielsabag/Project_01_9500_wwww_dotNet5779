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
		public Trainee(string iD, DateTime lastTest, string firstName, string lastName, Gender gender, int phoneNumber, Address address, DateTime dateOfBirth, CarType typeOfVehicleHeStudied, GearboxType typeOfGear, string drivingSchool, string drivingTeacher, int numberOfDrivingLessons)
		{
			ID = iD;
			LastTest = lastTest;
			FirstName = firstName;
			LastName = lastName;
			Gender = gender;
			PhoneNumber = phoneNumber;
			Address = address;
			DateOfBirth = dateOfBirth;
			TypeOfVehicleHeStudied = typeOfVehicleHeStudied;
			TypeOfGear = typeOfGear;
			DrivingSchool = drivingSchool;
			DrivingTeacher = drivingTeacher;
			NumberOfDrivingLessons = numberOfDrivingLessons;
		}
		public string ID { get; set; }
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
			return "\nTrainee ID: " + ID +
				"\nTrainee First Name: " + FirstName +
				"\nTrainee last name: " + LastName +
				"\nTrainee Gender: " + Gender +
				"\nTrainee Phone Number: " + PhoneNumber +
				"\nTrainee Addresss: " + Address +
				"\nTrainee Date Of Birth: " + DateOfBirth +
				"\nTrainee Specializes In Car Of Type: " + TypeOfVehicleHeStudied +
				"\nTrainee type of gear: " + TypeOfGear +
				"\nTrainee driving school: " + DrivingSchool +
				"\nTrainee driving teacher: " + DrivingTeacher +
				"\nTrainee number of driving lessons: " + NumberOfDrivingLessons;
		}
	}
}
