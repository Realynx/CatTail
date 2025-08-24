using Realynx.CatTail.Targets.AzurePipelines.Configurators;
using Realynx.CatTail.Targets.Common.Configurators;

namespace Realynx.CatTail.Targets.AzurePipelines.Interfaces;

public interface IStagedWorkFlow {
    void ConfigureTriggers(WorkFlowTriggerConfigurator config);
    void ConfigureStages(StageConfigurator config);
}