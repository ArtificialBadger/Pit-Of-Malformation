using Bilmuri.Events;
using Bilmuri.TournamentEntrants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilmuri.TournamentEventMediators;
public interface ITournamentEventMediator<TEvent, TEntrant> 
	where TEntrant : ITournamentEntrant
	where TEvent : ITournamentEvent
{
	public Task<Dictionary<Guid, decimal>> RunEvent(TEvent tournamentEvent, IEnumerable<TEntrant> entrants);
}
