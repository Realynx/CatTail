namespace Realynx.CatTail.Targets.AzurePipelines.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class GitHubActionsWorkFlowAttribute : Attribute {
    public string Name { get; }

    public GitHubActionsWorkFlowAttribute(string name) {
        Name = name;
    }
}