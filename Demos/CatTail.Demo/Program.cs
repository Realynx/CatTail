using Microsoft.Extensions.Hosting;

using Realynx.CatTail;

namespace CatTail.Demo;

public static class Program {
    public static void Main(string[] args) {
        var builderHost = new HostBuilder()
            .ConfigureDefaults(args);

        builderHost.UseCatTail()
            .AddBuildStage("Test")
            .AddBuildStage("Build")
            .AddBuildStage("Publish");

        builderHost.UseConsoleLifetime();
        var host = builderHost.Build();
        host.Run();
    }
}