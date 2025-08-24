using Realynx.CatTail.Targets.Common.Triggers.Interfaces;

namespace Realynx.CatTail.Targets.Common.Configurators;

public class WorkFlowTriggerConfigurator {
    private readonly List<IWorkFlowTrigger> _triggers = [];

    public WorkFlowTriggerConfigurator AddTrigger(IWorkFlowTrigger trigger) {
        _triggers.Add(trigger);

        return this;
    }
}