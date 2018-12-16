using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 testNumber, testerID, traineeID, dateToTest, dateAndHourToTest, getOutToTestAddress, keepDistance,reversePark,lookMirror, signals, grade, comments, tostring ,...
 */
namespace BE
{
	public class Test
	{
		public int TestNumber { get; set; }
		public int TesterId { get; set; }
		public int TraineeId { get; set; }
		public DateTime DateForTest { get; set; }
		public DateTime DateAndTimeForTest { get; set; }
		public Address CheckOutAddress { get; set; }
		public bool Distancekeep { get; set; }
		public bool ParkingInReverse { get; set; }
		public bool LookingAtMirrors { get; set; }
		public bool Signals { get; set; }
		public bool Score { get; set; }
		public string TesterComment { get; set; }
		public override string ToString()
		{
			return "\nTest number : " + TestNumber +
				"\n Tester id: " + TesterId +
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
		public CarType TestOnCarOfType { get; set; }
	}
}
