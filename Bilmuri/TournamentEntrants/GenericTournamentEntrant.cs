using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilmuri.TournamentEntrants;
public sealed class GenericTournamentEntrant : ITournamentEntrant
{

	public GenericTournamentEntrant(Guid Id, String Name, String Description, decimal Strength)
	{
		this.Id = Id;
		this.Name = Name;
		this.Description = Description;
		this.Strength = Strength;
	}	

	public Guid Id { get; init; }

	public string Name { get; init; }

	public string Description { get; init; }

	public decimal Strength { get; init; }
}
