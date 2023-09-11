using Avotion.Shared.Goals;

namespace Avotion.Client.Storage;

public interface IGoalRepository
{
    Task SaveGoals(IEnumerable<Goal> Goals);

    Task SaveDay(Day day);
}
