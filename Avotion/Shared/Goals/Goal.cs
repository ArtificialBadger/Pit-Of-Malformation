using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avotion.Shared.Goals;
public record Goal
{
	public required Guid Id { get; init; }

	public required string Name { get; init; }

	public required string Description { get; init; }

	public required string Key { get; init; }
}
