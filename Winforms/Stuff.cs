using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms
{
    internal class Stuff
    {
    }

    public static class WeaponsDictionaries 
    {
        // SCOUT //

        public static Dictionary<string, string> scoutPrimaryDictionary = new Dictionary<string, string>()
        {
            {"Scattergun, FaN, Back Scatter", "tf_weapon_scattergun.vmt"},
            {"Soda Popper", "tf_weapon_soda_popper.vmt"},
            {"Shortstop", "tf_weapon_handgun_scout_primary.vmt"},
            {"Baby Face's Blaster", "tf_weapon_pep_brawler_blaster.vmt" }
        };

        public static Dictionary<string, string> scoutSecondaryDictionary = new Dictionary<string, string>()
        {
            {"Pistol and reskins", "tf_weapon_pistol_scout.vmt"},
            {"Winger, Pretty Boy's Pocket Pistol", "tf_weapon_handgun_scout_secondary.vmt"},
            {"Flying Guillotine", "tf_weapon_cleaver.vmt"},
            {"Bonk! Atomic Punch, Crit-a-Cola", "tf_weapon_lunchbox_drink.vmt"},
            {"Mad Milk (will also affect Jarate & Gas Passer)", "tf_weapon_jar.vmt" }
        };

        public static Dictionary<string, string> scoutMeleeDictionary = new Dictionary<string, string>()
        {
            {"Bat, Candy Cane, Boston Basher, Sun-on-a-Stick, Fan O'War, Atomizer", "tf_weapon_bat.vmt"},
            {"Holy Mackerel", "tf_weapon_bat_fish.vmt"},
            {"Sandman", "tf_weapon_bat_wood.vmt"},
            {"Wrap Assassin", "tf_weapon_bat_giftwrap.vmt" }
        };

        // SOLDIER //

        public static Dictionary<string, string> soldierPrimaryDictionary = new Dictionary<string, string>()
        {
            {"Rocket Launcher, Black Box, Original, Liberty Launcher, Beggar's Bazooka", "tf_weapon_rocketlauncher.vmt"},
            {"Direct Hit", "tf_weapon_rocketlauncher_directhit.vmt"},
            {"Cow Mangler 5000", "tf_weapon_particle_cannon.vmt"},
            {"Air Strike", "tf_weapon_rocketlauncher_airstrike.vmt" }
        };

        public static Dictionary<string, string> soldierSecondaryDictionary = new Dictionary<string, string>()
        {
            {"Shotgun, Reserve Shooter, Panic Attack", "tf_weapon_shotgun_soldier.vmt"},
            {"Buff Banner, Battalion's Backup, Concheror", "tf_weapon_buff_item.vmt"},
            {"Righteous Bison", "tf_weapon_raygun.vmt"}
        };

        public static Dictionary<string, string> soldierMeleeDictionary = new Dictionary<string, string>()
        {
            {"Shovel, Equalizer, Pain Train, Disciplinary Action, Market Gardener, Escape Plan", "tf_weapon_shovel.vmt"},
            {"Half-Zatoichi", "tf_weapon_katana.vmt"}
        };

        // PYRO //

        public static Dictionary<string, string> pyroPrimaryDictionary = new Dictionary<string, string>()
        {
            {"Flame Thrower and all reskins, Backburner, Degreaser, Phlogistinator", "tf_weapon_flamethrower.vmt"},
            {"Dragon's Fury", "tf_weapon_rocketlauncher_fireball.vmt"}
        };

        public static Dictionary<string, string> pyroSecondaryDictionary = new Dictionary<string, string>()
        {
            {"Shotgun, Reserve Shooter, Panic Attack", "tf_weapon_shotgun_pyro.vmt"},
            {"Flare Gun, Detonator, Scorch Shot", "tf_weapon_flaregun.vmt"},
            {"Manmelter", "tf_weapon_flaregun_revenge.vmt"},
            {"Thermal Thruster", "tf_weapon_rocketpack.vmt" },
            {"Gas Passer (will also affect Mad Milk & Jarate)", "tf_weapon_jar.vmt" }
        };

        public static Dictionary<string, string> pyroMeleeDictionary = new Dictionary<string, string>()
        {
            {"Axe, Lollichop, Axtinguisher, Homewrecker, Powerjack, SV Fragment, Third Degree", "tf_weapon_fireaxe.vmt"},
            {"Neon Annihilator", "tf_weapon_breakable_sign.vmt"},
            {"Hot Hand", "tf_weapon_slap.vmt"}
        };

        // DEMOMAN //

        public static Dictionary<string, string> demomanPrimaryDictionary = new Dictionary<string, string>()
        {
            {"Grenade Launcher, Loch-n-Load, Iron Bomber", "tf_weapon_grenadelauncher.vmt"},
            {"Loose Cannon", "tf_weapon_cannon.vmt"}
        };

        public static Dictionary<string, string> demomanSecondaryDictionary = new Dictionary<string, string>()
        {
            {"Stickybomb Launcher, Scottish Resistance, Sticky Jumper, Quickiebomb Launcher", "tf_weapon_pipebomblauncher.vmt"}
        };

        public static Dictionary<string, string> demomanMeleeDictionary = new Dictionary<string, string>()
        {
            {"Bottle and all reskins", "tf_weapon_bottle.vmt"},
            {"Eyelander, Skullcutter, Claidheamn Mòr, Persian Persuader, Pain Train", "tf_weapon_sword.vmt"},
            {"Ullapool Caber", "tf_weapon_stickbomb.vmt"},
            {"Half-Zatoichi", "tf_weapon_katana.vmt" }
        };

        // HEAVY //

        public static Dictionary<string, string> heavyPrimaryDictionary = new Dictionary<string, string>()
        {
            {"Minigun, Natasha, Brass Beast, Tomislav, Huo-Long Heater", "tf_weapon_minigun.vmt"}
        };

        public static Dictionary<string, string> heavySecondaryDictionary = new Dictionary<string, string>()
        {
            {"Shotgun, Family Business, Panic Attack", "tf_weapon_shotgun_hwg.vmt"},
            {"Sandvich, Dalokohs Bar, Buffalo Steak Sandvich, Second Banana", "tf_weapon_lunchbox.vmt"}
        };

        public static Dictionary<string, string> heavyMeleeDictionary = new Dictionary<string, string>()
        {
            {"Fists, KGB, GoRU, Warrior's Spirit, FoS, Eviction Notice, Holiday Punch", "tf_weapon_fists.vmt"}
        };

        // ENGINEER //

        public static Dictionary<string, string> engineerPrimaryDictionary = new Dictionary<string, string>()
        {
            {"Shotgun, Widowmaker, Panic Attack", "tf_weapon_shotgun_primary.vmt"},
            {"Pomson 6000", "tf_weapon_drg_pomson.vmt"},
            {"Rescue Ranger", "tf_weapon_shotgun_building_rescue.vmt"},
            {"Frontier Justice", "tf_weapon_sentry_revenge.vmt" }
        };

        public static Dictionary<string, string> engineerSecondaryDictionary = new Dictionary<string, string>()
        {
            {"Pistol", "tf_weapon_pistol.vmt"},
            {"Wrangler and reskin", "tf_weapon_laser_pointer.vmt"},
            {"Short Circuit", "tf_weapon_mechanical_arm.vmt"}
        };

        public static Dictionary<string, string> engineerMeleeDictionary = new Dictionary<string, string>()
        {
            {"Wrench, Southern Hospitality, Jag, Eureka Effect", "tf_weapon_wrench.vmt"},
            {"Gunslinger", "tf_weapon_robot_arm.vmt"}
        };

        public static Dictionary<string, string> engineerSpecialDictionary = new Dictionary<string, string>()
        {
            {"Build PDA", "tf_weapon_pda_engineer_build.vmt"},
            {"Destroy PDA", "tf_weapon_pda_engineer_destroy.vmt"},
            {"Placing a building", "tf_weapon_builder.vmt"}
        };

        // MEDIC //

        public static Dictionary<string, string> medicPrimaryDictionary = new Dictionary<string, string>()
        {
            {"Syringe Gun, Blutsauger, Overdose", "tf_weapon_syringegun_medic.vmt"},
            {"Crusader's Crossbow", "tf_weapon_crossbow.vmt"}
        };

        public static Dictionary<string, string> medicSecondaryDictionary = new Dictionary<string, string>()
        {
            {"Medi Gun, Kritzkrieg, Quick-Fix, Vaccinator", "tf_weapon_medigun.vmt"}
        };

        public static Dictionary<string, string> medicMeleeDictionary = new Dictionary<string, string>()
        {
            {"Bonesaw, Ubersaw, Vita-Saw, Amputator, Solemn-Vow", "tf_weapon_bonesaw.vmt"}
        };

        // SNIPER //

        public static Dictionary<string, string> sniperPrimaryDictionary = new Dictionary<string, string>()
        {
            {"Sniper Rifle, Sydney Sleeper, Hitman's Heatmaker, Machina", "tf_weapon_sniperrifle.vmt"},
            {"Huntsman", "tf_weapon_compound_bow.vmt"},
            {"Bazaar Bargain", "tf_weapon_sniperrifle_decap.vmt"},
            {"Classic", "tf_weapon_sniperrifle_classic.vmt" }
        };

        public static Dictionary<string, string> sniperSecondaryDictionary = new Dictionary<string, string>()
        {
            {"SMG", "tf_weapon_smg.vmt"},
            {"Cleaner's Carbine", "tf_weapon_charged_smg.vmt"},
            {"Jarate (will also affect Mad Milk & Gas Passer)", "tf_weapon_jar.vmt"}
        };

        public static Dictionary<string, string> sniperMeleeDictionary = new Dictionary<string, string>()
        {
            {"Kukri, Tribalman's Shiv, Bushwacka, Shahansha", "tf_weapon_club.vmt"}
        };

        // SPY //

        public static Dictionary<string, string> spyPrimaryDictionary = new Dictionary<string, string>()
        {
            {"Revolver, Ambassador, L'Etranger, Enforcer, Diamondback", "tf_weapon_revolver.vmt"}
        };

        public static Dictionary<string, string> spyMeleeDictionary = new Dictionary<string, string>()
        {
            {"Knife, Your Eternal Reward, Conniver's Kunai, Big Earner, Spy-cicle", "tf_weapon_knife.vmt"}
        };

        public static Dictionary<string, string> spySpecialDictionary = new Dictionary<string, string>()
        {
            {"Sapper", "tf_weapon_sapper.vmt"},
            {"Disguise kit", "tf_weapon_pda_spy.vmt"}
        };

    }

    public static class CrosshairLists
    {
        public static List<string> crosshairsLeth = new List<string>()
        {
            "bigcrosshair7",
            "bigcrosshair7OL",
            "brackets",
            "crosshair1",
            "crosshair1OL",
            "crosshair2",
            "crosshair2OL",
            "crosshair3",
            "crosshair3OL",
            "crosshair5",
            "crosshair5circle",
            "crosshair5circleOL",
            "crosshair6",
            "crosshair6circle",
            "crosshair6circleOL",
            "crosshair6OL",
            "crosshair7",
            "crosshair7circle",
            "crosshair7circleOL",
            "crosshair7OL",
            "fatcross",
            "fatcrosscircle",
            "fatcrosscircleOL",
            "mediccross",
            "mediccrossbig",
            "opencross",
            "opencrossOL",
            "quarteredcircle",
            "seeker",
            "seekerOL",
            "smallcrosshair7",
            "smallcrosshair7circle",
            "smallcrosshair7circleOL",
            "smallcrosshair7OL",
            "sniper",
            "sniperbig",
            "sniperbigOL",
            "snipercircle",
            "snipercircleOL",
            "sniperOL",
            "thalashseeker",
            "yzwings"
        };

        public static List<string> crosshairsTobs = new List<string>()
        {
            "tob_rocketcross",
            "tob_wingscross",
            "tob_wingsdot"
        };

        public static List<string> crosshairsXhairshadow = new List<string>()
        {
            "xhairshadowdefault",
            "xhairshadowdots",
            "xhairshadowplus",
            "xhairshadowpluss",
            "xhairshadowrocketsthick"
        };

        public static List<string> crosshairsCPMA = new List<string>()
        {
            "cpma_11",
            "cpma_12",
            "cpma_13",
            "cpma_14",
            "cpma_15",
            "cpma_16",
            "cpma_17",
            "cpma_18",
            "cpma_19"
        };

        public static List<string> crosshairsQuake = new List<string>()
        {
            "ql_1",
            "ql_2",
            "ql_3",
            "ql_4",
            "ql_5",
            "ql_6",
            "ql_7",
            "ql_8",
            "ql_9",
            "ql_10",
            "ql_11",
            "ql_12",
            "ql_13",
            "ql_14",
            "ql_15",
            "ql_16",
            "ql_17",
            "ql_18",
            "ql_19"

        };
    }
}
