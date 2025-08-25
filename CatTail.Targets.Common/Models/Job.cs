namespace Realynx.CatTail.Targets.Common.Models;

internal record Job {
    public Job(Type jobType, string name, string[]? dependsOn) {
        JobType = jobType;
        Name = name;
        DependsOn = dependsOn ?? [];
    }

    public Type JobType { get; set; }
    public string Name { get; set; }
    public string[] DependsOn { get; set; }
}