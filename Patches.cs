using Il2Cpp;
using MelonLoader;
using HarmonyLib;
using Il2CppAK;
using UnityEngine;

namespace AnimalSounds
{
    class Implementation : MelonMod
    {
        private static float lastKeyPressTime = 0f;
        private static bool isOKeyDown = false;
        private static float cooldownDuration = 5f;

        public override void OnInitializeMelon()
        {
            Settings.Instance.AddToModSettings("Animal sounds");
        }

        [HarmonyPatch(typeof(GameAudioManager), nameof(GameAudioManager.Update))]
        internal class AnimalSounds
        {
            private static Settings.AnimalType animalType;

            public static void Prefix()
            {
                KeyCode howlButton = Settings.Instance.howlButton;
                float currentTime = Time.time;

                if (currentTime - lastKeyPressTime >= cooldownDuration)
                {
                    if (Input.GetKeyDown(howlButton))
                    {
                        isOKeyDown = true;
                    }


                    if (isOKeyDown)
                    {
                        if (Settings.Instance.animalType == Settings.AnimalType.TimberWolf)
                        {
                            GameAudioManager.PlaySound(EVENTS.PLAY_TIMBERWOLFHOWL, GameManager.GetPlayerObject());
                        }
                        else if (Settings.Instance.animalType == Settings.AnimalType.Stag)
                        {
                            GameAudioManager.PlaySound(EVENTS.PLAY_DEERATTACK, GameManager.GetPlayerObject());
                        }
                        else if (Settings.Instance.animalType == Settings.AnimalType.Moose)
                        {
                            GameAudioManager.PlaySound(EVENTS.PLAY_MOOSEATTACK, GameManager.GetPlayerObject());
                        }
                        else if (Settings.Instance.animalType == Settings.AnimalType.Wolf)
                        {
                            GameAudioManager.PlaySound(EVENTS.PLAY_WOLFHOWL, GameManager.GetPlayerObject());
                        }
                        else if (Settings.Instance.animalType == Settings.AnimalType.Bear)
                        {
                            GameAudioManager.PlaySound(EVENTS.PLAY_BEARATTACK, GameManager.GetPlayerObject());
                        }
                        else if (Settings.Instance.animalType == Settings.AnimalType.Human)
                        {
                            GameAudioManager.PlaySound(EVENTS.PLAY_PLAYERDEATHSCREAM, GameManager.GetPlayerObject());
                        }

                        isOKeyDown = false;
                        lastKeyPressTime = currentTime;
                    }
                }
            }
        }
    }
}

