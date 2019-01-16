using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class Dal_imp : Idal
	{
		bool exist = false;
		// just for help
		/// <summary>
		///  add tester to testers list
		/// </summary>
		/// <param name="t"> tester to add to testers list</param>
		/// <returns> return true if added succedded else return false</returns>
		void Idal.addTester(BE.Tester t)
		{
			exist = false;
			foreach (BE.Tester item in DS.DataSource.testerList)
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
			DS.DataSource.testerList.Add(t);
		}


		void Idal.delleteTester(BE.Tester t)
		{
			foreach (BE.Tester item in DS.DataSource.testerList)
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
			DS.DataSource.testerList.Remove(t);
		}

		void Idal.updateExistTester(BE.Tester t)
		{
			exist = false;
			for (int i = 0; i < DS.DataSource.testerList.Count; i++)
			{
				if (DS.DataSource.testerList[i].Id == t.Id)
				{
					DS.DataSource.testerList[i] = t;
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("tester didnt exist");
			}
		}

		void Idal.addTrainee(BE.Trainee t)
		{
			exist = false;
			foreach (BE.Trainee item in DS.DataSource.traineeList)
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
			DS.DataSource.traineeList.Add(t);
		}

		void Idal.delleteTrainee(BE.Trainee t)
		{
			foreach (BE.Trainee item in DS.DataSource.traineeList)
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
			DS.DataSource.traineeList.Remove(t);
		}

		void Idal.updateExistTrainee(BE.Trainee t)
		{
			exist = false;
			for (int i = 0; i < DS.DataSource.traineeList.Count; i++)
			{
				if (DS.DataSource.traineeList[i].ID == t.ID)
				{
					DS.DataSource.traineeList[i] = t;
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("trainee didnt exist");
			}
		}

		/// <summary>
		/// add test to tests list and add test number to that test
		/// </summary>
		/// <param name="t">new test</param>
		void Idal.addTest(BE.Test t)
		{
			exist = false;
			foreach (BE.Test item in DS.DataSource.testsList)
			{
				if (t.TestNumber == item.TestNumber)
				{
					exist = true;
				}
			}
			if (exist)
			{
				throw new Exception("test already exist");
			}
			t.TestNumber = BE.Configuration.RunningIDNumber++; // add  test number to the new test and increse "runnigIDNumber by 1"
			DS.DataSource.testsList.Add(t);
		}
		void Idal.updateTestAtTheEnd(BE.Test t)
		{
			exist = false;
			for (int i = 0; i < DS.DataSource.testsList.Count; i++)
			{
				if (DS.DataSource.testsList[i].TestNumber == t.TestNumber)
				{
					DS.DataSource.testsList[i] = t;
					exist = true;
				}
			}
			if (!exist)
			{
				throw new Exception("test didnt exist");
			}
		}

		List<BE.Tester> Idal.getTestersList()
		{
			return DS.DataSource.testerList.ToList();
		}
		List<BE.Trainee> Idal.getTraineesList()
		{
			return DS.DataSource.traineeList.ToList();
		}
		List<BE.Test> Idal.getTestsList()
		{
			return DS.DataSource.testsList.ToList();
		}
	}
}
