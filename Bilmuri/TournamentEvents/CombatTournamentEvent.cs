using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilmuri.Events;
public sealed class CombatTournamentEvent : ITournamentEvent
{
	public string Name => "Combat";

	public string Description => "Basic matchup of power scores. Used mostly for testing.";
}
