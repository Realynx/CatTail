using Realynx.CatTail.Targets.Common.Interfaces;

namespace Realynx.CatTail.Targets.Common.Tasks;

public static class DotNet {
    public static IStepProvider Build(string? file = null, params string[] arguments) {
        throw new NotImplementedException();
    }

    public static IStepProvider Clean(string? file = null, params string[] arguments) {
        throw new NotImplementedException();
    }

    public static IStepProvider Publish(string? file = null, params string[] arguments) {
        throw new NotImplementedException();
    }

    public static IStepProvider Restore(string? file = null, params string[] arguments) {
        throw new NotImplementedException();
    }

    public static IStepProvider Run(string? file = null, params string[] arguments) {
        throw new NotImplementedException();
    }

    public static IStepProvider Test(string? file = null, params string[] arguments) {
        throw new NotImplementedException();
    }
}