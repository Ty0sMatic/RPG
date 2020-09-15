using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {

            World newWorld = new World();

            newWorld.AddLocation(0, 0, "Home", "This is your Home",
                "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(-1, 0, "Herbalists Hut", "Herbs for medicine and potions are everywhere.",
                "/Engine;component/Images/Locations/HerbalistsHut.png");

            newWorld.AddLocation(-1, -1, "Herbalists Garden", "The Herbalists Garden. It smells of all different kinds of herbs.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");

            newWorld.AddLocation(0, -1, "Farmer's House", "The Farmer Edwin if your neighbor. This is where he lives.",
                "/Engine;component/Images/Locations/Farmhouse.png");

            newWorld.AddLocation(0, -2, "Farmers Field", "Wheat is neat. And it's everyhwere!",
                "/Engine;component/Images/Locations/FarmFields.png");

            newWorld.AddLocation(0, 1, "Town Square", "The town was built around a well. This is the center of the city.",
                "/Engine;component/Images/Locations/TownSquare.png");

            newWorld.AddLocation(1, 1, "Townsgate", "Behind it lies a spooky looking forest. A guard sleeps on a chair.",
                "/Engine;component/Images/Locations/TownGate.png");

            newWorld.AddLocation(2, 1, "Dark Forest", "You can barely see. You can also feel spider webs all over the place.",
               "/Engine;component/Images/Locations/SpiderForest.png");

            newWorld.AddLocation(1, 0, "Shop", "Here you could possibly buy potions, armor and weapons. But it's closed...",
               "/Engine;component/Images/Locations/Trader.png");

            return newWorld;
        }

    }
}
