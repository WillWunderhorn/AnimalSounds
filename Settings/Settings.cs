using ModSettings;
using UnityEngine;

namespace AnimalSounds
{
    internal sealed class Settings : JsonModSettings
    {
        public static Settings Instance { get; } = new Settings();

        [Name("Key")]
        [Description("Key button (Default 'Q')")]
        public KeyCode howlButton = KeyCode.Q;

        [Name("Animal type")]
        [Description("Animal type (Default 'Human')")]
        public Settings.AnimalType animalType = Settings.AnimalType.Human;


        internal enum AnimalType
        {
            Wolf, TimberWolf, Moose, Crows, Stag, Bear, Human
        }
    }
}
