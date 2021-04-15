using System;
using System.Collections.Generic;
using System.Linq;

namespace Gridnine.FlightCodingTest
{
	public class DepartureBeforeNow :IFilter
	{
		//вылет до текущего момента времени


		public IList<Flight> filter(IList<Flight> input)
		{
			Console.WriteLine("Удалены перелёты, в которых вылет производится до текущего момента времени");

			//IList<Flight> arr = new List<Flight>();
			//
			//foreach(Flight f in input)
			//{
			//		if (f.Segments.First().DepartureDate > DateTime.Now)
			//		{
			//			arr.Add(f);
			//		}
			//}

			//Проверка первого сегмента на время
			var arr = (from f in input
					   where f.Segments.First().DepartureDate > DateTime.Now
					   select f
					   ).ToList();

			return arr;
		}
	}
}
