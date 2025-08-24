using Realynx.CatTail.Targets.Common.Configurators;
using Realynx.CatTail.Targets.Common.Models;

namespace CatTail.Demo.Jobs;

public class MyLastJob : Job {
    public MyLastJob(string name, string[]? dependsOn = null) : base(name, dependsOn) { }

    public override void ConfigureSteps(StepConfigurator config) {
        throw new NotImplementedException();
    }
}