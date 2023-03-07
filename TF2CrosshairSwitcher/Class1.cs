using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2CrosshairSwitcher
{
    class Class1
    {
    }

    public class WeaponList // This might actually have to be a collection of dictionaries
        // because I might need to put the file location as a value, with the key being the name
        // or I could rename them to fit the files I am going to make
    {
        public string folderLocation = @"C:\SteamLibrary\steamapps\common\Team Fortress 2\tf\custom\crosshairs\materials\vgui\replay\thumbnails";

        public List<string> scoutPrimary = new List<string>() 
        {
            "scattergun",
            "sodapopper",
            "shortstop",
            "babyfacesblaster"
        };

        public List<string> scoutSecondary = new List<string>()
        {
            "pistolscout",
            "winger",
            "flyingguillotine",
            "bonkcola",
            "madmilkjarategaspasser"
        };

        public List<string> scoutMelee = new List<string>()
        {
            "bat",
            "holymackerel",
            "sandman",
            "wrapassassin"
        };

        public List<string> soldierPrimary = new List<string>()
        {
            "rocketlauncher",
            "directhit",
            "cowmangler",
            "airstrike"
        };

        public List<string> soldierSecondary = new List<string>()
        {
            "shotgunsoldier",
            "banner",
            "bison"
        };

        public List<string> soldierMelee = new List<string>()
        {
            "shovel",
            "zatoichi"
        };

        public List<string> pyroPrimary = new List<string>()
        {
            "flamethrower",
            "dragonsfury"
        };

        public List<string> pyroSecondary = new List<string>()
        {
            "shotgunpyro",
            "flaregun",
            "manmelter",
            "thermalthruster",
            "madmilkjarategaspasser"
        };

        public List<string> pyroMelee = new List<string>()
        {
            "fireaxe",
            "neon",
            "hothand"
        };

        public List<string> demomanPrimary = new List<string>()
        {
            "grenadelauncher",
            "loosecannon"
        };

        public List<string> demomanSecondary = new List<string>()
        {
            "stickybomb"
        };

        public List<string> demomanMelee = new List<string>()
        {
            "bottle",
            "eyelander",
            "caber",
            "zatoichi"
        };

        public List<string> heavyPrimary = new List<string>()
        {
            "minigun"
        };

        public List<string> heavySecondary = new List<string>()
        {
            "shotgunheavy",
            "sandvich"
        };

        public List<string> heavyMelee = new List<string>()
        {
            "fists"
        };

        public List<string> engineerPrimary = new List<string>()
        {
            "shotgunengineer",
            "pomson",
            "rescueranger",
            "frontierjustice"
        };

        public List<string> engineerSecondary = new List<string>()
        {
            "pistolengineer",
            "wrangler",
            "shortcircuit"
        };

        public List<string> engineerMelee = new List<string>()
        {
            "wrench",
            "gunslinger"
        };

        public List<string> engineerSpecial = new List<string>()
        {
            "buildpda",
            "destroypda",
            "placebuilding"
        };

        public List<string> medicPrimary = new List<string>()
        {
            "syringegun",
            "crossbow"
        };

        public List<string> medicSecondary = new List<string>()
        {
            "medigun"
        };

        public List<string> medicMelee = new List<string>()
        {
            "bonesaw"
        };

        public List<string> sniperPrimary = new List<string>()
        {
            "sniperrifle",
            "huntsman",
            "bazaar",
            "classic"
        };

        public List<string> sniperSecondary = new List<string>()
        {
            "smg",
            "cleanerscarbine",
            "madmilkjarategaspasser"
        };

        public List<string> sniperMelee = new List<string>()
        {
            "kukri"
        };

        public List<string> spyPrimary = new List<string>()
        {
            "revolver"
        };

        public List<string> spyMelee = new List<string>()
        {
            "knife"
        };

        public List<string> spySpecial = new List<string>()
        {
            "sapper",
        };

        public List<string> spySpecialX = new List<string>()
        {
            "disguisekit",
        };

    }


    public class Weapon // Maybe get rid of this because I don't think I'll be using it in the future
    {
        private string _classname;
        private string _slotname;
        private string _itemname;

        public string ClassName
        {
            get => _classname;
            set 
            {
                switch (value.ToLower())
                {
                    case ("scout"):
                        _classname = "scout";
                        break;
                    case ("soldier"):
                        _classname = "soldier";
                        break;
                    case ("pyro"):
                        _classname = "pyro";
                        break;
                    case ("demoman"):
                        _classname = "demoman";
                        break;
                    case ("heavy"):
                        _classname = "heavy";
                        break;
                    case ("engineer"):
                        _classname = "engineer";
                        break;
                    case ("medic"):
                        _classname = "medic";
                        break;
                    case ("sniper"):
                        _classname = "sniper";
                        break;
                    case ("spy"):
                        _classname = "spy";
                        break;
                    default:
                        _classname = null;
                        break;
                }
            }
        } // _classname get/set
        public string SlotName
        {
            get => _slotname;
            set
            {
                switch (value.ToLower())
                {
                    case ("primary"):
                        _slotname = "primary";
                        break;
                    case ("secondary"):
                        _slotname = "secondary";
                        break;
                    case ("melee"):
                        _slotname = "melee";
                        break;
                    default:
                        _slotname = null;
                        break;
                }
            }
        } // _slotname get/set
        public string ItemName
        {
            get => _itemname;
            set
            {
                switch (value.ToLower())
                {
                    case ("primary"):
                        _itemname = "primary";
                        break;
                    case ("secondary"):
                        _itemname = "secondary";
                        break;
                    case ("melee"):
                        _itemname = "melee";
                        break;
                    default:
                        _itemname = null;
                        break;
                }
            }
        } // _slotname get/set


        public Weapon(string aClassName, string aSlotName)
        {
            ClassName = aClassName;
            SlotName = aSlotName;
        } // Constructor
    }
}
