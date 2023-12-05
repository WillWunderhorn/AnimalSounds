using ModSettings;
using UnityEngine;

namespace AnimalSounds
{
    internal sealed class Settings : JsonModSettings
    {
        public static Settings Instance { get; } = new Settings();

        [Name("Howl key")]
        [Description("Select the key for howling (Default 'Q')")]
        public KeyCode howlButton = KeyCode.Q;

        [Name("Animal type")]
        [Description("Select the animal (Default 'Wolf')")]
        public Settings.AnimalType animalType = Settings.AnimalType.Wolf;

        internal enum AnimalType
        {
            Wolf, TimberWolf, Stag, Bear, Human
        }
    }
}
