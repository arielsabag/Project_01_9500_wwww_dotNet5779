using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	class Test
	{

		private int testNumber;

		public int TestNumber
		{
			get { return testNumber; }
			set { testNumber = value; }
		}

		private int testerId;

		public int TesterId
		{
			get { return testerId; }
			set { testerId = value; }
		}

		private int traineeId;

		public int TraineeId
		{
			get { return traineeId; }
			set { traineeId = value; }
		}

		private string dateForTest;

		public string DateForTest
		{
			get { return dateForTest; }
			set { dateForTest = value; }
		}

		private string dateAndTimeForTest;

		public string DateAndTimeForTest
		{
			get { return dateAndTimeForTest; }
			set { dateAndTimeForTest = value; }
		}

		private string checkOutAddress;

		public string CheckOutAddress
		{
			get { return checkOutAddress; }
			set { checkOutAddress = value; }
		}


		private bool distancekeep;

		public bool Distancekeep
		{
			get { return distancekeep; }
			set { distancekeep = value; }
		}


		private bool parkingInReverse;

		public bool ParkingInReverse
		{
			get { return parkingInReverse; }
			set { parkingInReverse = value; }
		}


		private bool lookingAtMirrors;

		public bool LookingAtMirrors
		{
			get { return lookingAtMirrors; }
			set { lookingAtMirrors = value; }
		}

		private bool signals;

		public bool Signals
		{
			get { return signals; }
			set { signals = value; }
		}

		private int score;

		public int Score
		{
			get { return score; }
			set { score = value; }
		}



		private string testerComment;

		public string TesterComment
		{
			get { return testerComment; }
			set { testerComment = value; }

		}


		public override string ToString()
		{

			return "\nTest number : " + TestNumber +
				"\n Tester id: " + testerId +
				"\nTrainee Id : " + TraineeId +
				"\nDate for test : " + DateForTest +
				"\nDate and time for test : " + DateAndTimeForTest +
				"\nCheck out address : " + CheckOutAddress +
				"\nDistance keep : " + Distancekeep +
				"\nParking in reverse : " + ParkingInReverse +
				"\nLooking at mirrors : " + LookingAtMirrors +
				"\nSignals : " + Signals +
				"\nScore: " + Score;
		}
	}
}
