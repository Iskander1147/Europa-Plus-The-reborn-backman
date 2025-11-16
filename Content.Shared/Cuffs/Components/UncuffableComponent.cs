using Robust.Shared.GameStates;

namespace Content.Shared.Cuffs.Components;

[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedCuffableSystem))]
public sealed partial class UncuffableComponent : Component
{
}
