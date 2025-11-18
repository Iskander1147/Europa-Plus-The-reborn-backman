using Robust.Shared.GameStates;

namespace Content.Shared._Europa.Soulbreakers;

[RegisterComponent, NetworkedComponent]
public sealed partial class SoulbreakerSlavesSellPadComponent : Component
{
    [DataField("cooldown")]
    public TimeSpan Cooldown = TimeSpan.FromSeconds(10);

    [ViewVariables]
    public TimeSpan NextTeleportTime;
}
