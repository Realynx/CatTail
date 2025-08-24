using Realynx.CatTail.Targets.Common.Configurators;
using Realynx.CatTail.Targets.Common.Interfaces;

namespace Realynx.CatTail.Targets.Common.Models;

public abstract class Job : IJob {
    public string Name { get; internal set; }
    public string[] DependsOn { get; internal set; }

    protected Job(string name, string[]? dependsOn = null) {
        Name = name;
        DependsOn = dependsOn ?? [];
    }

    public abstract void ConfigureSteps(StepConfigurator config);
}