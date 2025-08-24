using Realynx.CatTail.Targets.AzurePipelines.Attributes;
using Realynx.CatTail.Targets.AzurePipelines.Configurators;
using Realynx.CatTail.Targets.AzurePipelines.Interfaces;
using Realynx.CatTail.Targets.Common.Configurators;
using Realynx.CatTail.Targets.Common.Triggers;

namespace CatTail.Demo.WorkFlows;

[AzureWorkFlow("Build")]
public class StagedBuildWorkFlow : IStagedWorkFlow {
    public void ConfigureTriggers(WorkFlowTriggerConfigurator config) {
        config
            .AddTrigger(new OnPushTrigger("*"));
    }

    public void ConfigureStages(StageConfigurator config) {
        config
            .AddStage(new BuildWorkFlow());
    }
}