using System;
using System.Collections.Generic;
using Gridnine.FlightCodingTest;

namespace Flights
{
	class Program
	{
		static void Main()
		{
			FlightBuilder FB = new FlightBuilder();
			var FW = new FlightWorker(new DepartureBeforeArrival());
			var flights = FB.GetFlights();

			talker(flights);

			talker(FW.filter(flights));

			FW.Strategy = new DepartureBeforeNow();
			talker(FW.filter(flights));

			FW.Strategy = new TwoHoursOnEarth();
			talker(FW.filter(flights));

		}

		//Функция выводящая все сегмены всех полётов
		static public void talker(IList<Flight> input)
		{
			foreach (Flight f in input)
			{
				foreach (Segment s in f.Segments)
					Console.Write($"{s.DepartureDate} - {s.ArrivalDate} ");
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
