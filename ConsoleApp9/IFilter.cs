using System;
using System.Collections.Generic;

namespace Gridnine.FlightCodingTest
{
	public interface IFilter
	{
		public IList<Flight> filter(IList<Flight> input);
	}
}
