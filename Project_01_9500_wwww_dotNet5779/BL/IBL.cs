using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {
		/// <summary>
		/// add tester to tester list
		/// </summary>
		/// <param name="t">tester</param>
		void addTester(BE.Tester t);
		/// <summary>
		/// dellete tester from tester list
		/// </summary>
		/// <param name="t">tester</param>
		void delleteTester(BE.Tester t);
		/// <summary>
		/// update tester details
		/// </summary>
		/// <param name="t">tester</param>
		void updateExistTester(BE.Tester t);




		/// <summary>
		/// add trainee/student to trainee list
		/// </summary>
		/// <param name="t">trainee</param>
		void addTrainee(BE.Trainee t);
		/// <summary>
		/// dellete trainee from trainee list
		/// </summary>
		/// <param name="t">trainee</param>
		void delleteTrainee(BE.Trainee t);
		/// <summary>
		/// update trainee details
		/// </summary>
		/// <param name="t"></param>
		void updateExistTrainee(BE.Trainee t);




		/// <summary>
		/// add testto tests list
		/// </summary>
		/// <param name="t">test</param>
		void addTest(BE.Test t);
		/// <summary>
		/// update test when finished
		/// </summary>
		/// <param name="t">test</param>
		void updateTestAtTheEnd(BE.Test t);

		List<BE.Tester> getTestersList();
		List<BE.Trainee> getTraineesList();
		List<BE.Test> getTestsList();

		int traineeTestAmount(BE.Trainee t);
		bool successfullyPassedDrivingTest(BE.Trainee t);
		List<BE.Test> testsListByDate(DateTime date);

	}
}
