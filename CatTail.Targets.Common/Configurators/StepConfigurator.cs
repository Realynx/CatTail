using Realynx.CatTail.Targets.Common.Interfaces;
using Realynx.CatTail.Targets.Common.Models;

namespace Realynx.CatTail.Targets.Common.Configurators;

public class StepConfigurator {
    private readonly List<IStep> _steps = [];

    public StepConfigurator AddStep(IStep step) {
        _steps.Add(step);

        return this;
    }

    public StepConfigurator AddStep(string name, Action action)
        => AddStep(new Step(name, action));

    public StepConfigurator AddStep(string name, IStepProvider stepProvider)
        => throw new NotImplementedException();
}