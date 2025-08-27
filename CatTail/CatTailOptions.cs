using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Realynx.CatTail.Interfaces;

namespace Realynx.CatTail;

public class CatTailOptions {
    private readonly IHostBuilder _hostBuilder;

    internal CatTailOptions(IHostBuilder hostBuilder) {
        _hostBuilder = hostBuilder;
    }

    internal CatTailOptions AddBuildStage<TBuildStage>() where TBuildStage : class
#if DEBUG
        , IBuildStage
#endif
    {
        _hostBuilder.ConfigureServices((context, services) => {
            services.AddSingleton<TBuildStage>();
        });

        return this;
    }
}