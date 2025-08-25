using Realynx.CatTail.Targets.Common.Interfaces;

namespace Realynx.CatTail.Targets.Common.Tasks;

public class Zip {
    private Zip(string[] paths) {
        _paths = paths;
    }

    private string[] _paths;

    public IStepProvider To(string destination) {
        throw new NotImplementedException();
    }

    public static Zip Files(params string[] files) {
        return new Zip(files);
    }

    public static Zip Directory(string directory) {
        return new Zip([directory]);
    }
}