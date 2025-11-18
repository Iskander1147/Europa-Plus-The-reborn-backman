using System.Linq;
using Content.Shared.Chat;
using Content.Shared.Interaction;
using Content.Shared.Movement.Pulling.Systems;
using Content.Shared.Popups;
using Content.Shared.Station;
using Content.Shared.Verbs;
using Robust.Shared.Audio;
using Robust.Shared.Audio.Systems;
using Robust.Shared.Map;
using Robust.Shared.Random;

namespace Content.Shared._Europa.Soulbreakers
{
    public abstract partial class SharedSoulbreakerTeleportSystem : EntitySystem
    {
    }

    [ByRefEvent]
    public record struct SoulbreakerSomeoneWasSold(EntityUid Slave, float price)
    {
        public readonly EntityUid Slave = Slave;
    }
}
