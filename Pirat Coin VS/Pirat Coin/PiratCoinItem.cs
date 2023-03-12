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
using static Eco.Gameplay.Housing.PropertyValues.HomeFurnishingValue;
using Eco.PiratCoin;
using System.Reflection.Metadata.Ecma335;

namespace Eco.PiratCoin
{
    [Serialized]
    [RequireComponent(typeof(SolidAttachedSurfaceRequirementComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireRoomContainment]
    public partial class PiratCoinItem : WorldObject
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Pirat Coin"); } }
        public override DirectionAxisFlags RequiresSurfaceOnSides { get; } = 0
                    | DirectionAxisFlags.Down;
        
        static PiratCoinItem()
        {
            WorldObject.AddOccupancy<PiratCoinItem>(new List<BlockOccupancy>(){
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 1, 0)),
            });
        }





    [Serialized]
    [LocDisplayName("Pirat Coin")]
    [Weight(500)]
    [MaxStackSize(20)]
    [Currency]
    [Tag("Token")]
    [Ecopedia("Items", "Products", createAsSubPage: true]
    [Category(Hidden)]

    public partial class PiratCoinItem : Item;
    {
        public override LocString DisplayDescription {get { return Localizer.DoStr("An ancient mystical coin that secures the wealth of the world"); } }

static PiratCoinItem()
{

}
            }

