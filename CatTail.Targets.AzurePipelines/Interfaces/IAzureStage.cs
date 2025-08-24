using Realynx.CatTail.Targets.Common.Configurators;

namespace Realynx.CatTail.Targets.AzurePipelines.Interfaces;

public interface IAzureStage {
    void ConfigureJobs(JobConfigurator config);
}