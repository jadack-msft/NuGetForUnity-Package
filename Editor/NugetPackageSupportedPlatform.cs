namespace NugetForUnity
{
    using System.Collections.Generic;
    using UnityEditor;

    /// <summary>
    /// Defines a supported Platform for NuGet packages
    /// A platform is defined by a name (which should be tightly coupled to BuildTargetGroup)
    /// and a list of supported library names defined as Regular Expressions
    /// </summary>
    public class NugetPackageSupportedPlatform
    {
        public BuildTargetGroup Platform;

        public List<string> LibraryNames { get; set; }

        public NugetPackageSupportedPlatform(BuildTargetGroup platform)
        {
            Platform = platform;
            LibraryNames = new List<string>();
        }

        public NugetPackageSupportedPlatform(BuildTargetGroup platform, List<string> libraryNames)
        {
            Platform = platform;
            LibraryNames = libraryNames;
        }
    }
}