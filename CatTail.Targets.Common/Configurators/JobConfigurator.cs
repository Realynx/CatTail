using Realynx.CatTail.Targets.Common.Interfaces;
using Realynx.CatTail.Targets.Common.Models;

namespace Realynx.CatTail.Targets.Common.Configurators;

public class JobConfigurator {
    private readonly List<Job> _jobs = [];

    public JobConfigurator AddJob<TJob>(string name, string[]? dependsOn = null) where TJob : IJob {
        _jobs.Add(new Job(typeof(TJob), name, dependsOn));

        return this;
    }

    public JobConfigurator AddJobAfter<TJob>(string name, string[]? dependsOn = null) where TJob : IJob {
        dependsOn = [..dependsOn ?? [], .._jobs.Select(x => x.Name)];

        _jobs.Add(new Job(typeof(TJob), name, dependsOn));

        return this;
    }
}