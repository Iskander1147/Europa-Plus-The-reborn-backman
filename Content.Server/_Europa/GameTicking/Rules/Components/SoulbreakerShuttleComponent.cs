namespace Content.Server._Europa.GameTicking.Rules.Components;

[RegisterComponent, Access(typeof(SoulbreakersRuleSystem))]
public sealed partial class SoulbreakerShuttleComponent : Component
{
    [DataField]
    public EntityUid AssociatedRule;
}
