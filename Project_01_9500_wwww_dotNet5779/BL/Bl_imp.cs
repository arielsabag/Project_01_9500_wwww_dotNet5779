using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
	public class Bl_imp : IBL
	{
		bool exist = false; // using with it in  a lot of functions 
		/// <summary>
		/// get object of lower layer
		/// </summary>
		DAL.Idal dal = DAL.FactoryDal.getDal();


		void IBL.addTester(BE.Tester t)
		{

			if (!IDValidator(t.Id))
			{
				throw new Exception("Error: Tester id is not valid");
			}
			exist = false;
			foreach (BE.Tester item in dal.getTestersList())
			{
				if (t.Id == item.Id)
				{
					exist = true;
				}
			}
			if (exist)
			{
				throw new Exception("Error: Tester already exist");
			}
			if (DateTime.Now.Year - t.DateOfBirth.Year < BE.Configuration.MaximumTesterAge)
			{
				throw new Exception("Error: Can not add tester under the age of 40");
			}
			dal.addTester(t);
		}

		void IBL.delleteTester(BE.Tester t)
		{
			exist = false;
			foreach (BE.Tester item in dal.getTestersList())
			{
				if (t.Id == item.Id)
				{
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("Error: Can not remove tester that is not exist");
			}
			dal.delleteTester(t);
		}

		void IBL.updateExistTester(BE.Tester t)
		{
			if (!IDValidator(t.Id))
			{
				throw new Exception("Error: Tester id is not valid");
			}
			exist = false;
			for (int i = 0; i < dal.getTestersList().Count; i++)
			{
				if (dal.getTestersList()[i].Id == t.Id)
				{
					dal.getTestersList()[i] = t;
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("Error: Can not update tester that is not exist");
			}
			dal.updateExistTester(t);
		}





		void IBL.addTrainee(BE.Trainee t)
		{
			if (!IDValidator(t.ID))
			{
				throw new Exception("Error: Trainee id is not valid");
			}
			exist = false;
			foreach (BE.Trainee item in dal.getTraineesList())
			{
				if (t.ID == item.ID)
				{
					exist = true;
				}
			}
			if (exist)
			{
				throw new Exception("Error:Can not add trainee that already exist");
			}
			if (DateTime.Now.Year - t.DateOfBirth.Year < BE.Configuration.MinimumTraineeAge)
			{
				throw new Exception("Error: Can not add trainee under the age of 18");
			}
			dal.addTrainee(t);
		}

		void IBL.delleteTrainee(BE.Trainee t)
		{
			exist = false;
			foreach (BE.Trainee item in dal.getTraineesList())
			{
				if (t.ID == item.ID)
				{
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("Error: can not remove trainee that is not exist");
			}
			dal.delleteTrainee(t);
		}

		void IBL.updateExistTrainee(BE.Trainee t)
		{
			if (!IDValidator(t.ID))
			{
				throw new Exception("Error: Trainee id is not valid");
			}
			exist = false;
			for (int i = 0; i < dal.getTraineesList().Count; i++)
			{
				if (dal.getTraineesList()[i].ID == t.ID)
				{
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("Error: can not update trainee that is not exist");
			}
			dal.updateExistTrainee(t);
		}



		void IBL.addTest(BE.Test t)
		{
			int countTestsForTester = 0;
			List<BE.Test> tempTestsList = dal.getTestsList();
			List<BE.Trainee> tempTraineeList = dal.getTraineesList();
			List<BE.Tester> tempTestersList = dal.getTestersList();

			BE.Trainee tempTrainee = null;
			BE.Tester tempTester = null;
			BE.Test tempTest = null;

			foreach (BE.Trainee item in tempTraineeList)// get the trainee in test
			{
				if (t.TraineeId.CompareTo(item.ID)==0)
				{
					tempTrainee = item;
					break;
				}
			}
			foreach (BE.Tester item in tempTestersList)// get the tester in test
			{
				if (t.TesterId.CompareTo(item.Id)==0)
				{
					tempTester = item;
					break;
				}
			}


			foreach (BE.Test item in tempTestsList)//if trainee Already Have Test In That Hour Exception
			{
				if ((t.TestNumber != item.TestNumber) && (t.TraineeId == item.TraineeId))
				{
					if (t.DateAndTimeForTest == item.DateAndTimeForTest)
					{
						throw new Exception("Error: Trainee already have test on that time: " + t.DateAndTimeForTest);
					}
				}
			}
			foreach (BE.Test item in tempTestsList)// tester Already Have Test In That Hour Exception
			{
				if ((t.TestNumber != item.TestNumber) && (t.TesterId == item.TesterId))
				{
					if (t.DateAndTimeForTest == item.DateAndTimeForTest)
					{
						throw new Exception("Error: Tester already have test in time: " + t.DateAndTimeForTest);
					}
				}
			}
			foreach (BE.Test item in tempTestsList)// seven days didnt passed Exception
			{
				if (t.TraineeId == item.TraineeId)
				{
					if (DateTime.Now.Day - item.DateForTest.Day < 7)
					{
						throw new Exception("Error: 7 days didnt pass since last test, last test was on: " + item.DateForTest.ToString());
					}
				}
			}
			foreach (BE.Test item in tempTestsList)// already Passed Test On That Type Of Car Exception
			{
				if (t.TraineeId == item.TraineeId)
				{
					if (t.TestOnCarOfType == item.TestOnCarOfType)
					{
						if (item.Score == true)
						{
							throw new Exception("Error: Trainee already passed test on car of type: " + t.TestOnCarOfType);
						}
					}
				}
			}
			foreach (BE.Test item in tempTestsList)// count Tests For Tester
			{
				if (item.TesterId.CompareTo(tempTester.Id)==0)
				{
					countTestsForTester++;
				}
			}
			if (tempTester.SpecializesInCarOfType != tempTrainee.TypeOfVehicleHeStudied)
			{
				throw new Exception("Error: Tester dont specialize on the type of car trainee is testing on ");
			}
			if (countTestsForTester > tempTester.MaximumNumberOfWeeklytestsPossible)
			{
				throw new Exception("Error: Tester passed the amount of tests allowed for one week");
			}
			if (tempTrainee.NumberOfDrivingLessons < 20)
			{
				throw new Exception("Error: Can't add test for trainee before he passed 20 lessons");
			}

			if ((tempTest != null) && (((int)tempTest.DateAndTimeForTest.DayOfWeek >= 1) && ((int)tempTest.DateAndTimeForTest.DayOfWeek <= 5) && ((tempTest.DateAndTimeForTest.Hour >= 9) && (tempTest.DateAndTimeForTest.Hour <= 15))))
			{
				if (!tempTester.WorkingDaysAndHours[tempTest.DateAndTimeForTest.Hour - 9][(int)tempTest.DateAndTimeForTest.DayOfWeek - 1])
				{
					throw new Exception(" (bl_imp )***tester not available in this day and hour");
				}
			}


			tempTrainee.amountOfTests++;
			dal.addTest(t);
		}



		void IBL.updateTestAtTheEnd(BE.Test t)
		{
			exist = false;
			for (int i = 0; i < dal.getTestsList().Count; i++)
			{
				if (dal.getTestsList()[i].TestNumber == t.TestNumber)
				{
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("Error: can not update test that is not exist");
			}
			dal.updateTestAtTheEnd(t);
		}



		List<BE.Tester> IBL.getTestersList()
		{
			return dal.getTestersList();
		}
		List<BE.Trainee> IBL.getTraineesList()
		{
			return dal.getTraineesList();
		}
		List<BE.Test> IBL.getTestsList()
		{
			return dal.getTestsList();
		}


		List<BE.Test> testsStandingOnCondition(Func <BE.Test,bool> function )
		{
			List<BE.Test> satisfiesCondition = new List<BE.Test>();
			foreach (BE.Test item in dal.getTestsList())
			{
				if (function(item))
				{
					satisfiesCondition.Add(item);
				}
			}
			return satisfiesCondition;
		}

		IEnumerable<IGrouping<BE.CarType,BE.Tester>> testerListBySpecialization()
		{
			List<BE.Tester> tempTesterList = dal.getTestersList();
			var groups = tempTesterList.GroupBy(s => s.SpecializesInCarOfType);
			return groups;
		}
		IEnumerable<IGrouping<string, BE.Trainee>> treaineeListByDrivingSchool()
		{
			List<BE.Trainee> tempTraineeList = dal.getTraineesList();
			var groups = tempTraineeList.GroupBy(s => s.DrivingSchool);
			return groups;
		}
		IEnumerable<IGrouping<string, BE.Trainee>> treaineeListByteacher()
		{
			List<BE.Trainee> tempTraineeList = dal.getTraineesList();
			var groups = tempTraineeList.GroupBy(s => s.DrivingTeacher);
			return groups;
		}
		IEnumerable<IGrouping<int, BE.Trainee>> treaineeListByTestsAmount()
		{
			List<BE.Trainee> tempTraineeList = dal.getTraineesList();
			var groups = tempTraineeList.GroupBy(s => s.amountOfTests);
			return groups;
		}


		int IBL.traineeTestAmount(BE.Trainee t)
		{
			int count = 0;
			foreach (BE.Test item in dal.getTestsList())
			{
				if (t.ID.CompareTo(item.TraineeId)==0)
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
			foreach (BE.Test item in dal.getTestsList())
			{
				if ((item.TraineeId.CompareTo(t.ID)==0) && (t.TypeOfVehicleHeStudied == item.TestOnCarOfType) && (item.Score==true))
				{
					return true;
				}
			}
			return false;
		}


		public List<BE.Test> testsListByDate(DateTime date)
		{
			List<BE.Test> tempList = new List<BE.Test>();
			foreach (BE.Test item in dal.getTestsList())
			{
					if (item.DateAndTimeForTest.Month == date.Month)
					{
						if (item.DateAndTimeForTest.Day == date.Day)
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
			foreach (BE.Tester item in dal.getTestersList())
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
			
			foreach (BE.Tester item in dal.getTestersList())
			{
				if (address-x>=0)
				{
					list.Add(item);
				}
				x = rand.Next(DateTime.Now.Millisecond);
			}
			return list;
		}

		/// <summary>
		///  checks if id is valid
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		private static bool IDValidator(string id)
		{
			if (id.Length != 9)
				return false;
			int counter = 0, incNum = 0;
			for (int i = 0; i < 8; i++)
			{
				incNum = (Convert.ToInt32(id[i].ToString())) * ((i % 2) + 1);//multiply digit by 1 or 2
				if (incNum > 9)//sum the digits up and add to counter
				{
					counter += incNum - 9;
				}
				else
				{
					counter += incNum;
				}
			}
			int diff = (counter % 10);
			if (diff!=0)
			{
				diff = 10 - diff;
			}
			return (diff == Convert.ToInt32(id[8].ToString()));
		}
	}
}

