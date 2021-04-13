using System;
using System.Collections.Generic;
using System.Linq;

namespace Gridnine.FlightCodingTest
{
	public class FlightWorker
	{
		public IFilter Strategy { get; set; }
		public FlightWorker (IFilter _strategy)
		{
			Strategy = _strategy;
		}

		public IList<Flight> filter(IList<Flight> input)
		{
			return Strategy.filter(input);
		}
	}
}
