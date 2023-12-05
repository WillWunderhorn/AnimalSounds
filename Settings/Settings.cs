using ModSettings;
using UnityEngine;

namespace AnimalSounds
{
    internal sealed class Settings : JsonModSettings
    {
        public static Settings Instance { get; } = new Settings();

        [Name("Key")]
        [Description("Select the key (Default 'Q')")]
        public KeyCode howlButton = KeyCode.Q;

        [Name("Animal type")]
        [Description("Select the animal (Default 'Human')")]
        public Settings.AnimalType animalType = Settings.AnimalType.Human;


        internal enum AnimalType
        {
            Wolf, TimberWolf, Stag, Bear, Human
        }
    }
}
