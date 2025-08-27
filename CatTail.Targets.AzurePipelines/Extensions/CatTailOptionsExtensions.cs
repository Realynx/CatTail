using Realynx.CatTail.Targets.AzurePipelines.Interfaces;

namespace Realynx.CatTail.Targets.AzurePipelines.Extensions;

public static class CatTailOptionsExtensions {
    public static CatTailOptions AddAzureStage<TAzureStage>(this CatTailOptions options) where TAzureStage : class, IAzureStage {
        return options.AddBuildStage<TAzureStage>();
    }

    public static CatTailOptions AddStagedWorkFlow<TStagedWorkFlow>(this CatTailOptions options) where TStagedWorkFlow : class, IStagedWorkFlow {
        return options.AddBuildStage<TStagedWorkFlow>();
    }
}