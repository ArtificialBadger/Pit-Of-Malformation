using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avotion.Shared.Goals;
public enum GoalStatus
{
	Failure = -2,
	PartialFailure = -1,
	NoData = 0,
	PartialSuccess = 1,
	Success = 2,
}
