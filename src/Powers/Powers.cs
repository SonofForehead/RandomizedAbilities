using MelonLoader;
using BoneLib;
using BoneLib.Notifications;
using UnityEngine;
using Il2CppSLZ.Bonelab;

namespace RandomPowerEveryLevelLoad.Abilities
{
    public class Powers : MelonMod
    {
        public static Notification dblJumpNotification;
        public static Notification immortalNotification;
        public static Notification moonNotification;

        // Double Jump
        public static void DoubleJump(bool modToggle)
        {
            if (modToggle && Randomize.dblJumpChosen)
            {
                Player.RigManager.GetComponentInChildren<Il2CppSLZ.Marrow.RemapRig>().doubleJump = true;
                MelonLogger.Msg("double jump Chosen");

                dblJumpNotification = new Notification();
                dblJumpNotification.Title = "Randomized Abilities";
                dblJumpNotification.Message = "Double Jump Enabled!";
                dblJumpNotification.Type = NotificationType.Success;
                dblJumpNotification.PopupLength = 3;

                Notifier.Send(dblJumpNotification);
            }

        }

        // Immortality
        public static void Immortal(bool modToggle)
        {
            if (modToggle && Randomize.immortalChosen)
            {
                Player.RigManager.GetComponentInChildren<Il2CppSLZ.Marrow.Health>().healthMode = Il2CppSLZ.Marrow.Health.HealthMode.Invincible;
                MelonLogger.Msg("immortality Chosen");

                immortalNotification = new Notification();
                immortalNotification.Title = "Randomized Abilities";
                immortalNotification.Message = "Immortality Enabled!";
                immortalNotification.Type = NotificationType.Success;
                immortalNotification.PopupLength = 3;

                Notifier.Send(immortalNotification);
            }
        }

        // Moon Gravity
        public static void MoonGravity(bool modToggle)
        {
            if (modToggle && Randomize.moonChosen)
            {
                MelonLogger.Msg ("Moon Gravity Chosen");

                moonNotification = new Notification();
                moonNotification.Title = "Randomized Abilities";
                moonNotification.Message = "Moon Gravity Enabled!";
                moonNotification.Type = NotificationType.Success;
                moonNotification.PopupLength = 3;

                Notifier.Send(moonNotification);
            }
        }
    }
}
