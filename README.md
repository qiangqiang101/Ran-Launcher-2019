# Ran Launcher 2019

Windows game launcher and patch-management tools for a Ran Online-style game server, written in Visual Basic .NET.

## Projects

- **Ran Launcher 2019** - Main WinForms launcher. Displays the launch interface, manages updates, opens news and website pages, and starts the game executable.
- **PatchMaker** - WinForms utility for preparing patch content.
- **DummyGame** - Minimal test game executable used to exercise launcher behavior.

## Features

- Autopatch
- Register/Website Browser
- News/Help Browser
- Fully customize-able
- Video Intro
- Background Video
- Window Mode/Full Screen switch runtime

## System Requirements

- Windows Vista/7/8/8.1/10/11
- Microsoft .NET Framework 4.5.2
- Screen resolution 1024 x 768 or higher

## Development Requirements

- Visual Studio 2015 or newer with the .NET desktop development workload
- Microsoft .NET Framework 4.5.2 Developer Pack

The solution targets **Any CPU** by default. The launcher also has x86 build configurations.

## Build

1. Open `Ran Launcher 2019.sln` in Visual Studio.
2. Restore or select the target framework if prompted.
3. Build the solution with **Build > Build Solution**.

The executable and supporting files are written to each project's `bin\<Configuration>` directory.

To build from a Developer Command Prompt:

```bat
msbuild "Ran Launcher 2019.sln" /p:Configuration=Release
```

## Releases

Publishing a GitHub release automatically builds the launcher and Patch Maker for `Release|Any CPU` on a Windows runner. The workflow separates their outputs into `Launcher` and `PatchMaker` folders and includes the `Optional` assets. Published releases receive a ZIP archive uploaded directly to the release, and the package is also available as a GitHub Actions artifact. DummyGame is not built by the workflow.

The workflow can also be started manually from the repository's **Actions** tab.

## Configuration

The launcher reads runtime configuration and language files from:

```text
<launcher-directory>\Data\Launcher\config.xml
<launcher-directory>\Data\Launcher\language.xml
```

Additional launcher assets, including HTML, images, video, and audio, are also loaded from the `Data\Launcher` directory. `config.xml` contains server links, the game executable name and arguments, patch address, server version, display mode, and fullscreen settings.

Keep runtime configuration and assets outside source control when they contain server-specific or deployment-specific values.

## Usage

### Launcher

Run `Launcher.exe` from the launcher project's output directory. The launch UI loads the configured server name and reads local or remote intro content according to `DisplayMethod`.

The Play action opens the update window and starts the configured game executable after update checks complete.

### Patch Maker

Run `PatchMaker.exe`, select an input directory and output directory, and start the patch task.

### Dummy Game

Run `DummyGame.exe` or `Game.exe` as the test game executable. It can be used to verify launcher-to-game process integration.

## Changelogs

### 1.4

- Fixed intro video was muted by default.
- Fixed a few more Chinese words that could not be replaced.
- Fixed the update window image slider allowing drag and drop into the main window, which caused glitches.
- Improved unpack patch file speed.
- Improved iFrame location and sizes.
- RAN logo is now separated from the main window.
- Updater now displays download speed and the last unpacked files.
- Added local HTML support.
- Added the new EP10 GUI interface. The old GUI can be found in the Optional folder.
- Added a new updater progress bar style.
- Added a fallback to use `bg.jpg` when the player's IE browser version does not support the background video.

### 1.3

- Added full English support for the update module.
- Improved background video looping; the first 15 seconds are now skipped.
- Added local HTML support.

## License

This project is licensed under the [MIT License](LICENSE).
