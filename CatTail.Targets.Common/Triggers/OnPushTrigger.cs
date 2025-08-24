using Realynx.CatTail.Targets.Common.Triggers.Interfaces;

namespace Realynx.CatTail.Targets.Common.Triggers;

public class OnPushTrigger : IWorkFlowTrigger {
    public string Condition { get; }

    public OnPushTrigger(string condition) {
        Condition = condition;
    }
}