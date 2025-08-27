using Realynx.CatTail.Targets.Common.Configurators;

namespace Realynx.CatTail.Targets.AzurePipelines.Interfaces;

public interface IAzureStage
#if DEBUG
    : Realynx.CatTail.Interfaces.IBuildStage
#endif
{
    void ConfigureJobs(JobConfigurator config);
}