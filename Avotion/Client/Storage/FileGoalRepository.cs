﻿using Avotion.Shared.Goals;
using Microsoft.Extensions.FileProviders;
using System.Diagnostics;

namespace Avotion.Client.Storage;

public class FileGoalRepository : IGoalRepository
{
    public Task SaveDay(Day day)
    {
        throw new NotImplementedException();
    }

    public async Task SaveGoals(IEnumerable<Goal> Goals)
    {
        var parentDir = Directory.GetParent(".");
        using var file = File.Create("../.././avotion.test");
        Debug.WriteLine(file.Name);
        Debug.WriteLine(parentDir);
        await Task.Delay(100);
    }
}
