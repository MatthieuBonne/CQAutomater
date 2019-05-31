using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQFollowerAutoclaimer
{
    static class Constants
    {
        public static string ErrorLog = "ErrorLog.txt";
        public static DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        public enum prices
        {
            COMMON = 1,
            RARE = 3,
            LEG = 12,
            ASCEND = -2,
            DEV = 12,
            NONLEVELABLE = -1
        };

        public static string[] rewardNames = new string[] {"20 Disasters(not rewarded in game)", "50 Disasters(not rewarded in game)", "200 Disasters(not rewarded in game)",
            "1H Energy Boost(not rewarded in game)", "4H Energy Boost(not rewarded in game)", "12H Energy Boost(not rewarded in game)",
            "Common Followers", "Rare Followers", "Legendary Followers", "20 UM", "50 UM", "200 UM",
        };

        public static string[] names = {
            "awanderer", "minerva", "helga", "ophelia", "agatha", "anerissa",
			"mother", "murphy", "bortles", "thumper", "daisy", "gizmo", "willow", "adybbuk", "aedana", "ajade", "amahatma",
            "spike", "riptide", "ember", "cloud", "b-day", "thewanderer", "maunder", "transient", "cupid", "aurora", "orin", "flint", "blossom",
            "aseethe", "seethe", "ruin", "raze", "kedari", "5-12-6", "fir", "frosty", "maraudermagnus", "corsaircharles", "buccaneerbeatrice", "raiderrose",
            "adefile", "guy", "cliodhna", "sanqueen", "billy", "doyenne", "ahattori", "ahirate", "atakeda", "ahosokawa",
            "aneptunius", "alordkirk", "athert", "ashygu", "dybbuk", "edana", "jade", "mahatma", "neil", "defile", "putrid", "taint",
            "pokerface", "luxurious", "dicemaster", "kryton", "hidoka", "liucheng", "kumu-san", "masterlee", "hawking", "abavah",
            "flynn", "leaf", "sparks", "leprechaun", "bavah", "boor", "bylar", "adagda", "hattori", "hirate", "takeda", "hosokawa", "moak", "arigr", "dorth",
            "rua", "arshen", "aatzar", "apontus", "bubbles", "dagda", "ganah", "toth", "sexysanta", "santaclaus", "reindeer", "christmaself", "lordofchaos", "ageror",
            "ageum", "atr0n1x", "aauri", "arei", "aathos", "aalpha", "rigr", "hallinskidi", "hama", "alvitr", "koldis", "sigrun", "neptunius", "lordkirk", "thert", "shygu",
            "ladyodelith", "dullahan", "jackoknight", "werewolf", "gurth", "koth", "zeth", "atzar", "xarth", "oymos", "gaiabyte", "aoyuki", "spyke", "zaytus", "petry",
            "chroma", "pontus", "erebus", "ourea", "groth", "brynhildr", "veildur", "geror", "aural", "rudean", "undine", "ignitor", "forestdruid", "geum", "aeris",
            "aquortis", "tronix", "taurus", "kairy", "james", "nicte", "auri", "faefyr", "ailen", "rei", "geron", "jet", "athos", "nimue", "carl", "alpha", "shaman",
            "hunter", "bewat", "pyromancer", "rokka", "valor", "nebra", "tiny", "ladyoftwilight", "",
            "A1", "E1", "F1", "W1", "A2", "E2", "F2", "W2", "A3", "E3", "F3", "W3", "A4", "E4", "F4", "W4", "A5", "E5", "F5", "W5", "A6", "E6", "F6", "W6",
            "A7", "E7", "F7", "W7", "A8", "E8", "F8", "W8", "A9", "E9", "F9", "W9", "A10", "E10", "F10", "W10", "A11", "E11", "F11", "W11", "A12", "E12", "F12", "W12",
            "A13", "E13", "F13", "W13", "A14", "E14", "F14", "W14", "A15", "E15", "F15", "W15", "A16", "E16", "F16", "W16", "A17", "E17", "F17", "W17", "A18", "E18", "F18", "W18",
            "A19", "E19", "F19", "W19", "A20", "E20", "F20", "W20", "A21", "E21", "F21", "W21", "A22", "E22", "F22", "W22", "A23", "E23", "F23", "W23", "A24", "E24", "F24", "W24",
            "A25" ,"E25", "F25", "W25", "A26", "E26", "F26", "W26", "A27", "E27", "F27", "W27", "A28", "E28", "F28", "W28", "A29", "E29", "F29", "W29", "A30", "E30", "F30", "W30",
			"A31", "E31", "F31", "W31", "A32", "E32", "F32", "W32", "A33", "E33", "F33", "W33", "A34", "E34", "F34", "W34", "A35", "E35", "F35", "W35", "A36", "E36", "F36", "W36",
			"A37", "E37", "F37", "W37", "A38", "E38", "F38", "W38", "A39", "E39", "F39", "W39", "A40", "E40", "F40", "W40", "A41", "E41", "F41", "W41", "A42", "E42", "F42", "W42",
			"A43", "E43", "F43", "W43", "A44", "E44", "F44", "W44", "A45", "E45", "F45", "W45", 
        };

        public static int heroesInGame = Array.IndexOf(names, "ladyoftwilight") + 2;
        public static string[] heroNames = new string[] { "NULL", "NULL", "Ladyoftwilight", "Tiny", "Nebra", "Valor", "Rokka", "Pyromancer", "Bewat",
            "Hunter", "Shaman", "Alpha", "Carl", "Nimue", "Athos", "Jet", "Geron", "Rei", "Ailen", "Faefyr", "Auri", "Nicte", "James", "Kairy", "Taurus", "Tronix",
            "Aquortis", "Aeris", "Geum", "Forestdruid", "Ignitor", "Undine", "Rudean", "Aural", "Geror", "Veildur", "Brynhildr", "Groth", "Ourea", "Erebus", "Pontus",
            "Chroma", "Petry", "Zaytus", "Spyke", "Aoyuki", "Gaiabyte", "Oymos", "Xarth", "Atzar", "Zeth", "Koth", "Gurth", "Werewolf", "Jackoknight", "Dullahan",
            "Ladyodelith", "Shygu", "Thert", "Lordkirk", "Neptunius", "Sigrun", "Koldis", "Alvitr", "Hama", "Hallinskidi", "Rigr", "Aalpha", "Aathos", "Arei", "Aauri",
            "Atr0n1x", "Ageum", "Ageror", "Lordofchaos", "Christmaself", "Reindeer", "Santaclaus", "Sexysanta", "Toth", "Ganah", "Dagda", "Bubbles", "Apontus", "Aatzar",
            "Arshen", "Rua", "Dorth", "Arigr", "Moak", "Hosokawa", "Takeda", "Hirate", "Hattori", "Adagda", "Bylar", "Boor", "Bavah", "Leprechaun", "Sparks", "Leaf", "Flynn",
            "Abavah", "Hawking", "MasterLee", "Kumu-San", "LiuCheng", "Hidoka", "Kryton", "Dicemaster", "Luxurious", "Pokerface", "Taint", "Putrid", "Defile", "Neil",
            "Mahatma", "Jade", "Edana", "Dybbuk", "Ashygu", "Athert", "Alordkirk", "Aneptunius", "Ahosokawa", "Atakeda", "Ahirate", "Ahattori", "Doyenne",
            "Billy", "Sanqueen", "Cliodhna", "Guy", "Adefile", "Raiderrose", "Buccaneerbeatrice", "Corsaircharles","Maraudermagnus", "Frosty", "Fir", "5-12-6", "Kedari",
            "Raze", "Ruin", "Seethe", "Aseethe", "Blossom", "Flint", "Orin", "Aurora", "Cupid", "Transient", "Maunder", "Thewanderer", "B-day", "Cloud", "Ember", "Riptide", "Spike", 
            "Amahatma", "Ajade", "Aedana", "Adybbuk", "Willow", "Gizmo", "Daisy", "Thumper", "Bortles", "Murphy", "Nerissa", "Mother", "Anerissa", "Agatha", "Ophelia",
			"Helga", "Minerva", "Awanderer",
        };

        public static prices[] heroPrices = new prices[] {
            prices.NONLEVELABLE, prices.NONLEVELABLE, prices.COMMON, prices.RARE, prices.LEG, prices.COMMON, prices.COMMON, prices.COMMON, prices.COMMON,
            prices.COMMON, prices.RARE, prices.LEG, prices.COMMON, prices.RARE, prices.LEG, prices.COMMON, prices.RARE, prices.LEG, prices.COMMON, prices.RARE, prices.LEG,
            prices.RARE, prices.LEG, prices.COMMON, prices.RARE, prices.LEG, prices.COMMON, prices.RARE, prices.LEG, prices.RARE, prices.RARE, prices.RARE,
            prices.COMMON, prices.RARE, prices.LEG, prices.LEG, prices.LEG, prices.LEG, prices.COMMON, prices.RARE, prices.LEG, prices.RARE, prices.RARE, prices.RARE,
            prices.DEV, prices.DEV, prices.DEV, prices.COMMON, prices.RARE, prices.LEG, prices.LEG, prices.LEG, prices.LEG, prices.COMMON, prices.RARE, prices.LEG, //dulla
            prices.RARE, prices.LEG, prices.LEG, prices.LEG, prices.LEG, prices.LEG, prices.LEG, prices.LEG, prices.COMMON, prices.RARE, prices.LEG,
            prices.ASCEND, prices.ASCEND, prices.ASCEND, prices.ASCEND, prices.ASCEND, prices.ASCEND, prices.ASCEND, prices.NONLEVELABLE,
            prices.NONLEVELABLE, prices.NONLEVELABLE, prices.NONLEVELABLE, prices.RARE, prices.COMMON, prices.RARE, prices.LEG, prices.ASCEND, //bubbles
            prices.ASCEND, prices.ASCEND, prices.LEG, prices.LEG, prices.LEG, prices.ASCEND, prices.NONLEVELABLE,  prices.LEG, prices.LEG, prices.LEG, prices.LEG,
            prices.ASCEND, prices.COMMON, prices.RARE, prices.LEG, prices.LEG, prices.NONLEVELABLE, prices.NONLEVELABLE, prices.NONLEVELABLE,
            prices.ASCEND, prices.LEG, prices.ASCEND, prices.LEG, prices.LEG, prices.LEG, prices.NONLEVELABLE,
            prices.COMMON, prices.RARE, prices.LEG, prices.COMMON, prices.RARE, prices.LEG, prices.LEG, //neil
            prices.LEG, prices.LEG, prices.LEG, prices.LEG, prices.ASCEND, prices.ASCEND, prices.ASCEND, prices.ASCEND, //Quest Heroes 21-28
            prices.ASCEND, prices.ASCEND, prices.ASCEND, prices.ASCEND, prices.NONLEVELABLE,//Quest Heroes 29-32 + Doy
            prices.COMMON, prices.RARE, prices.LEG, prices.ASCEND, prices.ASCEND, //billy-adefile
            prices.ASCEND, prices.LEG, prices.LEG, prices.LEG, prices.RARE, prices.NONLEVELABLE, prices.NONLEVELABLE, prices.NONLEVELABLE, //rose-kedari
            prices.COMMON, prices.RARE, prices.LEG, prices.ASCEND, //raze-Aseethe
            prices.LEG, prices.LEG, prices.LEG, prices.ASCEND, prices.LEG, //Season 7 Heroes + Valentines LTO
            prices.COMMON, prices.RARE, prices.LEG, // Drifter Heroes
            prices.LEG, prices.NONLEVELABLE, prices.NONLEVELABLE, prices.NONLEVELABLE, prices.NONLEVELABLE, //Anniversary + Dragon Heroes
            prices.ASCEND, prices.ASCEND, prices.ASCEND, prices.ASCEND, //AQuest Djinn Heroes
            prices.COMMON, prices.RARE, prices.LEG, prices.ASCEND, // Easter2019 Heroes
            prices.COMMON, prices.RARE, prices.LEG, // Aquatic Heroes
            prices.LEG, // Mother

        };

        public static string[] pranaHeroes = new string[] {
            "Ladyoftwilight", "Tiny", "Nebra", "Hunter", "Shaman", "Alpha", "Nimue", "Athos", "Jet", "Geron", "Rei", "Ailen", "Faefyr", "Auri", "James",
            "Kairy", "Taurus", "Tronix", "Aquortis", "Aeris", "Geum", "Rudean", "Aural", "Geror", "Veildur", "Brynhildr", "Groth", "Ourea", "Erebus", "Pontus",
            "Oymos", "Xarth", "Atzar", "Zeth", "Koth", "Gurth", "Sigrun", "Koldis", "Alvitr", "Hama", "Hallinskidi", "Rigr", "Sexysanta", "Toth", "Ganah", "Dagda",
            "Arshen", "Rua", "Dorth", "Bylar", "Boor", "Bavah", "Hawking", "Kumu-San", "LiuCheng", "Hidoka", "Spyke", "Aoyuki", "Gaiabyte",
            "Dicemaster", "Luxurious", "Pokerface", "Taint", "Putrid", "Defile", "Mahatma", "Jade", "Edana", "Dybbuk", "Billy", "Sanqueen", "Cliodhna",
            "Buccaneerbeatrice", "Corsaircharles", "Maraudermagnus", "Frosty", "Raze", "Ruin", "Seethe", "Blossom", "Flint", "Orin", "Cupid", "Transient", "Maunder", "Thewanderer", "B-Day",
            "Willow", "Gizmo", "Daisy", "Bortles", "Murphy", "Nerissa", "Mother", "Agatha", "Ophelia", "Helga",
        };

        public static string[] cosmicCoinHeroes = new string[] {
            "Valor", "Rokka", "Pyromancer", "Bewat", "Nicte", "Forestdruid", "Ignitor", "Undine", "Chroma", "Petry", "Zaytus", "Ladyodelith",
            "Shygu", "Thert", "Lordkirk", "Neptunius", "Werewolf", "Jackoknight", "Dullahan", "Leprechaun", "Hosokawa", "Takeda", "Hirate", "Hattori",
            "Neil", "Mahatma", "Jade", "Edana", "Dybbuk", "Ashygu", "Athert", "Alordkirk", "Aneptunius", "Ahosokawa", "Atakeda", "Ahirate", "Ahattori",
            "Billy", "Sanqueen", "Cliodhna", "Cupid", "B-Day", "Amahatma", "Ajade", "Aedana", "Adybbuk",
            "Willow", "Gizmo", "Daisy", "Thumper", "Bortles", "Murphy", "Nerissa", "Mother",
        };

        public static string[] ascensionHeroes = new string[] {
            "Aalpha", "Aathos", "Arei", "Aauri", "Atr0n1x", "Ageum", "Ageror", "Bubbles", "Apontus", "Aatzar", "Arigr", "Adagda", "Abavah", "MasterLee",
            "Ashygu", "Athert", "Alordkirk", "Aneptunius", "Ahosokawa", "Atakeda", "Ahirate", "Ahattori", "Guy", "Adefile", "Raiderrose", "Aseethe", "Aurora",
			"Thumper", "Anerissa", "Minerva", "Awanderer","Convert to Prana", 
        };

        public static Dictionary<int, string> ERROR = new Dictionary<int, string>()
        {
            {800, "Can't use chest"},
            {801, "Failed to open. Retrying"},
        };
    }
}
