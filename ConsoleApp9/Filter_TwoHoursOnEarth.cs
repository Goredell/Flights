using System;
using System.Collections.Generic;

namespace Gridnine.FlightCodingTest
{
	class TwoHoursOnEarth : IFilter
	{
		//общее время, проведённое на земле превышает два часа
		public IList<Flight> filter(IList<Flight> input)
		{
			IList<Flight> arr = new List<Flight>();

			Console.WriteLine("общее время, проведённое на земле превышает два часа");

			foreach(Flight f in input)
			{
				//Полёт с одним сегментом автоматически добавляется т.к. не имеет времени на земле
				//
				if (f.Segments.Count == 1)
				{
					arr.Add(f);
					continue;
				}

				//поиск и сравнение суммарноо времени на земле
				TimeSpan count = new TimeSpan();
				for (int i = 1; i < f.Segments.Count; i++)
				{
					count += f.Segments[i].DepartureDate - f.Segments[i - 1].ArrivalDate;
				}
				if(count.Hours < 2)
				{
					arr.Add(f);
				}
			}
			
			return arr;
		}

	}
}
