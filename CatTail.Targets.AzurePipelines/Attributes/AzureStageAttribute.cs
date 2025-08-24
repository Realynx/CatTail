namespace Realynx.CatTail.Targets.AzurePipelines.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class AzureStageAttribute : Attribute {
    public string Name { get; }

    public AzureStageAttribute(string name) {
        Name = name;
    }
}