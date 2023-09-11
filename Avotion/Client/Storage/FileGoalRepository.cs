using Avotion.Shared.Goals;
using Microsoft.Extensions.FileProviders;

namespace Avotion.Client.Storage;

public class FileGoalRepository : IGoalRepository
{
    private string Path = "goals.json";

    public Task SaveDay(Day day)
    {
        throw new NotImplementedException();
    }

    public async Task SaveGoals(IEnumerable<Goal> Goals)
    {
        using var file = File.Create("./avotion.test");
        await Task.Delay(100);
    }
}
