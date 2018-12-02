using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	class Trainee
	{
		private int traineeId;

		public int TraineeId
		{
			get { return traineeId; }
			set { traineeId = value; }
		}


		private string traineeFirstName;

		public string TraineeFirstName
		{
			get { return traineeFirstName; }
			set { traineeFirstName = value; }
		}

		private string traineeLastName;

		public string TraineeLastName
		{
			get { return traineeLastName; }
			set { traineeLastName = value; }
		}

		private string traineeGender;

		public string TraineeGender
		{
			get { return traineeGender; }
			set { traineeGender = value; }
		}

		private int traineePhoneNumber;

		public int TraineePhoneNumber
		{
			get { return traineePhoneNumber; }
			set { traineePhoneNumber = value; }
		}

		private string traineeAddress;

		public string TraineeAddress
		{
			get { return traineeAddress; }
			set { traineeAddress = value; }
		}


		private string traineeDateOfBirth;

		public string TraineeDateOfBirth
		{
			get { return TraineeDateOfBirth; }
			set { TraineeDateOfBirth = value; }
		}

		private string traineeTypeOfVehicleHeStudied;

		public string TraineeTypeOfVehicleHeStudied
		{
			get { return traineeTypeOfVehicleHeStudied; }
			set { traineeTypeOfVehicleHeStudied = value; }
		}


		private string traineeTypeOfGear;

		public string TraineeTypeOfGear
		{
			get { return traineeTypeOfGear; }
			set { traineeTypeOfGear = value; }
		}


		private string traineeDrivingSchool;

		public string TraineeDrivingSchool
		{
			get { return traineeDrivingSchool; }
			set { traineeDrivingSchool = value; }
		}

		private string traineeDrivingTeacher;

		public string TraineeDrivingTeacher
		{
			get { return traineeDrivingTeacher; }
			set { traineeDrivingTeacher = value; }
		}

		private int traineeNumberOfDrivingLessons;

		public int TraineeNumberOfDrivingLessons
		{
			get { return traineeNumberOfDrivingLessons; }
			set { traineeNumberOfDrivingLessons = value; }
		}

		public override string ToString()
		{

			return "\nTester ID: " + TraineeId +
				"\nnTrainee First Name: " + TraineeFirstName +
				"\nnTrainee last name: " + TraineeLastName +
				"\nnTrainee Gender: " + TraineeGender +
				"\nnTrainee Phone Number: " + TraineePhoneNumber +
				"\nnTrainee Addresss: " + TraineeAddress +
				"\nnTrainee Date Of Birth: " + TraineeDateOfBirth +
				"\nnTrainee Specializes In Car Of Type: " + TraineeTypeOfVehicleHeStudied +
				"\nTrainee type of gear: " + TraineeTypeOfGear +
				"\nTrainee driving school: " + TraineeDrivingSchool +
				"\nTrainee driving teacher: " + TraineeDrivingTeacher +
				"\nTrainee number of driving lessons: " + TraineeNumberOfDrivingLessons;
		}

	}
}
