using MelonLoader;

namespace AnimalSounds
{

    public class AnimalSounds : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Cecreated by: " + BuildInfo.ModAuthor);
        }
    }
}
