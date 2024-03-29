﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avotion.Shared.Goals;
public sealed record DailyGoal
{
	public required string Key { get; init; }

	public required GoalStatus Status { get; init; }
}
