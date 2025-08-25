using Realynx.CatTail.Targets.Common.Configurators;
using Realynx.CatTail.Targets.Common.Interfaces;
using Realynx.CatTail.Targets.Common.Tasks;

namespace CatTail.Demo.Jobs;

public class MyTestJob : IJob {
    public void ConfigureSteps(StepConfigurator config) {
        config
            .AddStep("Step 1", Step1)
            .AddStep("Step 2", DotNet.Test("TestProject.csproj"))
            .AddStep("Step 3", Step3);
    }

    public void Step1() {}

    public void Step3() {}
}