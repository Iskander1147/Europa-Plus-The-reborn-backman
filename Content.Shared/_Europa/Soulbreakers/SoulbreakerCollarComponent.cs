using Robust.Shared.GameStates;

namespace Content.Shared._Europa.Soulbreakers;

[RegisterComponent, NetworkedComponent]
[Access(typeof(SoulbreakerCollarSystem))]
public sealed partial class SoulbreakerCollarComponent : Component
{
    [DataField]
    public EntityUid? EnslavedEntity;

    [DataField]
    public TimeSpan EnslavingTime = TimeSpan.FromSeconds(1.5);

    [DataField]
    public TimeSpan UnEnslavingTime = TimeSpan.FromSeconds(3);

    [DataField]
    public int MaxAttemptsToUnequip = 3;

    [DataField]
    public int AttemptsToUnequip = 0;
}
