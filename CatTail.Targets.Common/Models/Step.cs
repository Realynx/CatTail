using Realynx.CatTail.Targets.Common.Interfaces;

namespace Realynx.CatTail.Targets.Common.Models;

internal record Step : IStep {
    public Step(string name, Action action) {
        Name = name;
        Action = action;
    }

    public string Name { get; set; }

    public Action Action { get; set; }
}