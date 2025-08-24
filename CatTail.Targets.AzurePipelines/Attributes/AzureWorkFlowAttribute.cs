namespace Realynx.CatTail.Targets.AzurePipelines.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class AzureWorkFlowAttribute : Attribute {
    public string Name { get; }

    public AzureWorkFlowAttribute(string name) {
        Name = name;
    }
}