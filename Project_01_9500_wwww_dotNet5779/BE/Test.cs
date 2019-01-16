using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
	public class Test
	{
		public Test(int testNumber, string testerId, string traineeId, DateTime dateForTest, DateTime dateAndTimeForTest, Address checkOutAddress,bool distancekeep, bool parkingInReverse, bool lookingAtMirrors, bool signals, bool score, string testerComment)
		{
			TestNumber = testNumber;
			TesterId = testerId;
			TraineeId = traineeId;
			DateForTest = dateForTest;
			DateAndTimeForTest = dateAndTimeForTest;
			CheckOutAddress = checkOutAddress;
			Distancekeep = distancekeep;
			ParkingInReverse = parkingInReverse;
			LookingAtMirrors = lookingAtMirrors;
			Signals = signals;
			Score = score;
			TesterComment = testerComment;
		}
		public int TestNumber { get; set; }
		public string TesterId { get; set; }
		public string TraineeId { get; set; }
		public DateTime DateForTest { get; set; }
		public DateTime DateAndTimeForTest { get; set; }
		public Address CheckOutAddress { get; set; }
		public bool Distancekeep { get; set; }
		public bool ParkingInReverse { get; set; }
		public bool LookingAtMirrors { get; set; }
		public bool Signals { get; set; }
		public bool Score { get; set; }
		public string TesterComment { get; set; }
		public CarType TestOnCarOfType { get; set; }
		public override string ToString()
		{
			return "\nTest number : " + TestNumber +
				"\n Tester id: " + TesterId +
				"\nTrainee Id : " + TraineeId +
				"\nTesting on car of type : " + TestOnCarOfType +
				"\nDate for test : " + DateForTest +
				"\nDate and time for test : " + DateAndTimeForTest +
				"\nCheck out address : " + CheckOutAddress +
				"\nDistance keep : " + Distancekeep +
				"\nParking in reverse : " + ParkingInReverse +
				"\nLooking at mirrors : " + LookingAtMirrors +
				"\nSignals : " + Signals +
				"\nScore: " + Score +
			    "\ncomment: " + TesterComment;
		}
	}
}
