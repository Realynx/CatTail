using Realynx.CatTail.Targets.Common.Configurators;

namespace Realynx.CatTail.Targets.Common.Interfaces;

public interface IJob {
    string Name { get; }
    string[] DependsOn { get; }

    void ConfigureSteps(StepConfigurator config);
}