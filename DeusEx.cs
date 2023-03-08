using System;
using CrowdControl.Common;
using JetBrains.Annotations;
using ConnectorType = CrowdControl.Common.ConnectorType;

namespace CrowdControl.Games.Packs
{
    [UsedImplicitly]
    public class DeusEx : SimpleTCPPack
    {
        public override string Host => "0.0.0.0";

        public override ushort Port => 43384;

        public DeusEx(Player player, Func<CrowdControlBlock, bool> responseHandler, Action<object> statusUpdateHandler) : base(player, responseHandler, statusUpdateHandler) { }

        public override Game Game { get; } = new(90, "Deus Ex Randomizer", "DeusEx", "PC", ConnectorType.SimpleTCPConnector);

        public override EffectList Effects { get; } = new Effect[]
        {
            //General Effects
            new Effect("Trigger the Killswitch", "kill"),
            new Effect("Poison the Player", "poison"),
            new Effect("Glass Legs", "glass_legs"),
            new Effect("Give Health (x10)", "give_health") { Quantity = 100 },
            new Effect("Set On Fire", "set_fire"),
            new Effect("Full Heal", "full_heal"),
            new Effect("Drunk Mode (1 minute)", "drunk_mode"),
            new Effect("Drop Selected Item", "drop_selected_item"),
            new Effect("Enable Matrix Mode (1 Minute)", "matrix"),
            new Effect("Give Player EMP Field (15 seconds)", "emp_field"),
            new Effect("Give Bioelectric Energy (x10)", "give_energy") { Quantity = 100 },
            new Effect("Give Skill Points (x100)", "give_skillpoints") { Quantity = 1000 }, //Updated text for second Crowd Control batch
            new Effect("Remove Skill  Points (x100)", "remove_skillpoints") { Quantity = 1000 }, //Updated text for second Crowd Control batch
            new Effect("Disable Jump (1 minute)", "disable_jump"),
            new Effect("Gotta Go Fast (1 minute)", "gotta_go_fast"),
            new Effect("Slow Like Snail (1 minute)", "gotta_go_slow"),
            new Effect("Ice Physics! (1 minute)","ice_physics"),
            new Effect("Go Third-Person (1 minute)","third_person"),
            new Effect("Take Double Damage (1 minute)","dmg_double"),
            new Effect("Take Half Damage (1 minute)","dmg_half"),
            new Effect("Give Credits (x100)", "add_credits") { Quantity = 1000 }, //Updated for text second Crowd Control batch
            new Effect("Remove Credits (x100)", "remove_credits") { Quantity = 1000 }, //Updated text for second Crowd Control batch
            new Effect("Upgrade a Flamethrower to a LAMThrower (1 minute)", "lamthrower"),

            new Effect ("Ask a Question","ask_a_question"), //New for second Crowd Control batch
            new Effect ("Nudge","nudge"), //New for second Crowd Control batch
            new Effect ("Swap Player with another human","swap_player_position"), //New for second Crowd Control batch
            new Effect ("Float Away","floaty_physics"), //New for second Crowd Control batch
            new Effect ("Floor is Lava","floor_is_lava"), //New for second Crowd Control batch
            new Effect ("Invert Mouse Controls","invert_mouse"), //New for second Crowd Control batch
            new Effect ("Invert Movement Controls","invert_movement"), //New for second Crowd Control batch
            new Effect ("Earthquake","earthquake"), //New for fourth Crowd Control batch
            new Effect ("Full Bioelectric Energy","give_full_energy"), //New for fourth Crowd Control batch
            new Effect ("Trigger all alarms","trigger_alarms"), //New for fourth Crowd Control batch
            new Effect ("Flip camera upside down","flipped"), //New for fourth Crowd Control batch
            new Effect ("Flip camera sideways","limp_neck"), //New for fourth Crowd Control batch
            new Effect ("Do a barrel roll!","barrel_roll"), //New for fourth Crowd Control batch
            new Effect ("Set off a Flashbang", "flashbang"), //New for fourth Crowd Control batch
            new Effect ("Eat Beans", "eat_beans"), //New for fourth Crowd Control batch
            new Effect ("Fire the current weapon", "fire_weapon"), //New for fourth Crowd Control batch
            new Effect ("Switch to next item", "next_item"), //New for fourth Crowd Control batch
            new Effect ("Switch to next HUD color scheme", "next_hud_color"), //New for fourth Crowd Control batch
            new Effect ("Quick Save", "quick_save"), //New for fourth Crowd Control batch
            new Effect ("Quick Load", "quick_load"), //New for fourth Crowd Control batch

            //Spawn Enemies/Allies
            //new Effect("Spawn Enemies/Allies","spawnpawns",ItemKind.Folder), //New for fourth Crowd Control batch
            new Effect ("Spawn Medical Bot", "spawnfriendly_medicalbot") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
            new Effect ("Spawn Repair Bot", "spawnfriendly_repairbot") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
            new Effect ("Spawn hostile Spider Bot", "spawnenemy_spiderbot2") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
            new Effect ("Spawn hostile MJ12 Commando", "spawnenemy_mj12commando") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
            new Effect ("Spawn hostile Security Bot", "spawnenemy_securitybot4") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
            new Effect ("Spawn friendly Security Bot", "spawnfriendly_securitybot4") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
            new Effect ("Spawn hostile Military Bot", "spawnenemy_militarybot") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
            new Effect ("Spawn friendly Military Bot", "spawnfriendly_militarybot") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
            new Effect ("Spawn hostile Doberman", "spawnenemy_doberman") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch
            new Effect ("Spawn hostile Greasel", "spawnenemy_greasel") { Category = "Spawn Enemies/Allies" }, //New for fourth Crowd Control batch

            //Items
            //new Effect("Give Items","giveitems",ItemKind.Folder), //New folder for third batch
            new Effect("Give a Medkit", "give_medkit") { Category = "Give Items" }, //Moved into new folder for third batch
            new Effect("Give a Biocell", "give_bioelectriccell") { Category = "Give Items" }, //Moved into new folder for third batch
            new Effect("Give a Fire Extinguisher", "give_fireextinguisher") { Category = "Give Items" }, //New for third Crowd Control batch
            new Effect("Give a Ballistic Armor", "give_ballisticarmor") { Category = "Give Items" }, //New for third Crowd Control batch
            new Effect("Give a Lockpick", "give_lockpick") { Category = "Give Items" }, //New for third Crowd Control batch
            new Effect("Give a Multitool", "give_multitool") { Category = "Give Items" }, //New for third Crowd Control batch
            new Effect("Give a Rebreather", "give_rebreather") { Category = "Give Items" }, //New for third Crowd Control batch
            new Effect("Give a Thermoptic Camo", "give_adaptivearmor") { Category = "Give Items" }, //New for third Crowd Control batch
            new Effect("Give a HazMat Suit", "give_hazmatsuit") { Category = "Give Items" }, //New for third Crowd Control batch
            new Effect("Give a bottle of Wine", "give_winebottle") { Category = "Give Items" }, //New for Fourth Crowd Control batch
            new Effect("Give a set of Tech Goggles", "give_techgoggles") { Category = "Give Items" }, //New for Fourth Crowd Control batch

            //Add/Remove Augs
            //new Effect("Add/Upgrade Augmentations","addaugs",ItemKind.Folder),
            //new Effect("Remove/Downgrade Augmentations","remaugs",ItemKind.Folder),

            new Effect("Add/Upgrade Aqualung", "add_augaqualung") { Category = "Augmentations" },
            new Effect("Add/Upgrade Ballistic Protection", "add_augballistic") { Category = "Augmentations" },
            new Effect("Add/Upgrade Cloak", "add_augcloak") { Category = "Augmentations" },
            new Effect("Add/Upgrade Combat Strength", "add_augcombat") { Category = "Augmentations" },
            new Effect("Add/Upgrade Aggressive Defense System", "add_augdefense") { Category = "Augmentations" },
            new Effect("Add/Upgrade Spy Drone", "add_augdrone") { Category = "Augmentations" },
            new Effect("Add/Upgrade EMP Shield", "add_augemp") { Category = "Augmentations" },
            new Effect("Add/Upgrade Environmental Resistance", "add_augenviro") { Category = "Augmentations" },
            new Effect("Add/Upgrade Regeneration", "add_aughealing") { Category = "Augmentations" },
            new Effect("Add/Upgrade Synthetic Heart", "add_augheartlung") { Category = "Augmentations" },
            new Effect("Add/Upgrade Microfibral Muscle", "add_augmuscle") { Category = "Augmentations" },
            new Effect("Add/Upgrade Power Recirculator", "add_augpower") { Category = "Augmentations" },
            new Effect("Add/Upgrade Radar Transparancy", "add_augradartrans") { Category = "Augmentations" },
            new Effect("Add/Upgrade Energy Shield", "add_augshield") { Category = "Augmentations" },
            new Effect("Add/Upgrade Speed Enhancement", "add_augspeed") { Category = "Augmentations" },
            new Effect("Add/Upgrade Run Silent", "add_augstealth") { Category = "Augmentations" },
            new Effect("Add/Upgrade Targeting", "add_augtarget") { Category = "Augmentations" },
            new Effect("Add/Upgrade Vision Enhancement", "add_augvision") { Category = "Augmentations" },

            new Effect("Remove/Downgrade Aqualung", "rem_augaqualung") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Ballistic Protection", "rem_augballistic") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Cloak", "rem_augcloak") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Combat Strength", "rem_augcombat") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Aggressive Defense System", "rem_augdefense") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Spy Drone", "rem_augdrone") { Category = "Augmentations" },
            new Effect("Remove/Downgrade EMP Shield", "rem_augemp") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Environmental Resistance", "rem_augenviro") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Regeneration", "rem_aughealing") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Synthetic Heart", "rem_augheartlung") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Microfibral Muscle", "rem_augmuscle") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Power Recirculator", "rem_augpower") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Radar Transparancy", "rem_augradartrans") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Energy Shield", "rem_augshield") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Speed Enhancement", "rem_augspeed") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Run Silent", "rem_augstealth") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Targeting", "rem_augtarget") { Category = "Augmentations" },
            new Effect("Remove/Downgrade Vision Enhancement", "rem_augvision") { Category = "Augmentations" },


            //Drop Grenades
            //new Effect("Drop a live grenade","dropgrenade",ItemKind.Folder),

            new Effect("Drop a Live LAM", "drop_lam") { Category = "Drop Live Grenade" },
            new Effect("Drop a Live EMP Grenade", "drop_empgrenade") { Category = "Drop Live Grenade" },
            new Effect("Drop a Live Gas Grenade", "drop_gasgrenade") { Category = "Drop Live Grenade" },
            new Effect("Drop a Live Scrambler Grenade", "drop_nanovirusgrenade") { Category = "Drop Live Grenade" },


            //Weapons
            //new Effect("Give Weapons","giveweapon",ItemKind.Folder),

            new Effect("Give Flamethrower", "give_weaponflamethrower") { Category = "Give Weapon" },
            new Effect("Give GEP Gun", "give_weapongepgun") { Category = "Give Weapon" },
            new Effect("Give Dragon Tooth Sword", "give_weaponnanosword") { Category = "Give Weapon" },
            new Effect("Give Plasma Rifle", "give_weaponplasmarifle") { Category = "Give Weapon" },
            new Effect("Give LAW", "give_weaponlaw") { Category = "Give Weapon" },
            new Effect("Give Sniper Rifle", "give_weaponrifle") { Category = "Give Weapon" },
            new Effect("Give Assault Rifle", "give_weaponassaultgun") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Assault Shotgun", "give_weaponassaultshotgun") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Baton", "give_weaponbaton") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Combat Knife", "give_weaponcombatknife") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Crowbar", "give_weaponcrowbar") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Mini Crossbow", "give_weaponminicrossbow") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Pepper Spray", "give_weaponpeppergun") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Pistol", "give_weaponpistol") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Stealth Pistol", "give_weaponstealthpistol") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Riot Prod", "give_weaponprod") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Sawed-off Shotgun", "give_weaponsawedoffshotgun") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Throwing Knives", "give_weaponshuriken") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Sword", "give_weaponsword") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give LAM", "give_weaponlam") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give EMP Grenade", "give_weaponempgrenade") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Gas Grenade", "give_weapongasgrenade") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give Scrambler Grenade", "give_weaponnanovirusgrenade") { Category = "Give Weapon" },  //New for second Crowd Control batch
            new Effect("Give PS40","give_weaponhideagun") { Category = "Give Weapon" },

            //Ammo
            //new Effect("Give Ammo","giveammo",ItemKind.Folder),

            new Effect("Give 10mm Ammo (Pistols)", "give_ammo10mm") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give 20mm Ammo (Assault Rifle)", "give_ammo20mm") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give 7.62mm Ammo (Assault Rifle)", "give_ammo762mm") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give 30.06mm Ammo (Sniper Rifle)", "give_ammo3006") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give Prod Charger", "give_ammobattery") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give Darts", "give_ammodart") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give Flare Darts", "give_ammodartflare") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give Tranq Darts", "give_ammodartpoison") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give Napalm", "give_ammonapalm") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give Pepper Spray Ammo", "give_ammopepper") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give Plasma", "give_ammoplasma") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give Rockets", "give_ammorocket") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give WP Rockets", "give_ammorocketwp") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give Sabot Shells", "give_ammosabot") {  Quantity = 100, Category = "Give Ammo" }, //New for second Crowd Control batch
            new Effect("Give Shotgun Shells", "give_ammoshell") {  Quantity = 100, Category = "Give Ammo" } //New for second Crowd Control batch
        };
    }
}
