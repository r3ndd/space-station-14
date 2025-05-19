using Robust.Shared.Random;
using Content.Server.DoAfter;
using Content.Shared.Interaction.Events;
using Content.Shared.Hands.Components;
using Content.Shared.Inventory;

namespace Content.Server.Pathogens
{
    public sealed partial class PathogensSystem : EntitySystem
    {
        [Dependency] private readonly IRobustRandom _random = default!;
        [Dependency] private readonly InventorySystem _inventory = default!;
        [Dependency] private readonly DoAfterSystem _doAfterSystem = default!;

        public override void Initialize()
        {
            SubscribeLocalEvent<HandsComponent, ContactInteractionEvent>(OnInteract);
        }

        private void OnInteract(EntityUid user, HandsComponent component, ContactInteractionEvent args)
        {
            var target = args.Other;

            if (HasComp<IgnoresPathogensComponent>(target))
                return;

            var reservoir = EnsureComp<PathogenReservoirComponent>(target);

            if (_inventory.TryGetSlotEntity(user, "gloves", out var gloves))
            {
                // Todo: Check if gloves are fingerless
                return;
            }

            // Todo: Transfer pathogens from user to target
        }
    }
}
