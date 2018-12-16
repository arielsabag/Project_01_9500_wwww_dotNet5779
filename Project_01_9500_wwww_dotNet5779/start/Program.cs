using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start
{
	/*
	 void addTester(BE.Tester t);
		void delleteTester(BE.Tester t);
		void updateExistTesterDetails();

		void addTrainee(BE.Trainee t);
		void delleteTrainee(BE.Trainee t);
		void updateExistTraineeDetails();

		void addTest(BE.Test t);
		void updateTestAtTheEnd(BE.Test t);

		List<BE.Tester> testersList();
		List<BE.Trainee> traineesList();
		List<BE.Test> testsList();

		 */
	class Program
	{
		static void Main(string[] args)
		{
			BL.IBL bl = new BL.Bl_imp();

			BE.Trainee student1 = new BE.Trainee();
			student1.ID = 1;
			student1.FirstName = "a";
			BE.Trainee student2 = new BE.Trainee();
			student2.ID = 2;
			student2.FirstName = "b";

			BE.Tester tester1 = new BE.Tester();
			tester1.Id = 11;
			tester1.FirstName = "aa";
			BE.Tester tester2 = new BE.Tester();
			tester2.Id = 22;
			tester2.FirstName = "bb";

			BE.Test test1 = new BE.Test();
			test1.TraineeId = 1;
			test1.TesterId = 11;
			test1.TestNumber = 1;
			BE.Test test2 = new BE.Test();
			test2.TraineeId = 2;
			test2.TesterId = 22;
			test2.TestNumber = 2;
			try
			{
				bl.addTest(test1);
				bl.addTest(test2);
			}
			catch (Exception e)
			{

				Console.WriteLine(e);
			}
			

			//foreach (var item in bl.testsList())
			//{
			//	Console.WriteLine(item);
			//}

		}
	}
}
