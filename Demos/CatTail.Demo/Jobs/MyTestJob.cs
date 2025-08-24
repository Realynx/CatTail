using Realynx.CatTail.Targets.Common.Configurators;
using Realynx.CatTail.Targets.Common.Models;

namespace CatTail.Demo.Jobs;

public class MyTestJob : Job {
    public MyTestJob(string name, string[]? dependsOn = null) : base(name, dependsOn) { }

    public override void ConfigureSteps(StepConfigurator config) {
        config
            .AddStep("Step 1", Step1)
            .AddStep("Step 2", Shell.Run("Echo", "Hellow, world!"))
            .AddStep("Step 3", Step3);
    }

    public void Step1() {}

    public void Step3() {}
}