using Realynx.CatTail.Targets.Common.Configurators;
using Realynx.CatTail.Targets.Common.Interfaces;
using Realynx.CatTail.Targets.Common.Tasks;

namespace CatTail.Demo.Jobs;

public class MyLastJob : IJob {
    public void ConfigureSteps(StepConfigurator config) {
        config
            .AddStep("Zip", Zip.Directory(".").To("Out.zip"))
            .AddStep("Echo", Shell.Run("echo", "Execution finished!"));
    }
}