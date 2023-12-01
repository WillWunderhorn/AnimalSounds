using MelonLoader;
using System.Reflection;

[assembly: AssemblyTitle(BuildInfo.ModName)]
[assembly: AssemblyCompany("Created by " + BuildInfo.ModAuthor)]

[assembly: AssemblyVersion(BuildInfo.ModVersion)]
[assembly: AssemblyFileVersion(BuildInfo.ModVersion)]

[assembly: MelonInfo(typeof(AnimalSounds.Implementation), BuildInfo.ModName, BuildInfo.ModVersion, BuildInfo.ModAuthor)]
[assembly: MelonGame("Hinterland", "TheLongDark")]


internal static class BuildInfo
{
    internal const string ModName = "AnimalSounds";
    internal const string ModAuthor = "Wunderhorn";
    internal const string ModVersion = "1.0.0";
}



