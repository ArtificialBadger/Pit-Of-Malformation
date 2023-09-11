using Avotion.Shared.Goals;
using Microsoft.Extensions.FileProviders;

namespace Avotion.Client.Storage;

public class FileGoalRepository : IGoalRepository
{
    public Task SaveDay(Day day)
    {
        throw new NotImplementedException();
    }

    public Task SaveGoals(IEnumerable<Goal> Goals)
    {
        throw new NotImplementedException();
    }
}
