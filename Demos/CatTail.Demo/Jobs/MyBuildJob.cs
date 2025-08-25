using Realynx.CatTail.Targets.Common.Configurators;
using Realynx.CatTail.Targets.Common.Interfaces;
using Realynx.CatTail.Targets.Common.Tasks;

namespace CatTail.Demo.Jobs;

public class MyBuildJob : IJob {
    public void ConfigureSteps(StepConfigurator config) {
        config
            .AddStep("Build", DotNet.Build());
    }
}