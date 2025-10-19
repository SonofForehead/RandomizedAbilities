using MelonLoader;
using BoneLib;
using BoneLib.BoneMenu;
using UnityEngine;

[assembly: MelonInfo(typeof(RandomPowerEveryLevelLoad.Core), "RandomPowerEveryLevelLoad", "1.0.0", "SonofForehead", null)]
[assembly: MelonGame("Stress Level Zero", "BONELAB")]

namespace RandomPowerEveryLevelLoad
{
    public class Core : MelonMod
    {
        public static bool toggleMod;
        public static void ModToggle(bool toggle) { toggleMod = toggle;
            if (toggleMod) { MelonLogger.Msg("Mod Enabled"); }
            else { MelonLogger.Msg("Mod Disabled"); } }

        // Shitty toggles for bone menu
        public static bool toggleDblJump;
        public static void DblJumpToggle(bool toggle) { toggleDblJump = toggle; }
        public static bool toggleImmortal;
        public static void ImmortalToggle(bool toggle) { toggleImmortal = toggle; }
        public static bool toggleMoon;
        public static void MoonToggle(bool toggle) { toggleMoon = toggle; }

        public override void OnInitializeMelon()
        {
            CreateBonemenu();
        }

        public static void CreateBonemenu()
        {
            // Root
            Page mainPage = Page.Root.CreatePage("RandomizedAbilities", Color.cyan);

            // Root/MainPage
            mainPage.CreateBool("Mod Toggle", Color.white, true, ModToggle);
            Page powersPage = mainPage.CreatePage("Powers", Color.blue);
            Page cursedPowersPage = mainPage.CreatePage("Cursed Powers", Color.red);

            // Root/MainPage/Powers

            Page dblJumpPage = powersPage.CreatePage("Double Jump", Color.white);
            // Root/MainPage/Powers/DoubleJump
            dblJumpPage.CreateBool("Toggle", Color.white, true,DblJumpToggle);

            Page immortalPage = powersPage.CreatePage("Immortality", Color.white);
            //Root/MainPage/Powers/Immortality
            immortalPage.CreateBool("Toggle", Color.white, true, ImmortalToggle);

            Page moonPage = powersPage.CreatePage("Moon Gravity", Color.white);
            //Root/MainPage/Powers/MoonGravity
            moonPage.CreateBool("Toggle", Color.white, true, MoonToggle);
        }
    }
}

// Number of powers/per load
// Disable/Enable each of these

// Powers:
    // -Double Jump
    // -10x Punch Force (_strengthUpper + _strengthGrip)
    // -5x Speed (_Speed)
    // -2x Jump force (_strengthLower)
    // -Moon Gravity
    // -Immortal
    // -Highlight Enemies (Just a dot or something)
    // -Infinite Ammo

// Cursed Powers:
    // -Instant Death
    // -Flipped Inputs
    // -Ragdolled Arms at random
    // -Ragdolled Legs at random
    // -Stick Drift 
    // -Heavier Gravity
    // -0.3x Grip Strength
    // -Doubled Gun Recoil