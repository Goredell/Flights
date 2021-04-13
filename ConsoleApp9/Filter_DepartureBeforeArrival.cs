using System;
using System.Collections.Generic;
using System.Linq;

namespace Gridnine.FlightCodingTest
{
	public class DepartureBeforeArrival : IFilter
	{
		//имеются сегменты с датой прилёта раньше даты вылета
		public IList<Flight> filter(IList<Flight> input)
		{
			Console.WriteLine("имеются сегменты с датой прилёта раньше даты вылета");

			IList<Flight> arr = new List<Flight>();
			
			foreach (Flight f in input)
			{
				bool b = true;
				//Проверяется каждый сегмент, если хоть в одном нарушается условие - полёт не добавляется
				foreach (Segment s in f.Segments)
					if (s.DepartureDate > s.ArrivalDate)
					{
						b = false;
						break;
					}
				if (b)
					arr.Add(f);
			}
			
			//Неверный алгоритм
			//var arr = (from f in input
			//		   from s in f.Segments
			//		   where s.DepartureDate < s.ArrivalDate
			//		   select f
			//		   ).Distinct()
			//		   .ToList();

			return arr;
		}
	}
}
