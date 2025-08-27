using Microsoft.Extensions.Hosting;

namespace Realynx.CatTail;

public static class HostBuilderExtensions {
    public static CatTailOptions UseCatTail(this IHostBuilder hostBuilder) {
        hostBuilder.ConfigureServices((context, services) => {
            throw new NotImplementedException();
        });

        return new CatTailOptions(hostBuilder);
    }
}