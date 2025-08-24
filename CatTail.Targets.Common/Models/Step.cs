using Realynx.CatTail.Targets.Common.Interfaces;

namespace Realynx.CatTail.Targets.Common.Models;

public class Step : IStep {
    public string Name { get; internal set; }
    public Action Action { get; internal set; }

    public Step(string name, Action action) {
        Name = name;
        Action = action;
    }
}