using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	public struct Address
	{
		public  string street;
		public  int buildingNumber;
		public  string city;
		public override string ToString()
		{
			return "Street: " + street +
				"  ,  Building Number: " + buildingNumber +
				"  ,  City: " + city;
		}
	}
	
}
