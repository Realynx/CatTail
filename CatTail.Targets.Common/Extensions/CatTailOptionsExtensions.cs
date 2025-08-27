using Realynx.CatTail.Targets.Common.Interfaces;

namespace Realynx.CatTail.Targets.Common.Extensions;

public static class CatTailOptionsExtensions {
    public static CatTailOptions AddWorkFlow<TWorkFlow>(this CatTailOptions options) where TWorkFlow : class, IWorkFlow {
        return options.AddBuildStage<TWorkFlow>();
    }
}