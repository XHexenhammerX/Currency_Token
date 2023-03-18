namespace Eco.PirateCoin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Gameplay.Pipes.Gases;
    using Eco.Gameplay.Systems.Tooltip;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Gameplay.Civics.Objects;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Core.Controller;
    using Eco.PiratCoin;
    using System.Numerics;

    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(SolidAttachedSurfaceRequirementComponent))]
    [RequireComponent(typeof(RoomRequirementsComponent))]
    [RequireRoomContainment]

    public partial class PirateCoinObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Pirate Coin"); } }

        public virtual Type RepresentedItemType { get { return typeof(PirateCoinItem); } }

        protected override void Initialize() { }

        static PirateCoinObject() { }

        public override void OnPermanentDestroy()
        {
            base.OnPermanentDestroy();
        }
    }
    [Serialized]
    [Currency]
    [MaxStackSize(50)]
    [Weight(500)]
    [LocDisplayName("Pirate Coin")]
    public partial class PirateCoinItem : WorldObjectItem<PirateCoinObject>
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A mystic coin "); } }
        public override DirectionAxisFlags RequiresSurfaceOnSides { get; } = 0
                    | DirectionAxisFlags.Down;// maybe Down for place it on the ground
        static PiratCoinItem()
        {
            WorldObject.AddOccupancy<PirateCoinObject>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
        }

    }
}   