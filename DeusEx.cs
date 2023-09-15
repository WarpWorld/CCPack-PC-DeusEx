using System;
using CrowdControl.Common;
using JetBrains.Annotations;
using ConnectorType = CrowdControl.Common.ConnectorType;

namespace CrowdControl.Games.Packs;

[UsedImplicitly]
public class DeusEx : SimpleTCPPack
{
    public override string Host => "0.0.0.0";

    public override ushort Port => 43384;

    public override ISimpleTCPPack.MessageFormat MessageFormat => ISimpleTCPPack.MessageFormat.CrowdControlLegacy;

    public DeusEx(UserRecord player, Func<CrowdControlBlock, bool> responseHandler, Action<object> statusUpdateHandler) : base(player, responseHandler, statusUpdateHandler) { }

    public override Game Game { get; } = new(90, "Deus Ex Randomizer", "DeusEx", "PC", ConnectorType.SimpleTCPConnector);

    public override EffectList Effects { get; } = new Effect[]
    {
        //General Effects
        new("Trigger the Killswitch", "kill"),
        new("Poison the Player", "poison"),
        new("Glass Legs", "glass_legs"),
        new("Give Health (x10)", "give_health") { Quantity = 100 },
        new("Set On Fire", "set_fire"),
        new("Full Heal", "full_heal"),
        new("Drunk Mode (1 minute)", "drunk_mode"),
        new("Drop Selected Item", "drop_selected_item"),
        new("Enable Matrix Mode (1 Minute)", "matrix"),
        new("Give Player EMP Field (15 seconds)", "emp_field"),
        new("Give Bioelectric Energy (x10)", "give_energy") { Quantity = 100 },
        new("Give Skill Points (x100)", "give_skillpoints") { Quantity = 1000 }, //Updated text for second Crowd Control batch
        new("Remove Skill  Points (x100)", "remove_skillpoints") { Quantity = 1000 }, //Updated text for second Crowd Control batch
        new("Disable Jump (1 minute)", "disable_jump"),
        new("Gotta Go Fast (1 minute)", "gotta_go_fast"),
        new("Slow Like Snail (1 minute)", "gotta_go_slow"),
        new("Ice Physics! (1 minute)","ice_physics"),
        new("Go Third-Person (1 minute)","third_person"),
        new("Take Double Damage (1 minute)","dmg_double"),
        new("Take Half Damage (1 minute)","dmg_half"),
        new("Give Credits (x100)", "add_credits") { Quantity = 1000 }, //Updated for text second Crowd Control batch
        new("Remove Credits (x100)", "remove_credits") { Quantity = 1000 }, //Updated text for second Crowd Control batch
        new("Upgrade a Flamethrower to a LAMThrower (1 minute)", "lamthrower"),

        new("Ask a Question","ask_a_question"), //New for second Crowd Control batch
        new("Nudge","nudge"), //New for second Crowd Control batch
        new("Swap Player with another human","swap_player_position"), //New for second Crowd Control batch
        new("Float Away","floaty_physics"), //New for second Crowd Control batch
        new("Floor is Lava","floor_is_lava"), //New for second Crowd Control batch
        new("Invert Mouse Controls","invert_mouse"), //New for second Crowd Control batch
        new("Invert Movement Controls","invert_movement"), //New for second Crowd Control batch
        new("Earthquake","earthquake"), //New for fourth Crowd Control batch
        new("Full Bioelectric Energy","give_full_energy"), //New for fourth Crowd Control batch
        new("Trigger all alarms","trigger_alarms"), //New for fourth Crowd Control batch
        new("Flip camera upside down","flipped"), //New for fourth Crowd Control batch
        new("Flip camera sideways","limp_neck"), //New for fourth Crowd Control batch
        new("Do a barrel roll!","barrel_roll"), //New for fourth Crowd Control batch
        new("Set off a Flashbang", "flashbang"), //New for fourth Crowd Control batch
        new("Eat Beans", "eat_beans"), //New for fourth Crowd Control batch
        new("Fire the current weapon", "fire_weapon"), //New for fourth Crowd Control batch
        new("Switch to next item", "next_item"), //New for fourth Crowd Control batch
        new("Switch to next HUD color scheme", "next_hud_color"), //New for fourth Crowd Control batch
        new("Quick Save", "quick_save"), //New for fourth Crowd Control batch
        new("Quick Load", "quick_load"), //New for fourth Crowd Control batch

        //Spawn Enemies/Allies
        //new Effect("Spawn Enemies/Allies","spawnpawns",ItemKind.Folder), //New for fourth Crowd Control batch
        new("Spawn Medical Bot", "spawnfriendly_medicalbot") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
        new("Spawn Repair Bot", "spawnfriendly_repairbot") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
        new("Spawn hostile Spider Bot", "spawnenemy_spiderbot2") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
        new("Spawn hostile MJ12 Commando", "spawnenemy_mj12commando") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
        new("Spawn hostile Security Bot", "spawnenemy_securitybot4") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
        new("Spawn friendly Security Bot", "spawnfriendly_securitybot4") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
        new("Spawn hostile Military Bot", "spawnenemy_militarybot") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
        new("Spawn friendly Military Bot", "spawnfriendly_militarybot") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
        new("Spawn hostile Doberman", "spawnenemy_doberman") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
        new("Spawn hostile Greasel", "spawnenemy_greasel") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch

        //Items
        //new Effect("Give Items","giveitems",ItemKind.Folder), //New folder for third batch
        new("Give a Medkit", "give_medkit") { Category = "Give Items" }, //Moved into new folder for third batch
        new("Give a Biocell", "give_bioelectriccell") { Category = "Give Items" }, //Moved into new folder for third batch
        new("Give a Fire Extinguisher", "give_fireextinguisher") { Category = "Give Items" }, //New for third Crowd Control batch
        new("Give a Ballistic Armor", "give_ballisticarmor") { Category = "Give Items" }, //New for third Crowd Control batch
        new("Give a Lockpick", "give_lockpick") { Category = "Give Items" }, //New for third Crowd Control batch
        new("Give a Multitool", "give_multitool") { Category = "Give Items" }, //New for third Crowd Control batch
        new("Give a Rebreather", "give_rebreather") { Category = "Give Items" }, //New for third Crowd Control batch
        new("Give a Thermoptic Camo", "give_adaptivearmor") { Category = "Give Items" }, //New for third Crowd Control batch
        new("Give a HazMat Suit", "give_hazmatsuit") { Category = "Give Items" }, //New for third Crowd Control batch
        new("Give a bottle of Wine", "give_winebottle") { Category = "Give Items" }, //New for Fourth Crowd Control batch
        new("Give a set of Tech Goggles", "give_techgoggles") { Category = "Give Items" }, //New for Fourth Crowd Control batch

        //Add/Remove Augs
        //new Effect("Add/Upgrade Augmentations","addaugs",ItemKind.Folder),
        //new Effect("Remove/Downgrade Augmentations","remaugs",ItemKind.Folder),

        new("Add/Upgrade Aqualung", "add_augaqualung") { Category = "Augmentations" },
        new("Add/Upgrade Ballistic Protection", "add_augballistic") { Category = "Augmentations" },
        new("Add/Upgrade Cloak", "add_augcloak") { Category = "Augmentations" },
        new("Add/Upgrade Combat Strength", "add_augcombat") { Category = "Augmentations" },
        new("Add/Upgrade Aggressive Defense System", "add_augdefense") { Category = "Augmentations" },
        new("Add/Upgrade Spy Drone", "add_augdrone") { Category = "Augmentations" },
        new("Add/Upgrade EMP Shield", "add_augemp") { Category = "Augmentations" },
        new("Add/Upgrade Environmental Resistance", "add_augenviro") { Category = "Augmentations" },
        new("Add/Upgrade Regeneration", "add_aughealing") { Category = "Augmentations" },
        new("Add/Upgrade Synthetic Heart", "add_augheartlung") { Category = "Augmentations" },
        new("Add/Upgrade Microfibral Muscle", "add_augmuscle") { Category = "Augmentations" },
        new("Add/Upgrade Power Recirculator", "add_augpower") { Category = "Augmentations" },
        new("Add/Upgrade Radar Transparancy", "add_augradartrans") { Category = "Augmentations" },
        new("Add/Upgrade Energy Shield", "add_augshield") { Category = "Augmentations" },
        new("Add/Upgrade Speed Enhancement", "add_augspeed") { Category = "Augmentations" },
        new("Add/Upgrade Run Silent", "add_augstealth") { Category = "Augmentations" },
        new("Add/Upgrade Targeting", "add_augtarget") { Category = "Augmentations" },
        new("Add/Upgrade Vision Enhancement", "add_augvision") { Category = "Augmentations" },

        new("Remove/Downgrade Aqualung", "rem_augaqualung") { Category = "Augmentations" },
        new("Remove/Downgrade Ballistic Protection", "rem_augballistic") { Category = "Augmentations" },
        new("Remove/Downgrade Cloak", "rem_augcloak") { Category = "Augmentations" },
        new("Remove/Downgrade Combat Strength", "rem_augcombat") { Category = "Augmentations" },
        new("Remove/Downgrade Aggressive Defense System", "rem_augdefense") { Category = "Augmentations" },
        new("Remove/Downgrade Spy Drone", "rem_augdrone") { Category = "Augmentations" },
        new("Remove/Downgrade EMP Shield", "rem_augemp") { Category = "Augmentations" },
        new("Remove/Downgrade Environmental Resistance", "rem_augenviro") { Category = "Augmentations" },
        new("Remove/Downgrade Regeneration", "rem_aughealing") { Category = "Augmentations" },
        new("Remove/Downgrade Synthetic Heart", "rem_augheartlung") { Category = "Augmentations" },
        new("Remove/Downgrade Microfibral Muscle", "rem_augmuscle") { Category = "Augmentations" },
        new("Remove/Downgrade Power Recirculator", "rem_augpower") { Category = "Augmentations" },
        new("Remove/Downgrade Radar Transparancy", "rem_augradartrans") { Category = "Augmentations" },
        new("Remove/Downgrade Energy Shield", "rem_augshield") { Category = "Augmentations" },
        new("Remove/Downgrade Speed Enhancement", "rem_augspeed") { Category = "Augmentations" },
        new("Remove/Downgrade Run Silent", "rem_augstealth") { Category = "Augmentations" },
        new("Remove/Downgrade Targeting", "rem_augtarget") { Category = "Augmentations" },
        new("Remove/Downgrade Vision Enhancement", "rem_augvision") { Category = "Augmentations" },


        //Drop Grenades
        //new Effect("Drop a live grenade","dropgrenade",ItemKind.Folder),

        new("Drop a Live LAM", "drop_lam") { Category = "Drop Live Grenade" },
        new("Drop a Live EMP Grenade", "drop_empgrenade") { Category = "Drop Live Grenade" },
        new("Drop a Live Gas Grenade", "drop_gasgrenade") { Category = "Drop Live Grenade" },
        new("Drop a Live Scrambler Grenade", "drop_nanovirusgrenade") { Category = "Drop Live Grenade" },


        //Weapons
        //new Effect("Give Weapons","giveweapon",ItemKind.Folder),

        new("Give Flamethrower", "give_weaponflamethrower") { Category = "Give Weapon" },
        new("Give GEP Gun", "give_weapongepgun") { Category = "Give Weapon" },
        new("Give Dragon Tooth Sword", "give_weaponnanosword") { Category = "Give Weapon" },
        new("Give Plasma Rifle", "give_weaponplasmarifle") { Category = "Give Weapon" },
        new("Give LAW", "give_weaponlaw") { Category = "Give Weapon" },
        new("Give Sniper Rifle", "give_weaponrifle") { Category = "Give Weapon" },
        new("Give Assault Rifle", "give_weaponassaultgun") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Assault Shotgun", "give_weaponassaultshotgun") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Baton", "give_weaponbaton") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Combat Knife", "give_weaponcombatknife") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Crowbar", "give_weaponcrowbar") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Mini Crossbow", "give_weaponminicrossbow") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Pepper Spray", "give_weaponpeppergun") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Pistol", "give_weaponpistol") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Stealth Pistol", "give_weaponstealthpistol") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Riot Prod", "give_weaponprod") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Sawed-off Shotgun", "give_weaponsawedoffshotgun") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Throwing Knives", "give_weaponshuriken") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Sword", "give_weaponsword") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give LAM", "give_weaponlam") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give EMP Grenade", "give_weaponempgrenade") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Gas Grenade", "give_weapongasgrenade") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give Scrambler Grenade", "give_weaponnanovirusgrenade") { Category = "Give Weapon" },  //New for second Crowd Control batch
        new("Give PS40","give_weaponhideagun") { Category = "Give Weapon" },

        //Ammo
        //new Effect("Give Ammo","giveammo",ItemKind.Folder),

        new("Give 10mm Ammo (Pistols)", "give_ammo10mm") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give 20mm Ammo (Assault Rifle)", "give_ammo20mm") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give 7.62mm Ammo (Assault Rifle)", "give_ammo762mm") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give 30.06mm Ammo (Sniper Rifle)", "give_ammo3006") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give Prod Charger", "give_ammobattery") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give Darts", "give_ammodart") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give Flare Darts", "give_ammodartflare") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give Tranq Darts", "give_ammodartpoison") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give Napalm", "give_ammonapalm") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give Pepper Spray Ammo", "give_ammopepper") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give Plasma", "give_ammoplasma") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give Rockets", "give_ammorocket") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give WP Rockets", "give_ammorocketwp") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give Sabot Shells", "give_ammosabot") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
        new("Give Shotgun Shells", "give_ammoshell") {  Quantity = 100, Category = "Give Ammo" } //New for second Crowd Control batch
    };
}