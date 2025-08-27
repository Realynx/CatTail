using CatTail.Demo.WorkFlows;

using Microsoft.Extensions.Hosting;

using Realynx.CatTail;
using Realynx.CatTail.Targets.AzurePipelines.Extensions;
using Realynx.CatTail.Targets.Common.Extensions;

namespace CatTail.Demo;

public static class Program {
    public static void Main(string[] args) {
        var builderHost = new HostBuilder()
            .ConfigureDefaults(args);

        builderHost.UseCatTail()
            .AddWorkFlow<BuildWorkFlow>()
            .AddStagedWorkFlow<StagedBuildWorkFlow>();

        builderHost.UseConsoleLifetime();
        var host = builderHost.Build();
        host.Run();
    }
}