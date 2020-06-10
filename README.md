# NuGetForUnity-Package

NuGetForUnity formatted to be used with the Unity Package manager. This contains built libraries from https://github.com/jadack-msft/NuGetForUnity that have been versioned for easier consumption into Unity projects.

## Installation (Using Unity Package Manager, requires Unity 2019.1 or newer)

In the manifest.json file in the Packages folder of your project, add:

```js
{
  "dependencies": {
    "com.unity-packages.nuget-for-unity": "https://github.com/jadack-msft/NuGetForUnity-Package.git",
    ...
  }
}
```

This can also be done through the Unity Package Manager GUI, however different versions of Unity are unreliable when it comes to adding non-local packages.

## Developer Note

When updating this project, create a branch for the version number and update package.json with the new version number. When integrated into master, create a release with the same version number.