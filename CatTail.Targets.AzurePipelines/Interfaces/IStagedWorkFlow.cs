using Realynx.CatTail.Targets.AzurePipelines.Configurators;

namespace Realynx.CatTail.Targets.AzurePipelines.Interfaces;

public interface IStagedWorkFlow {
    void ConfigureStages(StageConfigurator config);
}