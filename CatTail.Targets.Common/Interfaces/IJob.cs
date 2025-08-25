using Realynx.CatTail.Targets.Common.Configurators;

namespace Realynx.CatTail.Targets.Common.Interfaces;

public interface IJob {
    void ConfigureSteps(StepConfigurator config);
}