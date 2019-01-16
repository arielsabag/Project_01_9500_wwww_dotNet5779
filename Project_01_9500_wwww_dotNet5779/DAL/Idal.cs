using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public interface Idal
	{
		/// <summary>
		///  add tester to tester list
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
		void updateExistTester(BE.Tester t);



		/// <summary>
		/// add trainee/student to trainee list
		/// </summary>
		/// <param name="t">trainee</param>
		void addTrainee(BE.Trainee t);
		/// <summary>
		/// sellete trainee from trainee list
		/// </summary>
		/// <param name="t">trainee</param>
		void delleteTrainee(BE.Trainee t);
		/// <summary>
		/// update trainee details
		/// </summary>
		void updateExistTrainee(BE.Trainee t);



		/// <summary>
		/// add test to tests list
		/// </summary>
		/// <param name="t">test</param>
		void addTest(BE.Test t);
		/// <summary>
		/// update tests when finished
		/// </summary>
		/// <param name="t"></param>
		void updateTestAtTheEnd(BE.Test t);



		/// <summary>
		/// list of all testers
		/// </summary>
		/// <returns>list of tester</returns>
		List<BE.Tester> getTestersList();
		/// <summary>
		/// list of all trainees
		/// </summary>
		/// <returns>list of trainees</returns>
		List<BE.Trainee> getTraineesList();
		/// <summary>
		/// list of all tests
		/// </summary>
		/// <returns>list of tests</returns>
		List<BE.Test> getTestsList();
	}
}
