using Realynx.CatTail.Targets.Common.Models;

namespace Realynx.CatTail.Targets.Common.Configurators;

public class JobConfigurator {
    private readonly List<Job> _jobs = [];

    public JobConfigurator AddJob(Job job) {
        _jobs.Add(job);

        return this;
    }

    public JobConfigurator AddJobAfter(Job job) {
        job.DependsOn = [..job.DependsOn, .._jobs.Select(x => x.Name)];

        _jobs.Add(job);

        return this;
    }
}