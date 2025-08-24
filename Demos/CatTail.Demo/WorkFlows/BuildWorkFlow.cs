using CatTail.Demo.Jobs;

using Realynx.CatTail.Targets.AzurePipelines.Attributes;
using Realynx.CatTail.Targets.AzurePipelines.Interfaces;
using Realynx.CatTail.Targets.Common.Configurators;
using Realynx.CatTail.Targets.Common.Interfaces;
using Realynx.CatTail.Targets.Common.Triggers;

namespace CatTail.Demo.WorkFlows;

[ShellScript("Build.sh")]
[GitHubActionsWorkFlow("Build")]
[AzureWorkFlow("Build")]
[AzureStage("Build")]
public class BuildWorkFlow : IAzureStage, IWorkFlow {
    public void ConfigureTriggers(WorkFlowTriggerConfigurator config) {
        config
            .AddTrigger(new OnPushTrigger("master"));
    }

    public void ConfigureJobs(JobConfigurator config) {
        config
            .AddJob(new MyTestJob("Test"))
            .AddJob(new MyBuildJob("Build", dependsOn: ["Test"]))
            .AddJobAfter(new MyLastJob("Final"));
    }
}