using Realynx.CatTail.Targets.Common.Configurators;

namespace Realynx.CatTail.Targets.Common.Interfaces;

public interface IWorkFlow {
    void ConfigureTriggers(WorkFlowTriggerConfigurator config);
    void ConfigureJobs(JobConfigurator config);
}