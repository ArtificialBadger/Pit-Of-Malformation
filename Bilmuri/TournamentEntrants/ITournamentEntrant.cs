using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilmuri.TournamentEntrants;

public interface ITournamentEntrant
{
	public Guid Id { get; }

	public String Name { get; }

	public String Description { get; }

	public decimal Strength { get; }

}
