using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilmuri.Events;

public interface ITournamentEvent
{
	public string Name { get; }

	public string Description { get; }

}
