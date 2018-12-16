using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
	public class Bl_imp : IBL
	{
		bool exist = false;
		/// <summary>
		/// get object of lower layer
		/// </summary>
		DAL.Idal dal = DAL.FactoryDal.getDal();


		void IBL.addTester(BE.Tester t)
		{
			exist = false;
			foreach (BE.Tester item in dal.testersList())
			{
				if (t.Id == item.Id)
				{
					exist = true;
				}
			}
			if (exist)
			{
				throw new Exception("tester already exist");
			}
			if (DateTime.Now.Year - t.DateOfBirth.Year > BE.Configuration.MaximumTesterAge)
			{
				throw new Exception("Tester under the age of 40");
			}
			dal.addTester(t);
		}
		void IBL.delleteTester(BE.Tester t)
		{
			exist = false;
			foreach (BE.Tester item in dal.testersList())
			{
				if (t.Id == item.Id)
				{
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("can not remove tester that not exist");
			}
			dal.delleteTester(t);
		}
		void IBL.updateExistTesterDetails(BE.Tester t)
		{
			exist = false;
			for (int i = 0; i < dal.testersList().Count; i++)
			{
				if (dal.testersList()[i].Id == t.Id)
				{
					dal.testersList()[i] = t;
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("tester didnt exist");
			}
			dal.updateExistTesterDetails(t);
		}



		void IBL.addTrainee(BE.Trainee t)
		{
			exist = false;
			foreach (BE.Trainee item in dal.traineesList())
			{
				if (t.ID == item.ID)
				{
					exist = true;
				}
			}
			if (exist)
			{
				throw new Exception("Trainee already exist");
			}
			if (DateTime.Now.Year - t.DateOfBirth.Year < BE.Configuration.MinimumTraineeAge)
			{
				throw new Exception("Cannot add trainee younger than 18 years");
			}
			dal.addTrainee(t);
		}

		void IBL.delleteTrainee(BE.Trainee t)
		{
			exist = false;
			foreach (BE.Trainee item in dal.traineesList())
			{
				if (t.ID == item.ID)
				{
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("can not remove trainee that not exist");
			}
			dal.delleteTrainee(t);
		}
		void IBL.updateExistTraineeDetails(BE.Trainee t)
		{
			exist = false;
			for (int i = 0; i < dal.traineesList().Count; i++)
			{
				if (dal.traineesList()[i].ID == t.ID)
				{
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("trainee didnt exist");
			}
			dal.updateExistTraineeDetails(t);
		}



		void IBL.addTest(BE.Test t)
		{
			int countTestsForTester = 0;
			bool traineeAlreadyHaveTestInThatHour = false;
			bool testerAlreadyHaveTestInThatHour = false;
			bool sevenDaysDidNotPassed = false;
			bool alreadyPassedTestOnThatTypeOfCar = false;
			List<BE.Test> tempTestsList = dal.testsList();
			List<BE.Trainee> tempTraineeList = dal.traineesList();
			List<BE.Tester> tempTestersList = dal.testersList();
			BE.Trainee tempTrainee = null;
			BE.Tester tempTester = null;
			BE.Test tempTest = null;
			foreach (BE.Trainee item in tempTraineeList)// get the trainee in test
			{
				if (t.TraineeId == item.ID)
				{
					tempTrainee = item;
				}
			}
			foreach (BE.Tester item in tempTestersList)// get the tester in test
			{
				if (t.TesterId == item.Id)
				{
					tempTester = item;
				}
			}
			foreach (BE.Test item in tempTestsList)// get the trainee in test
			{
				if ((t.TestNumber != item.TestNumber) && (t.TraineeId == item.TraineeId))
				{
					if (t.DateAndTimeForTest == item.DateAndTimeForTest)
					{
						traineeAlreadyHaveTestInThatHour = true;
					}
				}
			}
			foreach (BE.Test item in tempTestsList)// get the trainee in test
			{
				if ((t.TestNumber != item.TestNumber) && (t.TesterId == item.TesterId))
				{
					if (t.DateAndTimeForTest == item.DateAndTimeForTest)
					{
						testerAlreadyHaveTestInThatHour = true;
					}
				}
			}
			foreach (BE.Test item in tempTestsList)
			{
				if (t.TraineeId == item.TraineeId)
				{
					if (DateTime.Now.Day - item.DateForTest.Day < 7)
					{
						sevenDaysDidNotPassed = true;
					}
				}
			}
			foreach (BE.Test item in tempTestsList)
			{
				if (t.TraineeId == item.TraineeId)
				{
					if (t.TestOnCarOfType == item.TestOnCarOfType)
					{
						if (item.Score == true)
						{
							alreadyPassedTestOnThatTypeOfCar = true;
						}
					}
				}
			}
			foreach (var item in tempTestsList)
			{
				if (item.TesterId==tempTester.Id)
				{
					countTestsForTester++;
				}
			}
			if (countTestsForTester>tempTester.MaximumNumberOfWeeklytestsPossible)
			{
				throw new Exception("tester passed the number of tests for week allowed");
			}
			if (((int)tempTest.DateAndTimeForTest.DayOfWeek>=1)&&((int)tempTest.DateAndTimeForTest.DayOfWeek<=5)&&((tempTest.DateAndTimeForTest.Hour>=9)&&(tempTest.DateAndTimeForTest.Hour<=15)))
			{
				if (!tempTester.WorkingDaysAndHours[tempTest.DateAndTimeForTest.Hour - 9][(int)tempTest.DateAndTimeForTest.DayOfWeek - 1])
				{
					throw new Exception("tester not available in this day and hour");
				}
			}
		
			if (tempTester.SpecializesInCarOfType != tempTrainee.TypeOfVehicleHeStudied)
			{
				throw new Exception(" the tester dont specialize on the type of car the trainee studied ");
			}
			if (sevenDaysDidNotPassed)
			{
				throw new Exception("7 days didnt pass sincelast test");
			}
			if (tempTrainee.NumberOfDrivingLessons < 20)
			{
				throw new Exception("can't add test before 20 lessons had done");
			}
			if (alreadyPassedTestOnThatTypeOfCar)
			{
				throw new Exception(" trainee already passed test on that type of car");
			}
			if (testerAlreadyHaveTestInThatHour)
			{
				throw new Exception("tester already have test in time: " + t.DateAndTimeForTest.Hour);
			}
			if (traineeAlreadyHaveTestInThatHour)
			{
				throw new Exception("trainee already have test in time: " + t.DateAndTimeForTest.Hour);
			}
			tempTrainee.amountOfTests++;
			dal.addTest(t);
		}
		void IBL.updateTestAtTheEnd(BE.Test t)
		{
			exist = false;
			for (int i = 0; i < dal.testsList().Count; i++)
			{
				if (dal.testsList()[i].TestNumber == t.TestNumber)
				{
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("test didnt exist");
			}
			dal.updateTestAtTheEnd(t);
		}



		List<BE.Tester> IBL.testersList()
		{
			return dal.testersList();
		}
		List<BE.Trainee> IBL.traineesList()
		{
			return dal.traineesList();
		}
		List<BE.Test> IBL.testsList()
		{
			return dal.testsList();
		}

		List<BE.Test> testsStandingOnCondition(Func <BE.Test,bool> function )
		{
			List<BE.Test> satisfiesCondition = new List<BE.Test>();
			foreach (var item in dal.testsList())
			{
				if (function(item))
				{
					satisfiesCondition.Add(item);
				}
			}
			return new List<BE.Test>();
		}

		IEnumerable<IGrouping<BE.CarType,BE.Tester>> testerListBySpecialization()
		{
			List<BE.Tester> tempTesterList = dal.testersList();
			var groups = tempTesterList.GroupBy(s => s.SpecializesInCarOfType);
			return groups;
		
		}
		IEnumerable<IGrouping<string, BE.Trainee>> treaineeListByDrivingSchool()
		{
			List<BE.Trainee> tempTraineeList = dal.traineesList();
			var groups = tempTraineeList.GroupBy(s => s.DrivingSchool);
			return groups;
		}
		IEnumerable<IGrouping<string, BE.Trainee>> treaineeListByteacher()
		{
			List<BE.Trainee> tempTraineeList = dal.traineesList();
			var groups = tempTraineeList.GroupBy(s => s.DrivingTeacher);
			return groups;
		}
		IEnumerable<IGrouping<int, BE.Trainee>> treaineeListByTestsAmount()
		{
			List<BE.Trainee> tempTraineeList = dal.traineesList();
			var groups = tempTraineeList.GroupBy(s => s.amountOfTests);
			return groups;
		}


		int IBL.traineeTestAmount(BE.Trainee t)
		{
			int count = 0;
			foreach (BE.Test item in dal.testsList())
			{
				if (t.ID == item.TraineeId)
				{
					if (DateTime.Now> item.DateAndTimeForTest)
					{
						count++;
					}
				}
			}
			return count;
		}



		bool IBL.successfullyPassedDrivingTest(BE.Trainee t)
		{
			foreach (BE.Test item in dal.testsList())
			{
				if ((item.TraineeId == t.ID) && (t.TypeOfVehicleHeStudied == item.TestOnCarOfType) && (item.Score))
				{
					return true;
				}
			}
			return false;
		}


		List<BE.Test> testsListByDate(DateTime date)
		{
			List<BE.Test> tempList = new List<BE.Test>();
			foreach (var item in dal.testsList())
			{
				if (item.DateAndTimeForTest.Month==date.Month)
				{
					if (item.DateAndTimeForTest.Day==date.Day)
					{
						tempList.Add(item);
					}
				}
			}
			return tempList;
		}

		public List<BE.Tester> availableTestersInDateAndTime(DateTime t)
		{
			List<BE.Tester> tempList = new List<BE.Tester>(); 
			foreach (var item in dal.testersList())
			{
				if (((int)t.DayOfWeek >= 1) && ((int)t.DayOfWeek <= 5) && ((t.Hour >= 9) && (t.Hour <= 15)))
				{
					if (item.WorkingDaysAndHours[t.Hour - 9][(int)t.DayOfWeek - 1])
					{
						tempList.Add(item);
					}
				}
			}
			return tempList;
		}

		public List<BE.Tester> testersInRange(double address)
		{
			List<BE.Tester> list = new List<BE.Tester>();
			Random rand = new Random();
			int x = rand.Next(DateTime.Now.Millisecond);
			
			foreach (var item in dal.testersList())
			{
				if (address-x>=0)
				{
					list.Add(item);
				}
				x = rand.Next(DateTime.Now.Millisecond);
			}
			return list;
		}
	}
}
