using MelonLoader;
using BoneLib;
using UnityEngine;
using Il2CppSteamworks.Data;

namespace RandomPowerEveryLevelLoad.Powers
{
    public class Randomize : MelonMod
    {
        // Bools bools bools bruh
        public static bool dblJumpChosen = false;
        public static bool immortalChosen = false;
        public static bool moonChosen = false;

        static System.Random powerBall = new System.Random();

        public static void TheChosening()
        {
            int chosen = powerBall.Next(3);

            dblJumpChosen = immortalChosen = moonChosen = false;

            switch (chosen)
            {
                case 0: dblJumpChosen = true; break;
                case 1: immortalChosen = true; break;
                case 2: moonChosen = true; break;
            }
        }

    }
}
