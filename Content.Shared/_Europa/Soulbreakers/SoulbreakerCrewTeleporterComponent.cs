using Robust.Shared.GameStates;

namespace Content.Shared._Europa.Soulbreakers;

[RegisterComponent, NetworkedComponent]
public sealed partial class SoulbreakerCrewTeleporterComponent : Component
{
    [DataField]
    public EntityUid? TeleportationSubject;

    [DataField("cooldown")]
    public TimeSpan Cooldown = TimeSpan.FromSeconds(10);

    [ViewVariables]
    public TimeSpan NextTeleportTime;
}
