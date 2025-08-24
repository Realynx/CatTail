using Realynx.CatTail.Targets.Common.Triggers;
using Realynx.CatTail.Targets.Common.Triggers.Interfaces;

namespace Realynx.CatTail.Targets.AzurePipelines.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class AzureWorkFlowAttribute : Attribute {
    public string Name { get; }

    public List<IWorkFlowTrigger> Triggers { get; init; } = [];

    public AzureWorkFlowAttribute(string name) {
        Name = name;
    }
}