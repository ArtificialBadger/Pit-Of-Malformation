using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avotion.Shared.Goals;

public sealed class Day
{
    public DateOnly Date { get; init; }

    public IList<DailyGoal> Goals { get; set; } = new List<DailyGoal>();
}
