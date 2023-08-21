using Bilmuri.Events;
using Bilmuri.TournamentEntrants;
using Bilmuri.TournamentEventMediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilmuri;

public sealed class Tournament
{
	public Dictionary<Guid, decimal> CurrentScore { get; } = new Dictionary<Guid, decimal>();

	public List<ITournamentEntrant> Entrants { get; init; }

	public List<ITournamentEvent> Events { get; init; }

	private int currentRound = 0;

	public Task RunNextRound()
	{
		//TODO: What was going on here?
		
		var currentEvent = Events[currentRound];

		//var mediator = 

		currentRound++;

		return Task.CompletedTask;
	}


}
