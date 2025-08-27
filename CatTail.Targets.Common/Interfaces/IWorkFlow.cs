using Realynx.CatTail.Targets.Common.Configurators;

namespace Realynx.CatTail.Targets.Common.Interfaces;

public interface IWorkFlow
#if DEBUG
    : Realynx.CatTail.Interfaces.IBuildStage
#endif
{
    void ConfigureTriggers(WorkFlowTriggerConfigurator config);
    void ConfigureJobs(JobConfigurator config);
}