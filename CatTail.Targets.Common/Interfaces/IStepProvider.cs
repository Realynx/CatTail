namespace Realynx.CatTail.Targets.Common.Interfaces;

public interface IStepProvider {
    // TODO: Figure this out
    bool IsManagedStep { get; }
    void Execute();
    string GetSerialized();
}