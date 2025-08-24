namespace Realynx.CatTail.Targets.AzurePipelines.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class ShellScriptAttribute : Attribute {
    public string Name { get; }

    public ShellScriptAttribute(string name) {
        Name = name;
    }
}