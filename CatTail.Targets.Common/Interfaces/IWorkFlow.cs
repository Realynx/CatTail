using Realynx.CatTail.Targets.Common.Configurators;

namespace Realynx.CatTail.Targets.Common.Interfaces;

public interface IWorkFlow {
    void ConfigureJobs(JobConfigurator config);
}