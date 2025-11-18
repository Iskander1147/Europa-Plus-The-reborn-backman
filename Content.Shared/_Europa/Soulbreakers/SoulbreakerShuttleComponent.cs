using Robust.Shared.GameStates;

namespace Content.Shared._Europa.Soulbreakers;

[RegisterComponent, NetworkedComponent]
public sealed partial class SoulbreakerShuttleComponent : Component
{
    [DataField]
    public EntityUid AssociatedRule;
}
