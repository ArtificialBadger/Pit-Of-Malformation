using Bilmuri.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilmuri.TournamentEventMediators;
internal sealed class CombatTournamentEventMediator : ITournamentEventMediator<CombatTournamentEvent, ITournamentEntrant>
{
	public Task<Dictionary<Guid, decimal>> RunEvent(CombatTournamentEvent tournamentEvent, IEnumerable<ITournamentEntrant> entrants)
	{
		var results = new Dictionary<Guid, decimal>();

		var ordered = entrants.OrderByDescending(x => x);
		var total = entrants.Count();

		var nextBestScore = ordered.First().Strength;
		var scoresAssigned = 0;
		var currentScore = 1.0m;
		foreach (var i in ordered.Take(total - 1))
		{
			if (i.Strength != nextBestScore)
			{
				currentScore = (decimal)(1 / (Math.Pow(2, scoresAssigned)));
				nextBestScore = i.Strength;
			}

			results.Add(i.Id, currentScore);
			scoresAssigned++;
		}

		results.Add(ordered.Last().Id, 0);

		return Task.FromResult(results);
	}
}
