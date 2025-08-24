using Realynx.CatTail.Targets.AzurePipelines.Interfaces;

namespace Realynx.CatTail.Targets.AzurePipelines.Configurators;

public class StageConfigurator {
    private readonly List<IAzureStage> _stages = [];

    public StageConfigurator AddStage(IAzureStage stage) {
        _stages.Add(stage);

        return this;
    }
}