namespace Realynx.CatTail.Targets.Common.Interfaces;

public interface IStep {
    string Name { get; }
    Action Action { get; }
}